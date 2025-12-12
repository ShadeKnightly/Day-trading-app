using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using EOD;
using EOD.Model;
using Supabase;

namespace DayTradingApp {
    public enum StockDataRange {
        OneDay,
        OneWeek,
        OneMonth,
        ThreeMonths,
        OneYear,
        FiveYears
    }

    /// <summary>
    /// MarketReport service: fetches historical data, computes summaries,
    /// and manages minimal Supabase symbol helpers.
    /// </summary>
    internal class MarketReport : IDisposable {
        // Basic metadata
        public int reportId;
        public DateTime date;
        public string summary;

        // unified DTO for historical points
        public class PricePoint {
            public DateTime Date { get; set; }
            public double Close { get; set; }
            public decimal? Volume { get; set; }
            public double? High { get; set; }
            public double? Low { get; set; }
        }

        private readonly string apiToken = Environment.GetEnvironmentVariable("API_KEY");

        // Reusable Supabase client to avoid creating new instances on every call
        private volatile Supabase.Client _supabaseClient;
        private readonly SemaphoreSlim _supabaseInitLock = new SemaphoreSlim(1, 1);

        // toggle for initial DB load behavior
        private const bool RunInitialDbLoad = false;

        // Lightweight DTOs for UI
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

        public record StockDisplayData(
            string Ticker,
            string CompanyName,
            double Price,
            double DailyChangeValue,
            double DailyChangePercent,
            double MonthlyChangePercent,
            double YearlyChangePercent
        );

        // -------------------------
        // Supabase Client Initialization
        // -------------------------

        /// <summary>
        /// Gets or lazily initializes the shared Supabase client instance.
        /// Thread-safe initialization ensures only one client is created.
        /// </summary>
        private async Task<Supabase.Client> GetSupabaseClientAsync() {
            if (_supabaseClient != null) {
                return _supabaseClient;
            }

            await _supabaseInitLock.WaitAsync();
            try {
                if (_supabaseClient != null) {
                    return _supabaseClient;
                }

                var url = Environment.GetEnvironmentVariable("SUPABASE_URL");
                var key = Environment.GetEnvironmentVariable("SUPABASE_SERVICE_ROLE_KEY") ?? Environment.GetEnvironmentVariable("SUPABASE_KEY");

                if (string.IsNullOrWhiteSpace(url) || string.IsNullOrWhiteSpace(key)) {
                    Debug.WriteLine("Supabase URL/KEY not configured. Cannot initialize client.");
                    return null;
                }

                var options = new Supabase.SupabaseOptions { AutoConnectRealtime = false };
                _supabaseClient = new Supabase.Client(url, key, options);
                await _supabaseClient.InitializeAsync();

                Debug.WriteLine("Supabase client initialized successfully.");
                return _supabaseClient;
            }
            finally {
                _supabaseInitLock.Release();
            }
        }

        // -------------------------
        // Public API
        // -------------------------

