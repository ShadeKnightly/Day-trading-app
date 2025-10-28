using DayTradingApp;
using DayTradingApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayTradingApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize reusable forms
            NavigationHelper.Initialize();

            // Start on the login form (Form1) 
            Application.Run(new Form1());
        }


    }
}

