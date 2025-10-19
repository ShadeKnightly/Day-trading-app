using DayTradingApp;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace DayTradingApp
{
    public partial class Form1 : Form
    {

        public static Form1 Form1Instance;
        public string formMode = "empty";

        public Form1()
        {
            InitializeComponent();

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


        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            //change this to Submit form Click event

            //if input boxes are empty or invalid
            //Notify user to fill in all fields
            //if (formMode == "empty")
            //{
            //    MessageBox.Show("Please fil in all fields.");
            //    return;
            //}

            //if in login mode
            //if (formMode == "login")
            //{
            //****TODO****//
            //-Validate inputs
            //-Check credentials against database
            //-If credentials are invalid: give the user an error message


            //If credentials are valid:
            //Hide this form and open the home screen
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
                
            this.Close();
        }


            //else if (formMode == "signup")
            //{
                //****TODO****//
                //if in signup mode:
                //-Validate inputs
                //-Use inputs to create account
                //-Notify the user that the account was created successfully
                //-Clear Input boxes
                //-Switch to login mode and Get the user to input credentials again to login
                //(unless we want to auto-login after signup)
            //}

        }
    }


    
    

