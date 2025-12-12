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
    public partial class homeControl : UserControl
    {
        public homeControl()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void btnManageFunds_Click_1(object sender, EventArgs e)
        {
            using (var popup = new WalletForm())
            {
                popup.ShowDialog();
            }
        }
    }
}
