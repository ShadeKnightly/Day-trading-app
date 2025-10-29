using DayTradingApp;
using DayTradingApp.Data;
using DayTradingApp.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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

            DatabaseHelper.InitializeDatabase();
            NavigationHelper.Initialize();

            //verify data loads(remove later)
            var stocks = DatabaseHelper.GetAllStocks();
            Console.WriteLine($"Loaded {stocks.Count} sample stocks.");

            // Start on the login form (Form1) 
            Application.Run(new Form1());
        }
    }
}

