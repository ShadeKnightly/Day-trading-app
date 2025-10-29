using DayTradingApp.Components;
using DayTradingApp.Data;
using DayTradingApp.Helpers;
using System;
using System.Windows.Forms;

namespace DayTradingApp
{
    public partial class HomeForm : BaseForm
    {
        private homeControl homeControl;

        public HomeForm()
        {
            InitializeComponent();

            homeControl = new homeControl();
            homeControl.Dock = DockStyle.Fill;

            tableLayoutPanel1.Controls.Add(homeControl, 1, 1);

            var stocks = DatabaseHelper.GetAllStocks();
            foreach (var s in stocks)
                Console.WriteLine($"{s.Symbol} - {s.Price}");


        }
    }
}