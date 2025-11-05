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
using EOD;
using EOD.Model;
using EODHistoricalData.Wrapper.Utils;

namespace DayTradingApp
{
    public partial class HomeForm : Form
    {
        //store api token for later use
        string apiToken = "demo";

        public HomeForm()
        {
            InitializeComponent();
            // just to run the function on form load
            getStockData();
        }
        private async void getStockData() {

            //creating a new API variable with our api token
            var _api = new API(apiToken);
            // making call for the current live stock price of the apple stock(ticker "APPL.US"
            //returns a LiveStockPrice variable
            var response = await _api.GetLiveStockPricesAsync("AAPL.US");

            //printing the stock to the debug console
            Debug.WriteLine($"Price: {response.Close}");
        }
    }
}



