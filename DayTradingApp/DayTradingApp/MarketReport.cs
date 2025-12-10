using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EOD;
using EOD.Model;
using Supabase;

namespace DayTradingApp {
    internal class MarketReport {
        public int reportId;
        public DateTime date;
        public string summary;

        private List<IntradayHistoricalStockPrice> closes;
        private readonly string apiToken = Environment.GetEnvironmentVariable("API_KEY");

        // lightweight DTO used to prepare data for the UI
        private record StockSummary(
            string Ticker,
            string CompanyName,
            string Exchange,
            double Last,
            double Open,
            double High,
            double Low,
            double Change,
            double PercentChange,
            double Average,
            long Volume
        );

        public async Task LoadMarketDataAsync() {
            if (string.IsNullOrWhiteSpace(apiToken))
                throw new InvalidOperationException("API_KEY not found. Set it in environment, launchSettings, user-secrets or load .env.");
            // set up api connection
            var api = new API(apiToken);
            List<Exchange> exchanges = await api.GetExchangeAsync();

            //------------------
            // setup supabase connection
            var url = Environment.GetEnvironmentVariable("SUPABASE_URL");
            var key = Environment.GetEnvironmentVariable("SUPABASE_KEY");
            var serviceKey = Environment.GetEnvironmentVariable("SUPABASE_SERVICE_ROLE_KEY");

            // prefer service role key for server-side writes; fall back to SUPABASE_KEY (often publishable/anon)
            var supabaseKey = !string.IsNullOrWhiteSpace(serviceKey) ? serviceKey : key;

            if (string.IsNullOrWhiteSpace(url) || string.IsNullOrWhiteSpace(supabaseKey)) {
                System.Diagnostics.Debug.WriteLine("Supabase URL/KEY not set. Skipping DB upsert.");
            }

            // small debug: log which key prefix we're using (masked)
            System.Diagnostics.Debug.WriteLine($"Using Supabase key prefix: {MaskKeyPrefix(supabaseKey)}");

            var options = new Supabase.SupabaseOptions {
                AutoConnectRealtime = false
            };

            var supabase = new Supabase.Client(url, supabaseKey, options);
            await supabase.InitializeAsync();
            try {
                var test = await supabase.From<StockModel>().Limit(1).Get();
                System.Diagnostics.Debug.WriteLine("Supabase test query succeeded");
            }
            catch (Supabase.Postgrest.Exceptions.PostgrestException pex) {
                System.Diagnostics.Debug.WriteLine($"Supabase test failed: status={pex.StatusCode}, message={pex.Message}");
            }
            catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine($"Supabase test failed: {ex}");
            }
            //-------------------------
            // save to DB

            // Limit processed exchanges and upsert attempts to reduce POST traffic during testing
            const int maxExchangesToProcess = 5; // cap how many exchanges we iterate
            const int maxUpsertAttempts = 10;    // total POST attempts to supabase

            int exchangeIndex = 0;
            int upsertAttempts = 0;

            foreach (var exchange in exchanges) {
                if (exchangeIndex >= maxExchangesToProcess) {
                    System.Diagnostics.Debug.WriteLine($"Reached exchange processing limit ({maxExchangesToProcess}). Skipping remaining exchanges.");
                    break;
                }

                string exchangeCode = exchange.Code.ToString();

                // Log the exchange code so we can see which codes produce errors
                System.Diagnostics.Debug.WriteLine($"Fetching symbols for exchange: {exchangeCode}");

                // get symbols for exchange from api
                List<ExchangeSymbol> symbols;
                try {
                    symbols = await api.GetExchangeSymbolsAsync(exchangeCode);
                }
                catch (Exception ex) {
                    // If the API returns 404/Not Found for certain exchanges, log and continue
                    System.Diagnostics.Debug.WriteLine($"Failed to fetch symbols for exchange '{exchangeCode}': {ex.Message}");
                    // Skip this exchange and continue with others
                    exchangeIndex++;
                    continue;
                }

                if (symbols == null || symbols.Count == 0) {
                    System.Diagnostics.Debug.WriteLine($"No symbols returned for exchange {exchangeCode}");
                    exchangeIndex++;
                    continue;
                }

                // upsert each symbol into stocks table in supabase
                foreach (var symbol in symbols) {
                    if (upsertAttempts >= maxUpsertAttempts) {
                        System.Diagnostics.Debug.WriteLine($"Reached max upsert attempts ({maxUpsertAttempts}). Stopping upserts.");
                        break;
                    }

                    var model = new StockModel {
                        Ticker = symbol.Code,
                        CompanyName = symbol.Name,
                        Exchange = exchangeCode,
                        Type = symbol.Type,
                        Currency = symbol.Currency,
                        IsDelisted = false
                    };

                    try {
                        // Count the attempt before sending to reduce total POSTs
                        upsertAttempts++;
                        await supabase.From<StockModel>().Upsert(model);
                    }
                    catch (Supabase.Postgrest.Exceptions.PostgrestException pex) {
                        // log status code and message to help diagnose 401/403/42501 cases
                        System.Diagnostics.Debug.WriteLine($"Upsert Postgrest failed for {symbol.Code} ({exchangeCode}): status={pex.StatusCode}, message={pex.Message}");
                    }
                    catch (Exception ex) {
                        System.Diagnostics.Debug.WriteLine($"Upsert failed for {symbol.Code} ({exchangeCode}): {ex.Message}");
                    }
                }

                Console.WriteLine($"Processed exchange {exchangeCode}, current upsert attempts: {upsertAttempts}");

                if (upsertAttempts >= maxUpsertAttempts) {
                    System.Diagnostics.Debug.WriteLine("Max upsert attempts reached — exiting exchange loop.");
                    break;
                }

                exchangeIndex++;
            }

