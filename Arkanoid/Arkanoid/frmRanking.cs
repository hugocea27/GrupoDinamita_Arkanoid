using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class frmRanking : Form
    {
        public frmRanking()
        {
            InitializeComponent();
        }

        private void frmRanking_Load(object sender, EventArgs e)
        {
            
        }

        private void btmvolver_Click(object sender, EventArgs e)
        {
            frmGameOver window = new frmGameOver();
            window.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = ConnectionDB.ExecuteQuery("SELECT * FROM gamerank ORDER BY gamescore DESC;");
            dataGridView1.DataSource = dt;
        }
    }
}