using DayTradingApp.Components;
using DayTradingApp.Helpers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DayTradingApp
{
    public partial class BaseForm : Form
    {
        protected NavMenu navMenu;

        public BaseForm()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            // --- Reduce flicker ---
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();

            navMenu.NavButtonClicked += NavMenu_NavButtonClicked;

           
            this.FormClosing += BaseForm_FormClosing;
        }

        protected TableLayoutPanel tableLayoutPanel1;
    
    protected virtual void NavMenu_NavButtonClicked(object sender, string destination)
        {
            // Use NavigationHelper to switch forms
            NavigationHelper.Navigate(this, destination);
        }
        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}

