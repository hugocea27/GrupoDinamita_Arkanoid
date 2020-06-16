using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class frmGameOver : Form
    {
        public frmGameOver()
        {
            InitializeComponent();
            lblFinalScore.Text = "Tu puntaje: "+frmGame.score;
        }
        
        private void btmGoToMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu window = new frmMainMenu();
            window.Show();
            this.Hide();
        }

        private void btmRanking_Click(object sender, EventArgs e)
        {
            Ranking window = new Ranking();
            window.Show();
            this.Hide();
        }

        private void btmSaveScore_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}