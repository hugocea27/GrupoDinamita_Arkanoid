using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class frmRankingMenu : Form
    {
        public frmRankingMenu()
        {
            InitializeComponent();
            string query = "SELECT * FROM gamerank ORDER BY gamescore DESC;";
            var dt = ConnectionDB.ExecuteQuery(query);
            dgw_ranking.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu window = new frmMainMenu();
            window.Show();
            this.Hide();
        }
    }
}