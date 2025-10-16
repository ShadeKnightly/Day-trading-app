using System;
using System.Windows.Forms;

namespace DayTradingApp
{
    public partial class Form1 : Form
    {

        public static Form1 Form1Instance;
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
            //Close the form
            this.Close();
        }
    }
}
