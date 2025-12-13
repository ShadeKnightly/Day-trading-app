using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;

namespace DayTradingApp.models {
    
    [Table("users")]
    public class AppUser : BaseModel {
        [PrimaryKey("id", false)]
        public Guid Id { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("balance")]
        public decimal? Balance { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
