using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DayTradingApp
{
    public partial class AccountDetailsForm : Form
    {
        public AccountDetailsForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        
        private bool ValidateInputs()
        {
            bool ok = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Name is required");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                errorProvider1.SetError(txtEmail, "Valid email required");
                ok = false;
            }

            if (txtPassword.Text.Length < 6)
            {
                errorProvider1.SetError(txtPassword, "Min 6 characters");
                ok = false;
            }

            return ok;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            MessageBox.Show("Details saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
