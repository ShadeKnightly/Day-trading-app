using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

            // hiding password by default
            txtPassword.UseSystemPasswordChar = true;

            // making the popup rounded on load
            ApplyRoundedEdges();
        }

        // using Win32 to make the form corners round
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int left, int top, int right, int bottom,
            int width, int height
        );

        private void ApplyRoundedEdges()
        {
            // setting region so the popup has rounded corners
            this.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, Width, Height, 25, 25)
            );
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // adding a soft shadow behind the popup (looks cleaner)
            using (SolidBrush b = new SolidBrush(Color.FromArgb(40, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(
                    b,
                    6, 6,
                    this.Width - 12,
                    this.Height - 12
                );
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // closing popup
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // toggling password display
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // basic validation before saving
            if (!ValidateInputs())
                return;

            MessageBox.Show("Details saved successfully!");
        }

        private bool ValidateInputs()
        {
            // validating required fields
            bool ok = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Name is required");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                errorProvider1.SetError(txtEmail, "Enter a valid email");
                ok = false;
            }

            if (txtPassword.Text.Length < 6)
            {
                errorProvider1.SetError(txtPassword, "Minimum 6 characters");
                ok = false;
            }

            return ok;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }
    }
}