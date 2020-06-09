using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class frmGame : Form
    {
        bool goToLeft, goToRight;
        int speed = 10, ballX = 5, ballY = 5, score = 0, life=0;
        
        public frmGame()
        {
            InitializeComponent();
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && player.Left > 0) { goToLeft = true; }
            if (e.KeyCode == Keys.Right && player.Left + player.Width < 989) { goToRight = true; }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { goToLeft = false; }
            if (e.KeyCode == Keys.Right) { goToRight = false; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //moviemiento del jugador
            if (goToLeft == true) { player.Left -= speed; } //ir izquierda
            if (goToRight == true) { player.Left += speed; } //ir derecha
        }
    }
}