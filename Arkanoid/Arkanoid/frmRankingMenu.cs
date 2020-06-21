using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class frmRankingMenu : Form
    {
        public frmRankingMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu window = new frmMainMenu();
            window.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM gamerank ORDER BY gamescore DESC;";
            var dt = ConnectionDB.ExecuteQuery(query);
            dataGridView1.DataSource = dt;
        }
    }
}