        /// <summary>
        /// Returns a StockDisplayData summary for the given ticker (ticker must match Supabase 'ticker' column).
        /// Monthly and yearly change return double.NaN when insufficient historical data is available.
        /// </summary>
        public async Task<StockDisplayData> GetStockSummaryAsync(string ticker) {
            if (string.IsNullOrWhiteSpace(apiToken))
                throw new InvalidOperationException("API_KEY not found. Set it via environment variable, launchSettings, user-secrets, or by loading a .env file.");

            var stock = await GetStockFromDbAsync(ticker);
            if (stock is null) {
                Debug.WriteLine($"GetStockSummaryAsync: stock '{ticker}' not found in DB.");
                return null;
            }

            // build provider-style ticker (AAPL.NASDAQ or AAPL.NEO)
            var providerTicker = string.IsNullOrWhiteSpace(stock.Exchange) ? ticker : $"{ticker}.{stock.Exchange}";

            // Fetch ONE YEAR of daily history
            var historical = await GetHistoricalDataAsync(providerTicker, StockDataRange.OneYear);

            if (historical == null || historical.Count == 0) {
                Debug.WriteLine($"No historical data for {providerTicker}.");
                return null;
            }

            // Ensure ordered by date ascending
            var ordered = historical.OrderBy(p => p.Date).ToList();
            var latest = ordered.Last();
            double price = latest.Close;

            // Daily change: nearest previous trading day (strictly before latest.Date)
            var previousDay = ordered.LastOrDefault(p => p.Date < latest.Date);
            double dailyChangeValue = previousDay != null ? (price - previousDay.Close) : 0.0;
            double dailyChangePercent = (previousDay != null && previousDay.Close != 0.0)
                ? (dailyChangeValue / previousDay.Close)
                : 0.0;

            // Monthly change: nearest bar ON or BEFORE (latest.Date - 1 month)
            var monthTarget = latest.Date.AddMonths(-1);
            var priorMonth = FindNearestOnOrBefore(ordered, monthTarget);
            double monthlyChangePercent = (priorMonth != null && priorMonth.Close != 0.0)
                ? ((price - priorMonth.Close) / priorMonth.Close)
                : double.NaN;

            // Yearly change: nearest bar ON or BEFORE (latest.Date - 1 year)
            var yearTarget = latest.Date.AddYears(-1);
            var priorYear = FindNearestOnOrBefore(ordered, yearTarget, toleranceDays: 30);

            // Diagnostic logging to help debug missing data
            Debug.WriteLine($"Historical points count: {ordered.Count}");
            Debug.WriteLine($"Latest date: {latest.Date:yyyy-MM-dd}, earliest date: {ordered.First().Date:yyyy-MM-dd}");
            Debug.WriteLine($"Year target date: {yearTarget:yyyy-MM-dd}");
            Debug.WriteLine($"Found priorYear date: {(priorYear != null ? priorYear.Date.ToString("yyyy-MM-dd") : "null")}");

            double yearlyChangePercent = (priorYear != null && priorYear.Close != 0.0)
                ? ((price - priorYear.Close) / priorYear.Close)
                : double.NaN;


            // Debug / verification logs
            Debug.WriteLine($"--- Stock Summary for {providerTicker} ---");
            Debug.WriteLine($"Company Name: {stock.CompanyName}");
            Debug.WriteLine($"Price: {price:C}");
            Debug.WriteLine($"Daily Change: {dailyChangeValue:C} ({dailyChangePercent:P2})");
            Debug.WriteLine($"Monthly Change: {(double.IsNaN(monthlyChangePercent) ? "N/A" : monthlyChangePercent.ToString("P2"))}");
            Debug.WriteLine($"Yearly Change:  {(double.IsNaN(yearlyChangePercent) ? "N/A" : yearlyChangePercent.ToString("P2"))}");
            Debug.WriteLine("------------------------------------");

            return new StockDisplayData(
                providerTicker,
                stock.CompanyName,
                price,
                dailyChangeValue,
                dailyChangePercent,
                double.IsNaN(monthlyChangePercent) ? 0.0 : monthlyChangePercent,
                double.IsNaN(yearlyChangePercent) ? 0.0 : yearlyChangePercent
            );
        }

