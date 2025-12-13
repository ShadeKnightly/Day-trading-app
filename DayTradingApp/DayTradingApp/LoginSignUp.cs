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
using DayTradingApp.Data;
using DayTradingApp.models;

namespace DayTradingApp {


    public partial class LoginSignUp : UserControl
    {

        public string formMode = "empty";
        public event Action<User> LoginSucceeded;

        public LoginSignUp()
        {
            InitializeComponent();
            PassInput_Box.PlaceholderText = "Password";
            emailInput_Box.PlaceholderText = "Email";
            nameInput_Box.PlaceholderText = "Name";

            this.MinimumSize = new Size(758, 854);
            this.MaximumSize = new Size(758, 854);
            this.Size = new Size(758, 854);

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();

        }

        private void login_signup_toggle_Click(object sender, EventArgs e)
        {
            if ((string)login_signup_toggle.Tag != "signup")
            {
                login_signup_toggle.BackgroundImage = Properties.Resources.toggleRight;
                login_signup_toggle.Tag = "signup";
                formMode = "signup";
                nameInput_Box.Visible = true;
            }
            else
            {
                login_signup_toggle.BackgroundImage = Properties.Resources.toggleLeft;
                login_signup_toggle.Tag = "login";
                formMode = "login";
                nameInput_Box.Visible = false;
            }
        }
        public async Task<User> LoginAsync(string email, string password) {
            var supabase = await SupabaseService.GetAsync();

            var session = await supabase.Auth.SignIn(email, password);

            if (session?.User == null)
                throw new Exception("Login failed");

            var authUserId = Guid.Parse(session.User.Id);

            // Fetch app-level user row
            var response = await supabase
                .From<AppUser>()
                .Filter("id", Supabase.Postgrest.Constants.Operator.Equals, authUserId.ToString())
                .Single();

            return new User {
                Id = response.Id.ToString(),
                Username = response.Username,
                Name = response.Username,
                Email = email
            };
        }
        public async Task<User> SignUpAsync(string email, string password, string username) {
            var supabase = await SupabaseService.GetAsync();

            // 1. Supabase Auth signup
            var session = await supabase.Auth.SignUp(
                email,
                password,
                new Supabase.Gotrue.SignUpOptions {
                    Data = new Dictionary<string, object>
                    {
                        { "username", nameInput_Box.Text }
                    }
                }
            );



            if (session?.User == null)
                throw new Exception("Signup failed");

            var authUserId = Guid.Parse(session.User.Id);


            // Return lightweight app user
            return new User {
                Id = authUserId.ToString(),
                Username = username,
                Name = username,
                Email = email
            };
        }


        public async void SubmitBtn_Click(object sender, EventArgs e) {
            try {
                User user;

                if (formMode == "signup") {
                    if (string.IsNullOrWhiteSpace(nameInput_Box.Text))
                    {
                        MessageBox.Show("Username cannot be empty.");
                        return;
                    }
                    user = await SignUpAsync(
                        emailInput_Box.Text,
                        PassInput_Box.Text,
                        nameInput_Box.Text
                    );
                }
                else {
                    user = await LoginAsync(
                        emailInput_Box.Text,
                        PassInput_Box.Text
                    );
                }

                // Persist current user in session holder
                UserSession.Current = user;

                LoginSucceeded?.Invoke(user);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }



        private void LoginSignUp_Load(object sender, EventArgs e)
        {

        }

    }
    public class User {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
    }
}
