using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DayTradingApp.Helpers;
using DayTradingApp.models;

namespace DayTradingApp.Components
{
    public partial class watchlistControl : UserControl
    {
        private SimpleScrollBar _scroll;

        // rows shown in the grid
        private List<WatchlistRow> _rows = new List<WatchlistRow>();

        public watchlistControl()
        {
            InitializeComponent();
            this.Load += WatchlistControl_Load;
        }

        private async void WatchlistControl_Load(object sender, EventArgs e)
        {

            // Grid configuration similar to allStocksControl
            advancedWatchlistdgv.ReadOnly = true;
            advancedWatchlistdgv.AllowUserToAddRows = false;
            advancedWatchlistdgv.AllowUserToDeleteRows = false;
            advancedWatchlistdgv.AllowUserToResizeRows = false;
            advancedWatchlistdgv.AllowUserToResizeColumns = false;
            advancedWatchlistdgv.MultiSelect = false;
            advancedWatchlistdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            advancedWatchlistdgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            advancedWatchlistdgv.AutoGenerateColumns = true;

            await LoadWatchlistAsync();
        }

        private async Task LoadWatchlistAsync()
        {
            advancedWatchlistdgv.AutoGenerateColumns = true;
            advancedWatchlistdgv.DataSource = null;
            _rows.Clear();

            if (UserSession.Current == null)
            {
                Debug.WriteLine("watchlistControl: no user session, watchlist not loaded.");
                return;
            }

            try
            {
                var supabase = await SupabaseService.GetAsync();
                var userId = Guid.Parse(UserSession.Current.Id);

                // get watchlist entries for this user
                var wlResponse = await supabase
                    .From<WatchlistModel>()
                    .Filter("user_id", Supabase.Postgrest.Constants.Operator.Equals, userId.ToString())
                    .Get();

                var watchlistItems = wlResponse?.Models ?? new List<WatchlistModel>();
                if (watchlistItems.Count == 0)
                {
                    Debug.WriteLine("watchlistControl: watchlist empty.");
                    return;
                }

                using var report = new MarketReport();

                foreach (var item in watchlistItems)
                {
                    if (string.IsNullOrWhiteSpace(item.Ticker))
                        continue;

                    // run each ticker through MarketReport summary
                    var summary = await report.GetStockSummaryAsync(item.Ticker.Trim());
                    if (summary == null)
                        continue;

                    _rows.Add(new WatchlistRow {
                        Symbol = summary.Ticker,
                        Name = summary.CompanyName,
                        Price = summary.Price.ToString("F2"),
                        DailyChange = summary.DailyChangeValue.ToString("+0.00;-0.00;0.00"),
                        MonthlyChange = (summary.MonthlyChangePercent * 100.0).ToString("+0.00;-0.00;0.00") + "%",
                        YearlyChange = (summary.YearlyChangePercent * 100.0).ToString("+0.00;-0.00;0.00") + "%"
                    });
                }

                advancedWatchlistdgv.DataSource = _rows.ToList();
                advancedWatchlistdgv.ColumnHeadersVisible = false; // header labels are in designer
                Debug.WriteLine($"watchlistControl: bound {_rows.Count} rows from watchlist.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"watchlistControl: failed to load watchlist: {ex}");
            }

            advancedWatchlistdgv.ClearSelection();
        }

        private class WatchlistRow {
            public string Symbol { get; set; }
            public string Name { get; set; }
            public string Price { get; set; }
            public string DailyChange { get; set; }
            public string MonthlyChange { get; set; }
            public string YearlyChange { get; set; }
        }
    }
}