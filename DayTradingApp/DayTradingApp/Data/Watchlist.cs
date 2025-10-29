using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Watchlist
{
    public int WatchlistId { get; set; }
    public int UserId { get; set; }
    public List<string> Items { get; set; } = new List<string>();
    public void AddItem(string item)
    {
        if (!Items.Contains(item))
            Items.Add(item);
    }
    public void RemoveItem(string item)
    {
        Items.Remove(item);
    }
}