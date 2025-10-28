using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayTradingApp.Components
{
    public partial class NavMenu : UserControl
    {
        public NavMenu()
        {
            InitializeComponent();

            // Hook all nav buttons to the same event
            homeBtn.Click += navBtn_Click;
            watchlistBtn.Click += navBtn_Click;
            allStocksBtn.Click += navBtn_Click;
        }

        // Shared event for all button clicks
        public event EventHandler<string> NavButtonClicked;

        private void navBtn_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            string destination = string.Empty;

            if (btn.Name == "homeBtn")
                destination = "Home";
            else if (btn.Name == "watchlistBtn")
                destination = "Watchlist";
            else if (btn.Name == "allStocksBtn")
                destination = "AllStocks";

            if (!string.IsNullOrEmpty(destination))
                NavButtonClicked?.Invoke(this, destination);
        }
    }
    
}