        /// <summary>
        /// Unified historical data provider. Always returns PricePoint list ordered by date (not guaranteed but callers should order).
        /// </summary>
        public async Task<List<PricePoint>> GetHistoricalDataAsync(string providerTicker, StockDataRange range) {
            if (string.IsNullOrWhiteSpace(apiToken))
                throw new InvalidOperationException("API_KEY not found. Set it in environment or config.");

            var api = new API(apiToken);
            var endDate = DateTime.Now;
            DateTime startDate;

            // We'll populate a unified list of PricePoint
            var pricePoints = new List<PricePoint>();

            try {
                switch (range) {
                    case StockDataRange.OneDay:
                        startDate = endDate.AddDays(-1);
                        var intraday1d = await api.GetIntradayHistoricalStockPriceAsync(providerTicker, startDate, endDate, API.IntradayHistoricalInterval.FiveMinutes);
                        if (intraday1d != null) {
                            pricePoints.AddRange(intraday1d
                                .Where(x => x.DateTime.HasValue && x.Close.HasValue)
                                .Select(x => new PricePoint {
                                    Date = x.DateTime.Value,
                                    Close = x.Close.Value,
                                    Volume = x.Volume,
                                    High = x.High,
                                    Low = x.Low
                                }));
                        }
                        break;

                    case StockDataRange.OneWeek:
                        startDate = endDate.AddDays(-7);
                        var intraday7 = await api.GetIntradayHistoricalStockPriceAsync(providerTicker, startDate, endDate, API.IntradayHistoricalInterval.FiveMinutes);
                        if (intraday7 != null) {
                            pricePoints.AddRange(intraday7
                                .Where(x => x.DateTime.HasValue && x.Close.HasValue)
                                .Select(x => new PricePoint {
                                    Date = x.DateTime.Value,
                                    Close = x.Close.Value,
                                    Volume = x.Volume,
                                    High = x.High,
                                    Low = x.Low
                                }));
                        }
                        break;

                    case StockDataRange.OneMonth:
                        // For one month we can use hourly intraday or daily if hourly is not available
                        startDate = endDate.AddMonths(-1);
                        var intraday1m = await api.GetIntradayHistoricalStockPriceAsync(providerTicker, startDate, endDate, API.IntradayHistoricalInterval.OneHour);
                        if (intraday1m != null && intraday1m.Count > 0) {
                            pricePoints.AddRange(intraday1m
                                .Where(x => x.DateTime.HasValue && x.Close.HasValue)
                                .Select(x => new PricePoint {
                                    Date = x.DateTime.Value,
                                    Close = x.Close.Value,
                                    Volume = x.Volume,
                                    High = x.High,
                                    Low = x.Low
                                }));
                        }
                        else {
                            // fallback to daily EOD
                            var dailyFallback = await api.GetEndOfDayHistoricalStockPriceAsync(providerTicker, startDate, endDate, API.HistoricalPeriod.Daily);
                            if (dailyFallback != null) {
                                pricePoints.AddRange(dailyFallback
                                    .Where(x => x.Date.HasValue && (x.Adjusted_close.HasValue || x.Close.HasValue))
                                    .Select(x => new PricePoint {
                                        Date = x.Date.Value,
                                        Close = x.Adjusted_close ?? x.Close ?? 0.0,
                                    }));
                            }
                        }
                        break;

                    case StockDataRange.ThreeMonths:
                        startDate = endDate.AddMonths(-3);
                        var daily3m = await api.GetEndOfDayHistoricalStockPriceAsync(providerTicker, startDate, endDate, API.HistoricalPeriod.Daily);
                        if (daily3m != null) {
                            pricePoints.AddRange(daily3m
                                .Where(x => x.Date.HasValue && (x.Adjusted_close.HasValue || x.Close.HasValue))
                                .Select(x => new PricePoint {
                                    Date = x.Date.Value,
                                    Close = x.Adjusted_close ?? x.Close ?? 0.0
                                }));
                        }
                        break;

                    case StockDataRange.OneYear:
                        // Add a padding window to be robust across holidays and timezone differences.
                        startDate = endDate.AddYears(-1).AddDays(-30);
                        var daily1y = await api.GetEndOfDayHistoricalStockPriceAsync(providerTicker, startDate, endDate, API.HistoricalPeriod.Daily);
                        if (daily1y != null) {
                            pricePoints.AddRange(daily1y
                                .Where(x => x.Date.HasValue && (x.Adjusted_close.HasValue || x.Close.HasValue))
                                .Select(x => new PricePoint {
                                    Date = x.Date.Value,
                                    Close = x.Adjusted_close ?? x.Close ?? 0.0
                                }));
                        }
                        break;


                    case StockDataRange.FiveYears:
                        startDate = endDate.AddYears(-5).AddDays(-10);
                        var daily5y = await api.GetEndOfDayHistoricalStockPriceAsync(providerTicker, startDate, endDate, API.HistoricalPeriod.Daily);
                        if (daily5y != null) {
                            pricePoints.AddRange(daily5y
                                .Where(x => x.Date.HasValue && (x.Adjusted_close.HasValue || x.Close.HasValue))
                                .Select(x => new PricePoint {
                                    Date = x.Date.Value,
                                    Close = x.Adjusted_close ?? x.Close ?? 0.0
                                }));
                        }
                        break;

                    default:
                        Debug.WriteLine("GetHistoricalDataAsync: Unknown StockDataRange requested.");
                        break;
                }
            }
            catch (Exception ex) {
                Debug.WriteLine($"GetHistoricalDataAsync failed for {providerTicker}, range {range}: {ex.Message}");
            }

            // final ordering and return
            return pricePoints.OrderBy(p => p.Date).ToList();
        }

