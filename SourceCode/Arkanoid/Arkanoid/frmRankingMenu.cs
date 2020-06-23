using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class frmRankingMenu : Form
    {
        public frmRankingMenu()
        {
            InitializeComponent();
            //consulta para ordenar a los usuarios en forma descendente de acuerdo a sus puntajes
            string query = "SELECT * FROM gamerank ORDER BY gamescore DESC;";
            //asignando los datos al dataGrid
            var dt = ConnectionDB.ExecuteQuery(query);
            dgw_ranking.DataSource = dt;
        }

        #region backtoMenu
        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu window = new frmMainMenu();
            window.Show();
            this.Hide();
        }
        #endregion
    }
}