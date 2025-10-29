using DayTradingApp.Components;
using DayTradingApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayTradingApp
{
    public partial class AllStocksForm : BaseForm
    {
        private homeControl homeControl;
        private allStocksControl allStocksControl;

        public AllStocksForm()
        {
            InitializeComponent();

            allStocksControl = new allStocksControl();
            allStocksControl.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(allStocksControl, 1, 1);
        }
    }
}


