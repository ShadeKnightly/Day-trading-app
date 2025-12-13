using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DayTradingApp;
using DayTradingApp.Data;
using DayTradingApp.Helpers;

namespace DayTradingApp.Components
{
    public partial class allStocksControl : UserControl
    {
        private SimpleScrollBar _scroll;

        public allStocksControl()
        {
            InitializeComponent();
            this.Load += AllStocksControl_Load;
        }

        private async void AllStocksControl_Load(object sender, EventArgs e)
        {

            dgvStocks.AutoGenerateColumns = true;
            dgvStocks.DataSource = null;

            string source = "None";
            int count = 0;

            try
            {
                using var report = new MarketReport();
                var stocks = await report.GetAllStocksFromDbAsync();

                if (stocks != null && stocks.Count > 0)
                {
                    var rows = stocks
                        .Select(s => new
                        {
                            Symbol = s.Ticker,
                            Name = s.CompanyName,
                            Exchange = s.Exchange,
                            Type = s.Type,
                            Currency = s.Currency,
                            IsDelisted = s.IsDelisted
                        })
                        .ToList();

                    dgvStocks.DataSource = rows;
                    count = rows.Count;
                    source = "Supabase";
                    Debug.WriteLine($"allStocksControl: bound {rows.Count} rows from Supabase.");
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

            if (dgvStocks.DataSource == null)
            {
                try
                {
                    DatabaseHelper.InitializeDatabase();
                    var local = DatabaseHelper.GetAllStocks();

                    if (local != null && local.Count > 0)
                    {
                        var rows = local
                            .Select(s => new
                            {
                                Symbol = s.Symbol,
                                Name = s.Name,
                                Price = s.Price,
                                Change = s.Change,
                                PercentChange = s.PercentChange,
                                Volume = s.Volume,
                                Sector = s.Sector
                            })
                            .ToList();

                        dgvStocks.DataSource = rows;
                        count = rows.Count;
                        source = "LocalSeed";
                        Debug.WriteLine($"allStocksControl: bound {rows.Count} rows from local DB.");
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

            try
            {
                watchlistLabel.Text = $"All Stocks — Source: {source} (Rows: {count})";
            }
            catch
            {
                // ignore UI update errors
            }

            dgvStocks.ClearSelection();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            using (var f = new FilterForm())
            {
                f.ShowDialog();
            }
        }
    }
}