using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class frmGameOver : Form
    {
        public frmGameOver()
        {
            InitializeComponent();
            //se obtiene el puntaje del formulario de juego
            lbl_finalscore.Text = "Tu puntaje: "+ frmGame.score;
            //se actualiza el puntaje llamando al método
            updateScore();
        }

        #region updateScore
        private void updateScore()
        {
            //se selecciona el puntaje del usuario actual
            string query = $"SELECT gamescore FROM gamerank WHERE username = '{frmLogin.actualPlayer}'";
            var dt = ConnectionDB.ExecuteQuery(query);
            var dr = dt.Rows[0];
            var bestScore = Convert.ToInt32(dr[0]);

            //si el puntaje que ha hecho en el juego actual es mejor que el almacenado entonces se va a actualizar
            if (bestScore < frmGame.score)
            {
                string nonQuery = $"UPDATE gamerank SET gamescore ={frmGame.score} WHERE username='{frmLogin.actualPlayer}'";
                ConnectionDB.ExecuteNonQuery(nonQuery);
                lbl_maxscore.Text = "¡NUEVO MEJOR PUNTAJE!";
            }
            //si no, se muestra el puntaje anteriormente almaccenado
            else
            {
                lbl_maxscore.Text = "Mejor puntaje anterior anterior: "+ bestScore;
            }
        }
        #endregion
        
        #region backtoMenu
        private void btm_gotomenu_Click(object sender, EventArgs e)
        {
            frmMainMenu window = new frmMainMenu();
            window.Show();
            this.Hide();
        }
        #endregion
    }
}