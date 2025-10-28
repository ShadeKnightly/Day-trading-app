/* Navigation helper 
// Switches between main forms via the navMenu
// Reuses instances of each form instead of creating a new one every time
// - Prevents UI flicker and reduce load time
*/

using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayTradingApp.Helpers
{
    public static class NavigationHelper
    {
        private static HomeForm homeForm;
        private static WatchlistForm watchlistForm;
        private static AllStocksForm allStocksForm;

        public static void Initialize()
        {
            homeForm = new HomeForm();
            watchlistForm = new WatchlistForm();
            allStocksForm = new AllStocksForm();
        }

        public static async void Navigate(Form currentForm, string destination)
        {
            Form nextForm = null;

            switch (destination)
            {
                case "Home":
                    nextForm = new HomeForm();
                    break;
                case "Watchlist":
                    nextForm = new WatchlistForm();
                    break;
                case "AllStocks":
                    nextForm = new AllStocksForm();
                    break;
            }

            if (nextForm != null)
            {
                currentForm.Hide();
                await Task.Delay(50); // small buffer to prevent redraw overlap
                nextForm.Show();
            }
        }
       
    }
}
