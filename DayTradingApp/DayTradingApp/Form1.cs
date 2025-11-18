using DayTradingApp;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;

namespace DayTradingApp
{
    public partial class Form1 : Form
    {

        private LoginSignUp _loginView;
        private HomeView _homeView;

        public Form1()
        {
            InitializeComponent();

            // Double buffering 
            typeof(Panel).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance)
            .SetValue(mainFormDisplay, true, null);

            _loginView = new LoginSignUp();
            _loginView.LoginSucceeded += OnLoginSucceeded;
            ShowView(_loginView);

        }
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void OnLoginSucceeded(User userData) {
            _homeView = new HomeView();
            ShowView(_homeView);
        }

        private void ShowView(UserControl view)
        {
            mainFormDisplay.SuspendLayout();
            mainFormDisplay.Visible = false;  

            mainFormDisplay.Controls.Clear();

            view.Dock = DockStyle.Fill;  
            mainFormDisplay.Controls.Add(view);

            mainFormDisplay.ResumeLayout(true);
            mainFormDisplay.Visible = true; 
        }

    }
}


    
    

