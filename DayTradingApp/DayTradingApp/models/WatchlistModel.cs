using System;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace DayTradingApp.models
{
    [Table("watchlists")]
    public class WatchlistModel : BaseModel
    {
        [PrimaryKey("id", false)]
        public long Id { get; set; }

        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("ticker")]
        public string Ticker { get; set; }

        [Column("added_at")]
        public DateTime? AddedAt { get; set; }
    }
}
