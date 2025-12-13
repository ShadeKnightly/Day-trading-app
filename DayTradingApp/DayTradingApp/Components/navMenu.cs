using DayTradingApp.Properties;
using System;
using System.Windows.Forms;

namespace DayTradingApp.Components
{
    public partial class NavMenu : UserControl
    {
        public NavMenu()
        {
            InitializeComponent();

            // Assign destinations
            homeBtn.Tag = "Home";
            watchlistBtn.Tag = "Watchlist";
            allStocksBtn.Tag = "AllStocks";
        }

        public event EventHandler<string> NavButtonClicked;

        private void navBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // 1️⃣ Reset all buttons
            ResetNavButtons();

            // 2️⃣ Highlight selected button
            btn.BackgroundImage = Resources.roundedBtntall;

            // 3️⃣ Read destination
            string destination = btn.Tag?.ToString();

            // 4️⃣ Notify listeners
            if (!string.IsNullOrEmpty(destination))
            {
                NavButtonClicked?.Invoke(this, destination);
            }
        }

        private void ResetNavButtons()
        {
            homeBtn.BackgroundImage = Resources.roundedBtntall_light;
            watchlistBtn.BackgroundImage = Resources.roundedBtntall_light;
            allStocksBtn.BackgroundImage = Resources.roundedBtntall_light;
        }
    }
}
