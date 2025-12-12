using DayTradingApp;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayTradingApp
{
    public partial class Form1 : Form
    {

        private LoginSignUp _loginView;
        private HomeView _homeView;
        private MarketReport _marketReport = new MarketReport();

        public Form1()
        {
            InitializeComponent();
            DotNetEnv.Env.Load();

            // Double buffering 
            typeof(Panel).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance)
            .SetValue(mainFormDisplay, true, null);

            _loginView = new LoginSignUp();
            _loginView.LoginSucceeded += OnLoginSucceeded;
            ShowView(_loginView);

            
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            // Await the load so exceptions can be observed and the UI stays responsive.
            try
            {
                await CheckForMarketData();
            }
            catch (Exception ex)
            {
                // Log the error; do not crash the UI thread.
                System.Diagnostics.Debug.WriteLine($"Failed to load market data: {ex}");
            }
        }
        private async Task CheckForMarketData() {
            await _marketReport.LoadMarketDataAsync();
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

        private void mainFormDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


    




