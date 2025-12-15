using DayTradingApp.Properties;
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
    public partial class stockDetails : UserControl
    {
        private bool isInWatchlist = false;

        // Local MarketReport instance for fetching data
        private MarketReport _marketReport;

        // Currently selected stock from DB
        private StockModel _stock;

        // Currently selected range (default OneDay)
        private StockDataRange _currentRange = StockDataRange.OneDay;

        private List<Button> _rangeButtons;


        public stockDetails()
        {
            InitializeComponent();

            _rangeButtons = new List<Button>
            {
                btn1day,
                btn1week,
                btn1month,
                btn3months,
                btn1year,
                btn5years
            };


            this.Load += StockDetails_Load;

            // Wire up range buttons 
            btn1day.Click += (s, e) =>
            {
                SetActiveRangeButton(btn1day);
                ChangeRange(StockDataRange.OneDay);
            };

            btn1week.Click += (s, e) =>
            {
                SetActiveRangeButton(btn1week);
                ChangeRange(StockDataRange.OneWeek);
            };

            btn1month.Click += (s, e) =>
            {
                SetActiveRangeButton(btn1month);
                ChangeRange(StockDataRange.OneMonth);
            };

            btn3months.Click += (s, e) =>
            {
                SetActiveRangeButton(btn3months);
                ChangeRange(StockDataRange.ThreeMonths);
            };

            btn1year.Click += (s, e) =>
            {
                SetActiveRangeButton(btn1year);
                ChangeRange(StockDataRange.OneYear);
            };

            btn5years.Click += (s, e) =>
            {
                SetActiveRangeButton(btn5years);
                ChangeRange(StockDataRange.FiveYears);
            };

        }

        /// <summary>
        /// Assigns the stock to display in this details view.
        /// Default range is OneDay when a new stock is set.
        /// </summary>
        public async Task SetStockAsync(StockModel stock)
        {
            _stock = stock;
            if (_stock == null)
                return;

            // reset to default range when changing stock
            _currentRange = StockDataRange.OneDay;

            // Update basic UI labels immediately
            currency.Text = _stock.Currency ?? string.Empty;

            stockDetailsLabel.Text = _stock.Ticker + "." + _stock.Exchange ?? string.Empty;

            _marketReport ??= new MarketReport();

            // When switching stock, refresh watchlist toggle state
            await RefreshWatchlistStateAsync();

            await LoadGraphAndValueAsync();
        }

        private async Task LoadGraphAndValueAsync()
        {
            if (_stock == null)
                return;

            // Build provider ticker for EOD (e.g. AAPL.US)
            var providerTicker = string.IsNullOrWhiteSpace(_stock.Exchange)
                ? _stock.Ticker
                : $"{_stock.Ticker}.{_stock.Exchange}";

            // Load graph data for this stock and current range
            if (stockGraph1 != null)
            {
                await stockGraph1.LoadDataAsync(_marketReport, providerTicker, _currentRange);
            }

            // Always use 1-year summary for latest price (independent of graph range)
            var summary = await _marketReport.GetStockSummaryAsync(_stock.Ticker);
            if (summary != null)
            {
                value.Text = summary.Price.ToString("F2");
            }
            else
            {
                value.Text = "N/A";
            }
        }

        private async void ChangeRange(StockDataRange range)
        {
            if (_stock == null)
                return;

            _currentRange = range;
            await LoadGraphAndValueAsync();
        }

        private async void StockDetails_Load(object sender, EventArgs e)
        {
            // If a stock was already set before load, ensure default OneDay graph is shown
            if (!DesignMode && _stock != null)
            {
                _currentRange = StockDataRange.OneDay;
                _marketReport ??= new MarketReport();
                await LoadGraphAndValueAsync();
                await RefreshWatchlistStateAsync();
            }
        }

        private void SetActiveRangeButton(Button activeButton)
        {
            foreach (var btn in _rangeButtons)
            {
                btn.BackgroundImage = null;
                btn.FlatAppearance.BorderSize = 0;
            }

            activeButton.BackgroundImage = Resources.roundedBtntall;
            activeButton.BackgroundImageLayout = ImageLayout.Stretch;
        }


        private async Task RefreshWatchlistStateAsync()
        {
            if (_stock == null || UserSession.Current == null)
            {
                isInWatchlist = false;
                UpdateWatchlistUi();
                return;
            }

            try
            {
                var supabase = await SupabaseService.GetAsync();
                var userId = Guid.Parse(UserSession.Current.Id);

                var result = await supabase
                    .From<WatchlistModel>()
                    .Filter("user_id", Supabase.Postgrest.Constants.Operator.Equals, userId.ToString())
                    .Filter("ticker", Supabase.Postgrest.Constants.Operator.Equals, _stock.Ticker)
                    .Get();

                isInWatchlist = result?.Models != null && result.Models.Count > 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Failed to check watchlist: {ex.Message}");
                isInWatchlist = false;
            }

            UpdateWatchlistUi();
        }

        private async void watchlist_toggle_Click(object sender, EventArgs e)
        {
            if (_stock == null || UserSession.Current == null)
            {
                MessageBox.Show("You must be logged in to manage your watchlist.");
                return;
            }

            try
            {
                Debug.WriteLine("attempting to add/remove watchlist entry");
                var supabase = await SupabaseService.GetAsync();
                var userId = Guid.Parse(UserSession.Current.Id);

                if (!isInWatchlist)
                {
                    // Add to watchlist
                    var entry = new WatchlistModel
                    {
                        UserId = userId,
                        Ticker = _stock.Ticker,
                        AddedAt = DateTime.UtcNow
                    };

                    await supabase.From<WatchlistModel>().Insert(entry);

                    isInWatchlist = true;
                    MessageBox.Show("Stock added to watchlist.", "Watchlist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Remove from watchlist
                    await supabase
                        .From<WatchlistModel>()
                        .Filter("user_id", Supabase.Postgrest.Constants.Operator.Equals, userId.ToString())
                        .Filter("ticker", Supabase.Postgrest.Constants.Operator.Equals, _stock.Ticker)
                        .Delete();

                    isInWatchlist = false;
                    MessageBox.Show("Stock removed from watchlist.", "Watchlist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                UpdateWatchlistUi();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update watchlist: {ex.Message}");
            }
        }

        private void UpdateWatchlistUi()
        {
            if (isInWatchlist)
            {
                watchlist_toggle.BackgroundImage = Resources.removebtn;
                watchlist_toggle_lbl.Text = "Remove from Watchlist";
            }
            else
            {
                watchlist_toggle.BackgroundImage = Resources.addbtn;
                watchlist_toggle_lbl.Text = "Add to Watchlist";
            }
        }
    }
}
