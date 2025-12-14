using DayTradingApp.Properties;
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
    public partial class stockDetails : UserControl
    {
        private bool isInWatchlist = false;

        public stockDetails()
        {
            InitializeComponent();
        }

        private void watchlist_toggle_Click(object sender, EventArgs e)
        {
            isInWatchlist = !isInWatchlist;

            if (isInWatchlist)
            {
                watchlist_toggle.BackgroundImage = Resources.removebtn;
                watchlist_toggle_lbl.Text = "Remove from Watchlist";
            }
            else
            {
                watchlist_toggle.BackgroundImage = Resources.addbtn;
                watchlist_toggle_lbl.Text = "Add to Watchlist";
            }
        }



    }
}
