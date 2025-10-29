using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTradingApp.Data
{
   
    public class Users
        {
            public string Name { get; set; }
            public int UserId { get; set; }
            public string Password { get; set; }

            public Watchlist UserWatchlist { get; set; }
    }
}
