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
using DayTradingApp.models;

namespace DayTradingApp
{
    public partial class AccountDetailsForm : Form
    {
        private User _user;
        private bool _editMode = false;

        public AccountDetailsForm(User user)
        {
            InitializeComponent();
            _user = user ?? UserSession.Current;
            InitializeUserFields();

            // prevent edit by default
            txtName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPassword.ReadOnly = true;
            // hiding password by default
            txtPassword.UseSystemPasswordChar = true;

            // making the popup rounded on load
            ApplyRoundedEdges();
        }

        private void InitializeUserFields()
        {
            if (_user != null)
            {
                txtName.Text = _user.Name;
                txtEmail.Text = _user.Email;
            }
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

        private async void btnSave_Click(object sender, EventArgs e) {
            if (!_editMode)
                return;

            if (!ValidateInputs())
                return;

            try {
                var supabase = await SupabaseService.GetAsync();

                // 1. Update username (public.users)
                var appUserUpdate = new AppUser {
                    Id = Guid.Parse(_user.Id),
                    Username = txtName.Text
                };

                await supabase
                    .From<AppUser>()
                    .Update(appUserUpdate);

                // Update local user
                _user.Name = txtName.Text;

                // Exit edit mode
                _editMode = false;
                txtName.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtPassword.Clear();

                MessageBox.Show("Details updated successfully.");
            }
            catch (Exception ex) {
                MessageBox.Show($"Update failed:\n{ex.Message}");
            }
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

            return ok;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _editMode = true;

            txtName.ReadOnly = false;
            //txtEmail.ReadOnly = false;
            //txtPassword.ReadOnly = false;

            txtName.Focus();
        }
    }
}