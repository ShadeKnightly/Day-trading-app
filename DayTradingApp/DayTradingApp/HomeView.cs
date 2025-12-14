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


        public HomeView()
        {
            InitializeComponent();

            //double buffering to remove flicker on content change
            typeof(Panel).GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance)
            .SetValue(contentPanel, true, null);

            navMenu.NavButtonClicked += NavMenu_NavButtonClicked;

            homeControl = CreateHomeControl();
            NavigationHelper.LoadView(contentPanel, homeControl);


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
                //keep using a single homeControl instance to keep event subscriptions.
                // (ie. View More stock details button)
                case "Home": SwapView(homeControl); break;
      
                case "Profile": SwapView(new profileControl()); break;
                case "AllStocks": SwapView(new allStocksControl()); break;
                case "Watchlist": SwapView(new watchlistControl()); break;
            }
        }

        private void HomeControl_ViewMoreClicked(object sender, EventArgs e)
        {
            SwapView(new stockDetails());
        }

        private homeControl CreateHomeControl()
        {
            var hc = new homeControl();
            hc.ViewMoreClicked += HomeControl_ViewMoreClicked;
            return hc;
        }



    }
}

