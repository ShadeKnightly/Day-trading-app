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
        private readonly ToolTip _nameTooltip = new ToolTip();

        // Parameterless constructor for the designer
        public profileControl()
        {
            InitializeComponent();
            Load += ProfileControl_Load;
        }

        public profileControl(User user)
        {
            InitializeComponent();
            _user = user;
            Load += ProfileControl_Load;
        }
        private void ProfileControl_Load(object sender, EventArgs e) {
            // If constructed by designer or without a user, fall back to session
            if (_user == null)
                _user = UserSession.Current;

            UpdateNameLabel();
        }

        private void UpdateNameLabel() {
            if (_user == null)
                return;

            // Prefer Username; fall back to Name if needed
            var fullDisplayName = !string.IsNullOrWhiteSpace(_user.Username)
                ? _user.Username
                : _user.Name;

            if (string.IsNullOrWhiteSpace(fullDisplayName))
                return;

            // Set tooltip to always show full name
            _nameTooltip.SetToolTip(nameLabel, fullDisplayName);

            const int maxLen = 6;
            var displayName = fullDisplayName;
            if (displayName.Length > maxLen)
                displayName = displayName.Substring(0, maxLen) + "…";

            nameLabel.Text = displayName;
        }

        private void pbAccount_Click(object sender, EventArgs e)
        {
            // Fallback to session if local user not set
            var user = _user ?? UserSession.Current;
            if (user == null) {
                Debug.WriteLine("user is null");
                return;
            }

            using (var popup = new AccountDetailsForm(user))
            {
                popup.ShowDialog();
            }
        }
    }
}
