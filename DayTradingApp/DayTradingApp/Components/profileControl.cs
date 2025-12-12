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
    public partial class profileControl : UserControl
    {
        public profileControl()
        {
            InitializeComponent();
        }

        private void pbAccount_Click(object sender, EventArgs e)
        {
            using (var popup = new AccountDetailsForm())
            {
                popup.ShowDialog();
            }
        }
    }
}
