using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using DayTradingApp.Data;

//created sample data with chatgpt


namespace DayTradingApp.Data
{

    public static class DatabaseHelper
    {
        //=== A. Store database in AppData directory for persistent storage===
        private static string appFolder = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "DayTradingApp"
       );
        //
        //private static readonly string dbFilePath = Path.Combine(appFolder, "trading.db");


        // === B. Store database inside of /bin/Data/ folder for local testing ===
        private static readonly string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
        private static readonly string dbFilePath = Path.Combine(dataFolderPath, "trading.db");

        // connection string (Microsoft.Data.Sqlite uses Data Source)
        private static readonly string connectionString = $"Data Source={dbFilePath}";

        public static void InitializeDatabase()
        {
            // Ensure the folder exists 
            string folder = Path.GetDirectoryName(dbFilePath);
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            // Create DB file if it doesn’t exist
            if (!File.Exists(dbFilePath))
            {
                using (var fs = File.Create(dbFilePath)) { }
            }

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();

                //create Stocks table with columns for each property
                string createStocksTable = @"
                    CREATE TABLE IF NOT EXISTS Stocks (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Symbol TEXT NOT NULL,
                        Name TEXT,
                        Price REAL, 
                        Change REAL, 
                        PercentChange REAL, 
                        Volume INTEGER, 
                        Sector TEXT 
                    );";
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = createStocksTable;
                    cmd.ExecuteNonQuery();
                }

                // Create Users table
                string createUsersTable = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Email TEXT
                    );";
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = createUsersTable;
                    cmd.ExecuteNonQuery();
                }

                // Create Watchlists table
                string createWatchlistTable = @"
                    CREATE TABLE IF NOT EXISTS Watchlists (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserId INTEGER NOT NULL,
                        StockId INTEGER NOT NULL,
                        FOREIGN KEY (UserId) REFERENCES Users(Id),
                        FOREIGN KEY (StockId) REFERENCES Stocks(Id)
                    );";
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = createWatchlistTable;
                    cmd.ExecuteNonQuery();
                }


                //Insert Sample data if the table is empty
                string checkQuery = "SELECT COUNT(*) FROM Stocks;";
                using (var checkCmd = conn.CreateCommand())
                {
                    checkCmd.CommandText = checkQuery;
                    var count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count == 0)
                    {
                        SeedStockData(conn); //helper function to insert sample stock data
                        SeedUserData(conn);
                    }
                }
            }

        }

        private static void SeedStockData(SqliteConnection conn)
        {

            //stock sample data 
            var stocks = new List<(string Symbol, string Name, decimal Price, decimal Change, decimal PercentChange, long Volume, string Sector)>
            {
                ("AAPL", "Apple Inc.", 176.50m, -1.25m, -0.70m, 53200000, "Technology"),
                ("MSFT", "Microsoft Corp.", 325.10m, 2.30m, 0.71m, 34000000, "Technology"),
                ("GOOGL", "Alphabet Inc.", 142.15m, 0.75m, 0.53m, 27000000, "Technology"),
                ("AMZN", "Amazon.com Inc.", 129.70m, -0.45m, -0.35m, 45000000, "Consumer"),
                ("TSLA", "Tesla Inc.", 244.30m, 3.60m, 1.49m, 67000000, "Automotive"),
                ("NVDA", "NVIDIA Corp.", 465.90m, 5.20m, 1.13m, 42000000, "Semiconductors"),
                ("JPM", "JPMorgan Chase & Co.", 148.75m, -0.65m, -0.43m, 12000000, "Financial"),
                ("DIS", "Walt Disney Co.", 89.40m, 0.40m, 0.45m, 9800000, "Entertainment")
            };

            foreach (var s in stocks)
            {
                string insertQuery = @"
                    INSERT INTO Stocks (Symbol, Name, Price, Change, PercentChange, Volume, Sector)
                    VALUES (@Symbol, @Name, @Price, @Change, @PercentChange, @Volume, @Sector);";
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = insertQuery;
                    cmd.Parameters.AddWithValue("@Symbol", s.Symbol);
                    cmd.Parameters.AddWithValue("@Name", s.Name);
                    cmd.Parameters.AddWithValue("@Price", s.Price);
                    cmd.Parameters.AddWithValue("@Change", s.Change);
                    cmd.Parameters.AddWithValue("@PercentChange", s.PercentChange);
                    cmd.Parameters.AddWithValue("@Volume", s.Volume);
                    cmd.Parameters.AddWithValue("@Sector", s.Sector);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private static void SeedUserData(SqliteConnection conn)
        {
            // Sample users
            var users = new List<(string Username, string Password, string Email)>
            {
                ("alice", "password123", "alice@example.com"),
                ("bob", "securepass", "bob@example.com"),
                ("charlie", "trader2025", "charlie@example.com")
            };

            foreach (var u in users)
            {
                string insertQuery = @"
                    INSERT INTO Users (Username, Password, Email)
                    VALUES (@Username, @Password, @Email);";
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = insertQuery;
                    cmd.Parameters.AddWithValue("@Username", u.Username);
                    cmd.Parameters.AddWithValue("@Password", u.Password);
                    cmd.Parameters.AddWithValue("@Email", u.Email);
                    cmd.ExecuteNonQuery();
                }
             }

            // Sample watchlists
            var watchlists = new List<(int UserId, int StockId)>
            {
                (1, 1), // Alice watches Apple
                (1, 2), // Alice watches Microsoft
                (2, 3), // Bob watches Google
                (2, 5), // Bob watches Tesla
                (3, 4), // Charlie watches Amazon
                (3, 6), // Charlie watches Nvidia
            };

                foreach (var w in watchlists)
                {
                    string insertQuery = @"
                INSERT INTO Watchlists (UserId, StockId)
                VALUES (@UserId, @StockId);";
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = insertQuery;
                    cmd.Parameters.AddWithValue("@UserId", w.UserId);
                    cmd.Parameters.AddWithValue("@StockId", w.StockId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Stocks> GetAllStocks()
        {
            var stocks = new List<Stocks>();

            if (!File.Exists(dbFilePath))
                InitializeDatabase();

            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Stocks;";
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = query;
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                stocks.Add(new Stocks
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Symbol = reader["Symbol"].ToString(),
                                    Name = reader["Name"].ToString(),
                                    Price = Convert.ToDecimal(reader["Price"]),
                                    Change = Convert.ToDecimal(reader["Change"]),
                                    PercentChange = Convert.ToDecimal(reader["PercentChange"]),
                                    Volume = Convert.ToInt64(reader["Volume"]),
                                    Sector = reader["Sector"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return stocks;
        }
    }
}

    
