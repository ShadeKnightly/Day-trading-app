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
        private void ShowView(UserControl view) {
            this.mainFormDisplay.Controls.Clear();
            view.Dock = DockStyle.Fill;

            this.mainFormDisplay.Controls.Add(view);
            // Center the view in the display panel
            view.Left = (mainFormDisplay.Width - view.Width) / 2;
            view.Top = (mainFormDisplay.Height - view.Height) / 2;
        }

    }
}


    
    

