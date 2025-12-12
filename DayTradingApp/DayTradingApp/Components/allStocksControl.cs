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
    public partial class allStocksControl : UserControl
    {
        private SimpleScrollBar _scroll;

        public allStocksControl()
        {
            InitializeComponent();
            this.Load += AllStocksControl_Load;
        }

        private void AllStocksControl_Load(object sender, EventArgs e)
        {
            _scroll = ScrollManager.Attach(
                tableContentPanel.Parent,    // viewport (tableLayoutPanel5)
                tableContentPanel,          // scrollable content
                simpleScrollBar
            );
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            using (var f = new FilterForm())
            {
                f.ShowDialog();
            }
        }
    }
}
