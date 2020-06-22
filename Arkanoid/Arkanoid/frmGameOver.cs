using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class frmGameOver : Form
    {
        public frmGameOver()
        {
            InitializeComponent();
            lbl_finalscore.Text = "Tu puntaje: "+ frmGame.score;
            updateScore();
        }

        private void updateScore()
        {
            string query = $"select gamescore from gamerank where username = '{frmLogin.actualPlayer}'";
            var dt = ConnectionDB.ExecuteQuery(query);
            var dr = dt.Rows[0];
            var bestScore = Convert.ToInt32(dr[0]);

            if (bestScore < frmGame.score)
            {
                string nonQuery = $"UPDATE gamerank SET gamescore ={frmGame.score} WHERE username='{frmLogin.actualPlayer}'";
                ConnectionDB.ExecuteNonQuery(nonQuery);
                lbl_maxscore.Text = "¡NUEVO MEJOR PUNTAJE!";
            }

            else
            {
                lbl_maxscore.Text = "Mejor puntaje anterior anterior: "+ bestScore;
            }
        }
        
        private void btm_gotomenu_Click(object sender, EventArgs e)
        {
            frmMainMenu window = new frmMainMenu();
            window.Show();
            this.Hide();
        }
    }
}