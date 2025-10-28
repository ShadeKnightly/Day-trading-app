using DayTradingApp.Components;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DayTradingApp
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            // Prevent designer from trying to run runtime logic
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            InitializeComponent();

            // Enable double buffering to reduce flicker
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();

            this.DoubleBuffered = true;
        }

    }
}
