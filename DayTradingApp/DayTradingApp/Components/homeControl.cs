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
using DayTradingApp.models;

namespace DayTradingApp.Components
{
    public partial class homeControl : UserControl
    {
        // ViewMoreClicked now passes the currently selected ticker (or null)
        public event EventHandler<string> ViewMoreClicked;

        private List<WatchlistRow> _watchlistRows = new List<WatchlistRow>();

        // Tracks the ticker currently shown in the stock overview
        private string _currentOverviewTicker;

        public homeControl()
        {
            InitializeComponent();
            this.Load += HomeControl_Load;

            // handle row click on watchlist grid
            dgvWatchList.CellClick += DgvWatchList_CellClick;
            dgvWatchList.CellDoubleClick += DgvWatchList_CellClick;
        }

        private async void HomeControl_Load(object sender, EventArgs e)
        {
            // configure grid similar to allStocksControl
            dgvWatchList.ReadOnly = true;
            dgvWatchList.AllowUserToAddRows = false;
            dgvWatchList.AllowUserToDeleteRows = false;
            dgvWatchList.AllowUserToResizeRows = false;
            dgvWatchList.AllowUserToResizeColumns = false;
            dgvWatchList.MultiSelect = false;
            dgvWatchList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWatchList.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvWatchList.AutoGenerateColumns = true;

            await LoadWatchlistAsync();
        }

        private async void DgvWatchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvWatchList.Rows.Count)
                return;

            var row = dgvWatchList.Rows[e.RowIndex].DataBoundItem as WatchlistRow;
            if (row == null)
                return;

            await LoadStockOverviewAsync(row.Symbol);
        }

        private async Task LoadStockOverviewAsync(string ticker)
        {
            if (string.IsNullOrWhiteSpace(ticker))
                return;

            try
            {
                var report = new MarketReport();
                var summary = await report.GetStockSummaryAsync(ticker);
                if (summary == null)
                    return;

                _currentOverviewTicker = ticker;

                // symbol label
                symbolLbl.Text = summary.Ticker;

                // current price
                currentPriceLbl.Text = summary.Price.ToString("F2");

                // daily gain/loss value and percent
                dailyGainLossLbl.Text = summary.DailyChangeValue.ToString("+0.00;-0.00;0.00");
                dailyPercentLbl.Text = (summary.DailyChangePercent * 100.0).ToString("+0.00;-0.00;0.00") + "%";
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"homeControl: failed to load stock overview for {ticker}: {ex.Message}");
            }
        }

        public async Task LoadWatchlistAsync()
        {
            dgvWatchList.DataSource = null;
            _watchlistRows.Clear();

            if (UserSession.Current == null)
            {
                Debug.WriteLine("homeControl: no user session, watchlist not loaded.");
                return;
            }

            try
            {
                var supabase = await SupabaseService.GetAsync();
                var userId = Guid.Parse(UserSession.Current.Id);

                // Get watchlist entries for current user
                var wlResponse = await supabase
                    .From<WatchlistModel>()
                    .Filter("user_id", Supabase.Postgrest.Constants.Operator.Equals, userId.ToString())
                    .Get();

                var watchlistItems = wlResponse?.Models ?? new List<WatchlistModel>();
                if (watchlistItems.Count == 0)
                {
                    Debug.WriteLine("homeControl: watchlist empty.");
                    return;
                }

                var client = await GetSupabaseClientForStocksAsync();

                foreach (var item in watchlistItems)
                {
                    try
                    {
                        StockModel stock = null;

                        if (client != null)
                        {
                            var ticker = item.Ticker?.Trim();
                            var stockResp = await client
                                .From<StockModel>()
                                .Filter("ticker", Supabase.Postgrest.Constants.Operator.Equals, ticker)
                                .Get();

                            stock = stockResp.Models?.FirstOrDefault();
                        }

                        Debug.WriteLine($"Loading watchlist item ticker={item.Ticker}");
                        if (stock == null)
                        {
                            Debug.WriteLine($"No stock row found for ticker {item.Ticker}");
                        }
                        else
                        {
                            Debug.WriteLine($"stock from response: {stock.Ticker} - {stock.CompanyName} ({stock.Currency})");
                        }
                        _watchlistRows.Add(new WatchlistRow
                        {
                            Symbol = item.Ticker,
                            Name = stock?.CompanyName ?? string.Empty,
                            Currency = stock?.Currency ?? string.Empty,
                        });
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"homeControl: failed loading watchlist item {item.Ticker}: {ex.Message}");
                    }
                }

                dgvWatchList.DataSource = _watchlistRows.ToList();
                dgvWatchList.ClearSelection();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"homeControl: failed to load watchlist: {ex}");
            }
        }

        private async Task<Supabase.Client> GetSupabaseClientForStocksAsync()
        {
            try
            {
                var supabase = await SupabaseService.GetAsync();
                return supabase;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"homeControl: failed to get Supabase client for stocks: {ex.Message}");
                return null;
            }
        }

        private void viewMore_btn_Click(object sender, EventArgs e)
        {
            // Raise event with the ticker currently loaded in the overview (may be null)
            ViewMoreClicked?.Invoke(this, _currentOverviewTicker);
        }

        private class WatchlistRow
        {
            public string Symbol { get; set; }
            public string Name { get; set; }
            public string Currency { get; set; }
        }
    }
}
