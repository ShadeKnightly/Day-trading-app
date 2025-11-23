using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EOD;
using EOD.Model;

namespace DayTradingApp {
    internal class MarketReport {
        public int reportId;
        public DateTime date;
        public string summary;

        private List<IntradayHistoricalStockPrice> closes;
        private readonly string apiToken = "demo";

        public async Task LoadMarketDataAsync() {
            var api = new API(apiToken);

            List<Exchange> exchanges = await api.GetExchangeAsync();

            Dictionary<string, List<ExchangeSymbol>> exchangeDict;

            foreach (var exchange in exchanges) {
                string exchangeCode = exchange.ToString();

                // Fetch symbols for this exchange
                List<ExchangeSymbol> symbols =
                    await api.GetExchangeSymbolsAsync(exchangeCode);

                exchangeDict[exchangeCode] = symbols;
            }

            foreach (var kvp in exchangeDict) {
                string exchangeCode = kvp.Key;
                List<ExchangeSymbol> symbols = kvp.Value;

                // --- save exchange ---
                // await Database.InsertExchangeIfNotExists(exchangeCode);

                foreach (var s in symbols) {
                    // --- save symbol ---
                    // await Database.InsertStockIfNotExists(s.Code, s.Name, exchangeCode);
                }
            }
        }

        // -------------------------------------------------------------
        // 2. FetchStockFromExchangeAsync - get tickers from DB
        // -------------------------------------------------------------
        public async Task<List<string>> FetchStockFromExchangeAsync(string exchange) {
            // Query your DB for a list of tickers for this exchange
            // Example (pseudo-database call):
            //
            // var rows = await Database.QueryStocksByExchange(exchange);
            //
            // Convert to pure list of ticker symbols:

            var tickers = new List<string>();

            // foreach (var row in rows)
            //     tickers.Add(row.Ticker);

            return tickers;
        }

        public async Task<List<IntradayHistoricalStockPrice>> FetchStockFromApiAsync(string ticker) {
            var api = new API(apiToken);

            DateTime start = DateTime.Today;
            DateTime end = DateTime.Today.AddDays(1).AddSeconds(-1);

            // fetch 5-minute interval prices for today
            closes = await api.GetIntradayHistoricalStockPriceAsync(
                ticker,
                start,
                end,
                API.IntradayHistoricalInterval.FiveMinutes
            );

            return closes;
        }

        public void DisplayReport() {
            if (closes == null || closes.Count == 0) {
                Console.WriteLine("No data available.");
                return;
            }

            double? highest = double.MinValue;
            double? lowest = double.MaxValue;
            double? total = 0;

            foreach (var p in closes) {
                double? close = p.Close;

                if (close > highest) highest = close;
                if (close < lowest) lowest = close;

                total += close;
            }

            double? average = total / closes.Count;

            Console.WriteLine("Daily Summary:");
            Console.WriteLine($"Highest: {highest}");
            Console.WriteLine($"Lowest:  {lowest}");
            Console.WriteLine($"Average: {average}");
        }
    }
}
