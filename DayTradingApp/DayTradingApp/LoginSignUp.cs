using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayTradingApp {
    

    public partial class LoginSignUp : UserControl {

        public string formMode = "empty";
        public event Action<User> LoginSucceeded;

        public LoginSignUp() {
            InitializeComponent();

            this.MinimumSize = new Size(758, 854);
            this.MaximumSize = new Size(758, 854);
            this.Size = new Size(758, 854);

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();

        }

        private void login_signup_toggle_Click(object sender, EventArgs e) {
            if ((string)login_signup_toggle.Tag != "signup") {
                login_signup_toggle.BackgroundImage = Properties.Resources.toggleRight;
                login_signup_toggle.Tag = "signup";
                formMode = "signup";
                nameInput_Box.Visible = true;
            }
            else {
                login_signup_toggle.BackgroundImage = Properties.Resources.toggleLeft;
                login_signup_toggle.Tag = "login";
                formMode = "login";
                nameInput_Box.Visible = false;
            }
        }


        public void SubmitBtn_Click(object sender, EventArgs e) {
            User simulatedUser = new User {
                Username = emailInput_Box.Text,
                Name = nameInput_Box.Text,
                Id = Guid.NewGuid().ToString()
            };

            // Fire the event
            LoginSucceeded?.Invoke(simulatedUser);
        }

    }
    public class User {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
    }
}
