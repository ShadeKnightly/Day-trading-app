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

namespace DayTradingApp {
    public partial class HomeView : UserControl {

        private homeControl homeControl;

        public HomeView() {
            InitializeComponent();

            navMenu.NavButtonClicked += NavMenu_NavButtonClicked;

            NavigationHelper.LoadView(contentPanel, new homeControl());


            var stocks = DatabaseHelper.GetAllStocks();
            foreach (var s in stocks)
                Console.WriteLine($"{s.Symbol} - {s.Price}");
        }

        protected virtual void NavMenu_NavButtonClicked(object sender, string destination) {
            switch (destination) {
                case "Home":
                    NavigationHelper.LoadView(contentPanel, new homeControl());
                    break;

                case "Profile":
                    NavigationHelper.LoadView(contentPanel, new profileControl());
                    break;

                case "AllStocks":
                    NavigationHelper.LoadView(contentPanel, new allStocksControl());
                    break;

                case "Watchlist":
                    NavigationHelper.LoadView(contentPanel, new watchlistControl());
                    break;
            }
        }

    }
}
