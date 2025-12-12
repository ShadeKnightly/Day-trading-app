using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("stocks")]
public class StockModel : BaseModel {
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("ticker")]
    public string Ticker { get; set; }

    [Column("companyName")]
    public string CompanyName { get; set; }

    [Column("exchange")]
    public string Exchange { get; set; }

    [Column("type")]
    public string Type { get; set; }

    [Column("currency")]
    public string Currency { get; set; }

    [Column("is_delisted")]
    public bool IsDelisted { get; set; }
}

