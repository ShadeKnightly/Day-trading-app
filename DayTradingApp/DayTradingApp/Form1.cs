using System;
using System.Windows.Forms;

namespace DayTradingApp
{
    public partial class Form1 : Form
    {

        public static Form1 Form1Instance;
        public Form1()
        {
            InitializeComponent();
        }

    

        private void signUpLink_Click(object sender, EventArgs e)
        {
            login_signup_toggle.Image = Properties.Resources.toggleRight; 
        }

        private void login_signup_toggle_Click(object sender, EventArgs e)
        {
            //ToDo:
            //If signUpLink_Click is clicked, use inputs to create account
            //Notify the user that the account was created successfully
            //Use inputs to login to account and open the home screen, or get the user to input credentials again to login


            //Hide this form and open the home screen
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
            //Close the form
            this.Close();
        }
    }
}
