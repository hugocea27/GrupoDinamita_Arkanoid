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

            if (frmGame.score == 110)
            {
                lbl_maxscore.Text = "¡PUNTAJE MÁXIMO!";
            }
        }

        private void btmRanking_Click(object sender, EventArgs e)
        {
            frmRankingMenu window = new frmRankingMenu();
            window.Show();
            this.Hide();
        }

        private void btmSaveScore_Click(object sender, EventArgs e)
        {
            if (txt_nickname.Text == "")
            {
                MessageBox.Show("Debes ingresar un usuario.");
            }
            else
            {
                try
                {
                    string nonQuery = "INSERT INTO gamerank (username, gamescore) VALUES (" +
                                      $"'{txt_nickname.Text}', " +
                                      $"{frmGame.score})";

                    ConnectionDB.ExecuteNonQuery(nonQuery);
                    MessageBox.Show("Datos guardados exitosamente.");
                    frmMainMenu menu = new frmMainMenu();
                    menu.Show();
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ese nombre de usuario ya está en uso.");
                }
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