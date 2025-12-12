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
    public partial class WalletForm : Form
    {
        private decimal walletBalance = 5.00m;      // UI wallet value
        private decimal tempAmount = 0.00m;        // temporary add/remove valeu
        private readonly decimal step = 5.00m;     // how much add/remove chnages

        public WalletForm()
        {
            InitializeComponent();

            lblWalletBalance.Text = $"{walletBalance:C}";
            lblTransactionAmount.Text = $"{tempAmount:C}";
        }



        // Rounded corners
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radius = 30;
            var path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            tempAmount += step;
            lblTransactionAmount.Text = $"{tempAmount:C}";
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (tempAmount - step < 0)
            {
                MessageBox.Show("Cannot go below $0.00");
                return;
            }

            tempAmount -= step;
            lblTransactionAmount.Text = $"{tempAmount:C}";
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Shadow effect
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
    }
}



//please remove all temporary functions while integrating DB