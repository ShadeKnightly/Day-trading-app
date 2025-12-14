using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DayTradingApp;
using DayTradingApp.Data;
using DayTradingApp.Helpers;
using System.Collections.Generic;

namespace DayTradingApp.Components
{
    public partial class allStocksControl : UserControl
    {
        private bool _syncingScroll;


        private List<StockRow> _allRows = new List<StockRow>();


        public allStocksControl()
        {
            InitializeComponent();
            this.Load += AllStocksControl_Load;

            simpleScrollBar1.Scroll += SimpleScrollBar1_Scroll;
            dgvStocks.Scroll += DgvStocks_Scroll;
        }

        private async void AllStocksControl_Load(object sender, EventArgs e)
        {
            dgvStocks.AutoGenerateColumns = true;
            dgvStocks.DataSource = null;
            dgvStocks.ScrollBars = ScrollBars.None;

            string source = "None";
            int count = 0;

            try
            {
                using var report = new MarketReport();
                var stocks = await report.GetAllStocksFromDbAsync();

                if (stocks != null && stocks.Count > 0)
                {
                    _allRows = stocks
                        .Select(s => new StockRow
                        {
                            Symbol = s.Ticker,
                            Name = s.CompanyName,
                            Exchange = s.Exchange,
                            Currency = s.Currency
                        })
                        .ToList();

                    dgvStocks.DataSource = _allRows.ToList();
                    dgvStocks.ColumnHeadersVisible = false;
                    count = _allRows.Count;
                    source = "Supabase";
                    Debug.WriteLine($"allStocksControl: bound {_allRows.Count} rows from Supabase.");
                }
                else
                {
                    Debug.WriteLine("allStocksControl: Supabase returned no rows or client unavailable; falling back to local DB.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"allStocksControl: Supabase fetch failed: {ex}");
            }

            if ((dgvStocks.DataSource == null || _allRows.Count == 0))
            {
                try
                {
                    DatabaseHelper.InitializeDatabase();
                    var local = DatabaseHelper.GetAllStocks();

                    if (local != null && local.Count > 0)
                    {
                        _allRows = local
                            .Select(s => new StockRow
                            {
                                Symbol = s.Symbol,
                                Name = s.Name,

                            })
                            .ToList();

                        dgvStocks.DataSource = _allRows.ToList();
                        count = _allRows.Count;
                        source = "LocalSeed";
                        Debug.WriteLine($"allStocksControl: bound {_allRows.Count} rows from local DB.");
                    }
                    else
                    {
                        Debug.WriteLine("allStocksControl: local DB contains no rows.");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"allStocksControl: local DB fallback failed: {ex}");
                }
            }
            SetupCustomScroll();

            dgvStocks.ClearSelection();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            using (var f = new FilterForm())
            {
                var dr = f.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    ApplyFilters(f.NameFilter, f.SymbolFilter, f.ExchangeFilter, f.CurrencyFilter);
                }
            }
        }

        private void ApplyFilters(string nameFilter, string symbolFilter, string exchangeFilter, string currencyFilter)
        {
            var filtered = _allRows.AsEnumerable();

            if (!string.IsNullOrEmpty(nameFilter))
            {
                filtered = filtered.Where(r => !string.IsNullOrEmpty(r.Name) &&
                    r.Name.IndexOf(nameFilter, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrEmpty(symbolFilter))
            {
                filtered = filtered.Where(r => !string.IsNullOrEmpty(r.Symbol) &&
                    r.Symbol.IndexOf(symbolFilter, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrEmpty(exchangeFilter))
            {
                filtered = filtered.Where(r => !string.IsNullOrEmpty(r.Exchange) &&
                    string.Equals(r.Exchange, exchangeFilter, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(currencyFilter))
            {
                filtered = filtered.Where(r => !string.IsNullOrEmpty(r.Currency) &&
                    string.Equals(r.Currency, currencyFilter, StringComparison.OrdinalIgnoreCase));
            }

            dgvStocks.DataSource = filtered.ToList();
            dgvStocks.ClearSelection();
            SetupCustomScroll();

        }


        private void SetupCustomScroll()
        {
            if (dgvStocks.RowCount == 0)
                return;

            int max =
                dgvStocks.RowCount -
                dgvStocks.DisplayedRowCount(false);

            simpleScrollBar1.Maximum = Math.Max(0, max);

            simpleScrollBar1.Value = Math.Min(
                simpleScrollBar1.Value,
                simpleScrollBar1.Maximum
            );
        }


        private void SimpleScrollBar1_Scroll(object sender, EventArgs e)
        {
            if (_syncingScroll) return;
            _syncingScroll = true;

            dgvStocks.FirstDisplayedScrollingRowIndex = simpleScrollBar1.Value;

            _syncingScroll = false;
        }

        private void DgvStocks_Scroll(object sender, ScrollEventArgs e)
        {
            if (_syncingScroll) return;
            _syncingScroll = true;

            simpleScrollBar1.Value = dgvStocks.FirstDisplayedScrollingRowIndex;

            _syncingScroll = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private class StockRow
        {
            public string Symbol { get; set; }
            public string Name { get; set; }
            public string Exchange { get; set; }
            public string Currency { get; set; }
        }
    }
}