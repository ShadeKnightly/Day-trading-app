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

namespace DayTradingApp.Components
{
    public partial class watchlistControl : UserControl
    {
        private SimpleScrollBar _scroll;

        public watchlistControl()
        {
            InitializeComponent();
            this.Load += WatchlistControl_Load;
        }

        private void WatchlistControl_Load(object sender, EventArgs e)
        {
            _scroll = ScrollManager.Attach(
                tableContentPanel.Parent,    // viewport (tableLayoutPanel5)
                tableContentPanel,          // scrollable content
                simpleScrollBar
            );
        }
    }
}

       
    