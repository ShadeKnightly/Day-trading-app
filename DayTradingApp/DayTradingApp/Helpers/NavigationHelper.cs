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
    public static class NavigationHelper {

        public static void LoadView(Control host, UserControl newView)
        {
            
            host.SuspendLayout();
            host.Visible = false;
            host.Controls.Clear();
            newView.Dock = DockStyle.Fill;
            host.Controls.Add(newView);
            host.ResumeLayout(true);
            host.Visible = true;
        }

        /*
         public static void LoadView(Control host, UserControl newView) {
            host.Controls.Clear();
            newView.Dock = DockStyle.Fill;
            host.Controls.Add(newView);
        }
        */
    }
}
