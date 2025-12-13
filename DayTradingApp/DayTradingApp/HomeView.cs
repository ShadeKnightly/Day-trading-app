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

namespace DayTradingApp
{
    public partial class HomeView : UserControl
    {

        private homeControl homeControl;
        private User _user;


        public HomeView(User user)
        {
            InitializeComponent();
            _user = user;

            //double buffering to remove flicker on content change
            typeof(Panel).GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance)
            .SetValue(contentPanel, true, null);

            navMenu.NavButtonClicked += NavMenu_NavButtonClicked;

            NavigationHelper.LoadView(contentPanel, new homeControl());


            var stocks = DatabaseHelper.GetAllStocks();
            foreach (var s in stocks)
                Console.WriteLine($"{s.Symbol} - {s.Price}");
        }

        //to help reduce flicker when swapping views
        private void SwapView(UserControl newView)
        {
            newView.Dock = DockStyle.Fill;
            newView.Visible = false;      // hide until ready
            contentPanel.Controls.Add(newView);

            // Show the new view
            newView.Visible = true;
            newView.BringToFront();

            foreach (Control c in contentPanel.Controls.OfType<UserControl>().ToList())
                if (c != newView)
                    contentPanel.Controls.Remove(c);
        }

        protected virtual void NavMenu_NavButtonClicked(object sender, string destination)
        {
            switch (destination)
            {
                case "Home": SwapView(new homeControl()); break;
                case "Profile": SwapView(new profileControl(_user)); break;
                case "AllStocks": SwapView(new allStocksControl()); break;
                case "Watchlist": SwapView(new watchlistControl()); break;
            }
        }
    }
}

