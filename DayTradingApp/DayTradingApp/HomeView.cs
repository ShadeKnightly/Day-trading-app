using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DayTradingApp.Components;
using DayTradingApp.Data;
using DayTradingApp.Helpers;
using DayTradingApp.models;

namespace DayTradingApp
{
    public partial class HomeView : UserControl
    {

        private homeControl homeControl;
        private User _user;

        // Reuse instances so we can keep event subscriptions
        private allStocksControl _allStocksControl;
        private stockDetails _stockDetails;
        private watchlistControl _watchlistControl;

        public HomeView(User user)
        {
            InitializeComponent();
            _user = user;

            //double buffering to remove flicker on content change
            typeof(Panel).GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance)
            .SetValue(contentPanel, true, null);

            navMenu.NavButtonClicked += NavMenu_NavButtonClicked;

            homeControl = CreateHomeControl();
            NavigationHelper.LoadView(contentPanel, homeControl);


            var stocks = DatabaseHelper.GetAllStocks();
            foreach (var s in stocks)
                Console.WriteLine($"{s.Symbol} - {s.Price}");
        }

        //to help reduce flicker when swapping views
        private void SwapView(UserControl newView)
        {
            newView.Dock = DockStyle.Fill;
            newView.Visible = false;      // hide until ready
            contentPanel.Controls.Add(newView);

            // Show the new view
            newView.Visible = true;
            newView.BringToFront();

            foreach (Control c in contentPanel.Controls.OfType<UserControl>().ToList())
                if (c != newView)
                    contentPanel.Controls.Remove(c);
        }

        protected virtual void NavMenu_NavButtonClicked(object sender, string destination)
        {
            switch (destination)
            {

                //keep using a single homeControl instance to keep event subscriptions.
                // (ie. View More stock details button)
                case "Home": SwapView(homeControl); break;

                case "Profile": SwapView(new profileControl(_user)); break;

                case "AllStocks":
                    if (_allStocksControl == null)
                    {
                        _allStocksControl = new allStocksControl();
                        _allStocksControl.StockSelected += OnStockSelectedAsync;
                    }
                    SwapView(_allStocksControl);
                    break;

                case "Watchlist":
                    if (_watchlistControl == null)
                    {
                        _watchlistControl = new watchlistControl();
                        _watchlistControl.StockSelected += OnStockSelectedAsync;
                    }
                    SwapView(_watchlistControl);
                    break;
            }
        }

        private void EnsureStockDetails()
        {
            if (_stockDetails != null)
                return;

            _stockDetails = new stockDetails();
            _stockDetails.WatchlistChanged += StockDetails_WatchlistChanged;
        }

        private async void StockDetails_WatchlistChanged(object sender, EventArgs e)
        {
            try
            {
                // refresh small watchlist on home screen
                if (homeControl != null)
                {
                    await homeControl.LoadWatchlistAsync();
                }

                // refresh full watchlist view if already created
                if (_watchlistControl != null)
                {
                    await _watchlistControl.LoadWatchlistAsync();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"HomeView: failed to refresh watchlists after change: {ex}");
            }
        }

        private async void HomeControl_ViewMoreClicked(object sender, string ticker)
        {
            if (string.IsNullOrWhiteSpace(ticker))
            {
                // No stock selected in overview; just show empty details
                EnsureStockDetails();
                SwapView(_stockDetails);
                return;
            }

            // Resolve ticker to StockModel from Supabase
            StockModel model = null;
            try
            {
                var report = new MarketReport();
                var all = await report.GetAllStocksFromDbAsync();
                model = all.FirstOrDefault(m => string.Equals(m.Ticker, ticker, StringComparison.OrdinalIgnoreCase));
            }
            catch
            {
                // swallow and fall back to empty details
            }

            EnsureStockDetails();

            if (model != null)
            {
                await _stockDetails.SetStockAsync(model);
            }

            SwapView(_stockDetails);
        }

        private async Task OnStockSelectedAsync(StockModel model)
        {
            if (model == null)
                return;

            EnsureStockDetails();

            await _stockDetails.SetStockAsync(model);
            SwapView(_stockDetails);
        }

        private homeControl CreateHomeControl()
        {
            var hc = new homeControl();
            hc.ViewMoreClicked += HomeControl_ViewMoreClicked;
            return hc;
        }
    }
}

