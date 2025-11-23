using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EOD;
using EOD.Model;
using EODHistoricalData;

namespace DayTradingApp {
    internal class MarketReport {
        public int reportId;
        public DateTime date;
        public string summary;

        readonly string apiToken = "demo";



        public async Task FetchFromApi() {
            var _api = new API(apiToken);

            List<Exchange> _exchangeList = await _api.GetExchangeAsync();


            //dynamically create list for each exchange??
            foreach (Exchange exchange in _exchangeList) {
                List<ExchangeSymbol> exchangeSymbols = new List<ExchangeSymbol>();

                exchangeSymbols = await _api.GetExchangeSymbolsAsync(exchange.ToString());
            }

            foreach (Exchange symbol in _exchangeList) { 
                //get 1week, 1month, 3month, 1year, 5year end of day prices and cache them. 
            }
        }
        public void DisplayReport() {

        }
    }
}
