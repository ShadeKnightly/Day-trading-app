using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DayTradingApp.Data
{
        public class Stocks
        {
            public int Id { get; set; }
            public string Symbol { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal Change { get; set; }
            public decimal PercentChange { get; set; }
            public long Volume { get; set; }
            public string Sector { get; set; }
        }
       
}