            // After storing symbols in DB prepare data summaries for display (console output)
            // For MVP we'll prepare summaries for a small set of tickers per exchange to avoid excessive API calls
            foreach (var exchange in exchanges) {
                string exchangeCode = exchange.ToString();
                var tickers = await FetchStockFromExchangeAsync(supabase, exchangeCode);

                // limit to first 10 tickers per exchange to prepare sample data
                foreach (var ticker in tickers.Take(10)) {
                    var intraday = await FetchStockFromApiAsync(ticker);
                    if (intraday == null || intraday.Count == 0) {
                        System.Diagnostics.Debug.WriteLine($"No intraday data for {ticker}");
                        continue;
                    }

                    var summary = ComputeSummary(ticker, intraday);
                    System.Diagnostics.Debug.WriteLine($"{summary.Ticker} | {summary.CompanyName} | {summary.Exchange} | Last: {summary.Last:F2} | Change: {summary.Change:F2} ({summary.PercentChange:P2}) | Avg: {summary.Average:F2}");
                }
            }

            // finished
            System.Diagnostics.Debug.WriteLine("Market data load complete.");
        }

        private string MaskKeyPrefix(string key)
        {
            if (string.IsNullOrEmpty(key)) return "<missing>";
            var t = key.Trim();
            // return the first 16 characters for identification but don't reveal the whole key
            return t.Length <= 16 ? t : t.Substring(0, 16) + "...";
        }

        private StockSummary ComputeSummary(string ticker, List<IntradayHistoricalStockPrice> intraday) {
            // order by available DateTime property on the intraday item
            var ordered = intraday.OrderBy(p => p.DateTime).ToList();
            double first = ordered.First().Close ?? 0.0;
            double last = ordered.Last().Close ?? 0.0;
            double high = ordered.Max(p => (double?)(p.High) ?? 0.0);
            double low = ordered.Min(p => (double?)(p.Low) ?? 0.0);
            double total = ordered.Sum(p => (double?)(p.Close) ?? 0.0);
            long volume = ordered.Sum(p => (long?)(p.Volume) ?? 0L);

            double change = last - first;
            double percent = first != 0.0 ? change / first : 0.0;
            double avg = ordered.Count > 0 ? total / ordered.Count : 0.0;

            // company name and exchange will be filled later by lookup in DB when needed; keep placeholders
            return new StockSummary(ticker, CompanyName: string.Empty, Exchange: string.Empty,
                                    Last: last, Open: first, High: high, Low: low,
                                    Change: change, PercentChange: percent, Average: avg, Volume: volume);
        }

        // Fetch tickers for exchange from Supabase stocks table
        private async Task<List<string>> FetchStockFromExchangeAsync(Supabase.Client supabase, string exchange) {
            try {
                var resp = await supabase.From<StockModel>().Filter("exchange", Supabase.Postgrest.Constants.Operator.Equals, exchange).Get();
                // resp.Models is a dynamic list; attempt to cast
                var tickers = new List<string>();
                if (resp.Models is IEnumerable<StockModel> list) {
                    foreach (var s in list) tickers.Add(s.Ticker);
                }
                else if (resp.Model != null) {
                    // single model
                    if (resp.Model is StockModel single) tickers.Add(single.Ticker);
                }

                return tickers;
            }
            catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine($"Failed to query stocks for exchange {exchange}: {ex.Message}");
                return new List<string>();
            }
        }

        public async Task<List<IntradayHistoricalStockPrice>> FetchStockFromApiAsync(string ticker) {
            var api = new API(apiToken);

            DateTime start = DateTime.Today;
            DateTime end = DateTime.Today.AddDays(1).AddSeconds(-1);

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
                System.Diagnostics.Debug.WriteLine("No data available.");
                return;
            }

            double highest = double.MinValue;
            double lowest = double.MaxValue;
            double total = 0;

            foreach (var p in closes) {
                double close = p.Close ?? 0.0;

                if (close > highest) highest = close;
                if (close < lowest) lowest = close;

                total += close;
            }

            double average = closes.Count > 0 ? total / closes.Count : 0.0;

            System.Diagnostics.Debug.WriteLine("Daily Summary:");
            System.Diagnostics.Debug.WriteLine($"Highest: {highest:F2}");
            System.Diagnostics.Debug.WriteLine($"Lowest:  {lowest:F2}");
            System.Diagnostics.Debug.WriteLine($"Average: {average:F2}");
        }
    }
}
