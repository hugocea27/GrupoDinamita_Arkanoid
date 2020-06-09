using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class frmGame : Form
    {
        bool goToLeft, goToRight;
        int speed = 15, ballX = 10, ballY = 10, score = 0, life=3;

        public frmGame()
        {
            InitializeComponent();
        }
        //evento de apretar tecla
        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { goToLeft = true; }
            if (e.KeyCode == Keys.Right) { goToRight = true; }
        } 

        //evento de soltar tecla
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
            
            //moviemiento bola
            ball.Left += ballX;
            ball.Top += ballY;
            
            //Vidas y puntaje
            lblScore.Text = "PUNTAJE: " + score;
            lblLifes.Text = "VIDA: " + life;
            
            //Colisiones del jugador
            if (player.Bounds.IntersectsWith(ball.Bounds)) { ballY = -ballY; } //con la bola 

            //rebotes de la bola
            foreach (Control x in this.Controls)
            {
                //Rebotes con las paredes
                if (x is PictureBox && x.Tag == "wall")
                {
                    if(ball.Bounds.IntersectsWith(x.Bounds)){ ballX = -ballX; }
                }
                
                //Rebotes con el techo
                if (x is PictureBox && x.Tag == "topwall")
                {
                    if(ball.Bounds.IntersectsWith(x.Bounds)) { ballY = -ballY; }
                }
                
                //Colisión con bloque blanco
                if (x is PictureBox && x.Tag == "whiteblock")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ballY = -ballY;
                        score++;
                    }
                }
                
                //Colisión con bloque rosa
                if (x is PictureBox && x.Tag == "pinkblock")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        ballY = -ballY;
                        x.Tag = "whiteblock";
                        x.BackColor = Color.White;
                    }
                }
                
                //Colisión con bloque rojo
                if (x is PictureBox && x.Tag == "redblock")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        ballY = -ballY;
                        x.Tag = "pinkblock";
                        x.BackColor = Color.Pink;
                    }
                }
                
                //Gameover
                if (x is PictureBox && x.Tag == "downWall")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (life > 0)
                        {
                            lostLife();
                        }
                        else
                        {
                            gameover();
                        }
                    }
                }
            }
        }
        
        private void gameover()
        {
            timer1.Stop();
            MessageBox.Show("Fin del juego");
        }

        private void lostLife()
        {
            goToLeft = false;
            goToRight = false;
            timer1.Stop();
            MessageBox.Show("Perdiste");
            life--;
            ball.Location = new Point(player.Location.X + 30, player.Location.Y - 50);
            timer1.Start();
        }
    }
}