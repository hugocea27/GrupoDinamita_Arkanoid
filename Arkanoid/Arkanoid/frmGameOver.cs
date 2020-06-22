using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class frmGameOver : Form
    {
        public frmGameOver()
        {
            InitializeComponent();
            lblFinalScore.Text = "Tu puntaje: "+ frmGame.score;

            if (frmGame.score == 110)
            {
                lblMaxScore.Text = "¡PUNTAJE MÁXIMO!";
            }
        }

        private void btmRanking_Click(object sender, EventArgs e)
        {
            frmRanking window = new frmRanking();
            window.Show();
            this.Hide();
        }

        private void btmSaveScore_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debes ingresar un usuario.");
            }
            else
            {
                try
                {
                    string nonQuery = "INSERT INTO gamerank (username, gamescore) VALUES (" +
                                      $"'{textBox1.Text}', " +
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
    }
}