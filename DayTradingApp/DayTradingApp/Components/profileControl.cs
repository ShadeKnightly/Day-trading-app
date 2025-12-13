using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayTradingApp.Components
{
    public partial class profileControl : UserControl
    {
        private User _user;

        // Added a parameterless constructor for the designer
        public profileControl()
        {
            InitializeComponent();
        }

        public profileControl(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void pbAccount_Click(object sender, EventArgs e)
        {
            // Fallback to session if local user not set
            var user = _user ?? UserSession.Current;
            if (user == null) {
                Debug.WriteLine("user is null");
                return;
            } // or handle error

            using (var popup = new AccountDetailsForm(user))
            {
                popup.ShowDialog();
            }
        }
    }
}
