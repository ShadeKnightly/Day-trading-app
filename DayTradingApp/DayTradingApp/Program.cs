using DayTradingApp;
using DayTradingApp.Data;
using DayTradingApp.Helpers;
using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetEnv;

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
            // Load environment variables from .env before anything else that may read them.
            // This ensures configuration and secrets are available to all components from the very start of the application.
            try
            {
                DotNetEnv.Env.Load();
            }
            catch (Exception ex)
            {
                // If loading .env fails, continue; environment may be set in other ways.
                System.Diagnostics.Debug.WriteLine($"DotNetEnv load failed: {ex}");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseHelper.InitializeDatabase();
            //NavigationHelper.Initialize();

            //verify data loads(remove later)
            var stocks = DatabaseHelper.GetAllStocks();
            Console.WriteLine($"Loaded {stocks.Count} sample stocks.");

            // Start on the login form (Form1) 
            Application.Run(new Form1());
        }
    }
}

