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
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();

            
        }

        private void picClose_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // just for testing (DELETE AFTER DB)
            MessageBox.Show(
                $"Country: {cbCountry.Text}\n" +
                $"Sector: {cbSector.Text}\n" +
                $"Min Price: {txtMinPrice.Text}\n" +
                $"Max Price: {txtMaxPrice.Text}"
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

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
