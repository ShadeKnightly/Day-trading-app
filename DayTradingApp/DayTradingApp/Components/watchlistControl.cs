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

        // full StockModel list for selected lookup
        private List<StockModel> _stockModels = new List<StockModel>();

        // rows shown in the grid
        private List<WatchlistRow> _rows = new List<WatchlistRow>();

        // Event similar to allStocksControl.StockSelected
        public event Func<StockModel, Task> StockSelected;

        public watchlistControl()
        {
            InitializeComponent();
            this.Load += WatchlistControl_Load;

            // handle row click / double-click
            advancedWatchlistdgv.CellClick += AdvancedWatchlistdgv_CellClick;
            advancedWatchlistdgv.CellDoubleClick += AdvancedWatchlistdgv_CellClick;
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

        private async void AdvancedWatchlistdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= advancedWatchlistdgv.Rows.Count)
                return;

            await HandleRowSelectionAsync(e.RowIndex);
        }

        private async Task HandleRowSelectionAsync(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= advancedWatchlistdgv.Rows.Count)
                return;

            var row = advancedWatchlistdgv.Rows[rowIndex].DataBoundItem as WatchlistRow;
            if (row == null)
                return;

            // find matching StockModel by DB ticker
            var model = _stockModels.FirstOrDefault(m =>
                string.Equals(m.Ticker, row.Ticker, StringComparison.OrdinalIgnoreCase));

            if (model == null)
                return;

            if (StockSelected != null)
            {
                await StockSelected.Invoke(model);
            }
        }

        public async Task LoadWatchlistAsync()
        {
            advancedWatchlistdgv.AutoGenerateColumns = true;
            advancedWatchlistdgv.DataSource = null;
            _rows.Clear();
            _stockModels.Clear();

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

                    var dbTicker = item.Ticker.Trim();

                    // load StockModel for this ticker (for details view)
                    StockModel stockModel = null;
                    try
                    {
                        var stockResp = await supabase
                            .From<StockModel>()
                            .Filter("ticker", Supabase.Postgrest.Constants.Operator.Equals, dbTicker)
                            .Get();

                        stockModel = stockResp.Models?.FirstOrDefault();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"watchlistControl: failed to load stock model for {item.Ticker}: {ex.Message}");
                    }

                    if (stockModel != null)
                    {
                        _stockModels.Add(stockModel);
                    }

                    // run each ticker through MarketReport summary for display
                    var summary = await report.GetStockSummaryAsync(dbTicker);
                    if (summary == null)
                        continue;

                    _rows.Add(new WatchlistRow
                    {
                        Ticker = dbTicker,                        // DB ticker (e.g. AAPL)
                        Symbol = summary.Ticker,                  // display/provider ticker (e.g. AAPL.NEO)
                        Name = summary.CompanyName,
                        Price = summary.Price.ToString("F2"),
                        DailyChange = summary.DailyChangeValue.ToString("+0.00;-0.00;0.00"),
                        MonthlyChange = (summary.MonthlyChangePercent * 100.0).ToString("+0.00;-0.00;0.00") + "%",
                        YearlyChange = (summary.YearlyChangePercent * 100.0).ToString("+0.00;-0.00;0.00") + "%"
                    });
                }

                advancedWatchlistdgv.DataSource = _rows.ToList();
                advancedWatchlistdgv.ColumnHeadersVisible = false; // header labels are in designer

                // Hide the internal DB ticker column if auto-generated
                if (advancedWatchlistdgv.Columns["Ticker"] != null)
                {
                    advancedWatchlistdgv.Columns["Ticker"].Visible = false;
                }

                Debug.WriteLine($"watchlistControl: bound {_rows.Count} rows from watchlist.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"watchlistControl: failed to load watchlist: {ex}");
            }

            advancedWatchlistdgv.ClearSelection();
        }

        private class WatchlistRow
        {
            // DB ticker used for lookup
            public string Ticker { get; set; }
            // Display symbol (may include exchange suffix)
            public string Symbol { get; set; }
            public string Name { get; set; }
            public string Price { get; set; }
            public string DailyChange { get; set; }
            public string MonthlyChange { get; set; }
            public string YearlyChange { get; set; }
        }
    }
}