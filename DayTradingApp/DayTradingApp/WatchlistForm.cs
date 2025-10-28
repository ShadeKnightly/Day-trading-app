using DayTradingApp.Helpers;
using DayTradingApp.Components;
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
    public partial class WatchlistForm : BaseForm
    {
        public WatchlistForm()
        {
            InitializeComponent();

            navMenu.NavButtonClicked += (s, destination) =>
    NavigationHelper.Navigate(this, destination);


        }
    }
}