        // -------------------------
        // Helpers
        // -------------------------

        /// <summary>
        /// Finds the nearest PricePoint on or before targetDate. If none exist on or before,
        /// falls back to the closest PricePoint within a tolerance window (in days).
        /// Returns null if no suitable bar is found.
        /// </summary>
        private PricePoint FindNearestOnOrBefore(IList<PricePoint> list, DateTime targetDate, int toleranceDays = 30) {
            if (list == null || list.Count == 0) return null;

            // ensure list is ordered — caller usually orders, but be safe
            var ordered = list.OrderBy(p => p.Date).ToList();

            // 1) Prefer strict on-or-before (nearest earlier trading day)
            var onOrBefore = ordered.LastOrDefault(p => p.Date <= targetDate);
            if (onOrBefore != null) return onOrBefore;

            // 2) Fallback: find the absolute nearest date within toleranceDays
            var nearest = ordered.OrderBy(p => Math.Abs((p.Date - targetDate).TotalDays)).FirstOrDefault();
            if (nearest != null && Math.Abs((nearest.Date - targetDate).TotalDays) <= toleranceDays)
                return nearest;

            // 3) Nothing suitable found
            return null;
        }


        // -------------------------
        // Supabase & DB helpers (kept largely as-is but cleaned up)
        // -------------------------

        public async Task LoadMarketDataAsync() {
            if (string.IsNullOrWhiteSpace(apiToken))
                throw new InvalidOperationException("API_KEY not found.");

            var api = new API(apiToken);

            var cachePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "exchanges.txt");
            List<string> exchangeCodes;

            if (File.Exists(cachePath)) {
                exchangeCodes = File.ReadAllLines(cachePath)
                                    .Where(l => !string.IsNullOrWhiteSpace(l))
                                    .Select(l => l.Trim())
                                    .Distinct()
                                    .ToList();
                Debug.WriteLine($"Loaded {exchangeCodes.Count} exchange codes from cache: {cachePath}");
            }
            else {
                List<Exchange> exchanges = await api.GetExchangeAsync();
                exchangeCodes = exchanges.Select(e => (e?.Code?.ToString() ?? string.Empty).Trim())
                                         .Where(s => !string.IsNullOrWhiteSpace(s))
                                         .Distinct()
                                         .ToList();
                try {
                    File.WriteAllLines(cachePath, exchangeCodes);
                    Debug.WriteLine($"Wrote {exchangeCodes.Count} exchange codes to cache: {cachePath}");
                }
                catch (Exception ex) {
                    Debug.WriteLine($"Failed to write exchange cache: {ex}");
                }
            }

            if (!RunInitialDbLoad) {
                Debug.WriteLine("RunInitialDbLoad is false; skipping market data DB load.");
                return;
            }

            // Supabase setup
            var supabase = await GetSupabaseClientAsync();
            if (supabase == null) {
                Debug.WriteLine("Supabase client not available. Skipping DB upsert.");
                return;
            }

            const int exchangesToProcess = 5;
            const int tickersPerExchange = 10;

            int exchangeIndex = 0;
            bool dumpedSymbolProperties = false;

            foreach (var exchangeCode in exchangeCodes.Take(exchangesToProcess)) {
                Debug.WriteLine($"Processing exchange ({exchangeIndex + 1}/{exchangesToProcess}): {exchangeCode}");

                List<ExchangeSymbol> symbols;
                try {
                    symbols = await api.GetExchangeSymbolsAsync(exchangeCode);
                }
                catch (Exception ex) {
                    Debug.WriteLine($"Failed to fetch symbols for exchange '{exchangeCode}': {ex.Message}");
                    exchangeIndex++;
                    continue;
                }

                if (symbols == null || symbols.Count == 0) {
                    Debug.WriteLine($"No symbols returned for exchange {exchangeCode}");
                    exchangeIndex++;
                    continue;
                }

                var selected = symbols.Where(s => IsRegularStock(s)).Take(tickersPerExchange).ToList();
                Debug.WriteLine($"Selected {selected.Count} symbols for exchange {exchangeCode}");

                if (!dumpedSymbolProperties && selected.Count > 0) {
                    try {
                        var props = selected[0].GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
                        foreach (var p in props) {
                            object val;
                            try { val = p.GetValue(selected[0]); } catch (Exception e) { val = $"<error: {e.Message}>"; }
                            Debug.WriteLine($"Symbol property: {p.Name} = {val}");
                        }
                    }
                    catch (Exception ex) {
                        Debug.WriteLine($"Failed dumping symbol properties: {ex}");
                    }
                    dumpedSymbolProperties = true;
                }

                foreach (var symbol in selected) {
                    var model = new StockModel {
                        Ticker = symbol.Code,
                        CompanyName = symbol.Name,
                        Exchange = exchangeCode,
                        Type = symbol.Type,
                        Currency = symbol.Currency,
                        IsDelisted = false
                    };

                    try {
                        await supabase.From<StockModel>().Insert(model);
                        Debug.WriteLine($"Inserted {model.Ticker} ({exchangeCode})");
                    }
                    catch (Supabase.Postgrest.Exceptions.PostgrestException pex) {
                        Debug.WriteLine($"Insert Postgrest failed for {model.Ticker} ({exchangeCode}): status={pex.StatusCode}, message={pex.Message}");
                    }
                    catch (Exception ex) {
                        Debug.WriteLine($"Insert failed for {model.Ticker} ({exchangeCode}): {ex.Message}");
                    }
                }

                exchangeIndex++;
            }

            Debug.WriteLine("Market data load complete.");
        }

        private async Task<StockModel> GetStockFromDbAsync(string ticker) {
            var client = await GetSupabaseClientAsync();
            if (client == null) {
                Debug.WriteLine("Supabase client not available. Cannot fetch stock.");
                return null;
            }

            try {
                var response = await client.From<StockModel>().Filter("ticker", Supabase.Postgrest.Constants.Operator.Equals, ticker).Single();
                return response;
            }
            catch (Exception ex) {
                Debug.WriteLine($"GetStockFromDbAsync error for '{ticker}': {ex.Message}");
                return null;
            }
        }

        private async Task<List<StockModel>> GetAllStocksFromDbAsync() {
            var client = await GetSupabaseClientAsync();
            if (client == null) {
                Debug.WriteLine("Supabase client not available. Cannot fetch stocks.");
                return new List<StockModel>();
            }

            try {
                var response = await client.From<StockModel>().Get();
                return response.Models ?? new List<StockModel>();
            }
            catch (Exception ex) {
                Debug.WriteLine($"GetAllStocksFromDbAsync error: {ex.Message}");
                return new List<StockModel>();
            }
        }

        private string MaskKeyPrefix(string key) {
            if (string.IsNullOrEmpty(key)) return "<missing>";
            var t = key.Trim();
            return t.Length <= 16 ? t : t.Substring(0, 16) + "...";
        }

        /// <summary>
        /// Heuristic to accept only regular common-stock tickers (avoids provider internal IDs and funds).
        /// </summary>
        private bool IsRegularStock(ExchangeSymbol symbol) {
            if (symbol == null) return false;

            var type = (symbol.Type ?? string.Empty).Trim().ToUpperInvariant();
            var stockTypes = new HashSet<string> { "COMMON", "COMMON STOCK", "STOCK", "EQUITY" };
            if (!stockTypes.Contains(type)) return false;

            var code = (symbol.Code ?? string.Empty).Trim().ToUpperInvariant();
            if (string.IsNullOrWhiteSpace(code)) return false;
            if (code.StartsWith("0P0000")) return false; // provider internal ids
            if (code.Length < 1 || code.Length > 6) return false;
            if (!code.All(c => char.IsLetterOrDigit(c))) return false;

            return true;
        }

        // -------------------------
        // IDisposable Implementation
        // -------------------------

        /// <summary>
        /// Disposes resources used by MarketReport, including the Supabase client and synchronization lock.
        /// </summary>
        public void Dispose() {
            _supabaseInitLock?.Dispose();
            
            // Dispose Supabase client if it implements IDisposable
            if (_supabaseClient is IDisposable disposableClient) {
                disposableClient.Dispose();
            }
        }
    }
}
