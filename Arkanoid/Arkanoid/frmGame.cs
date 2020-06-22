using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class frmGame : Form
    {
        bool goToLeft, goToRight;
        int speed = 15, ballX = 10, ballY = 10, life=3;
        public static int score;

        public frmGame()
        {
            InitializeComponent();
            score = 0;
        }
        
        //evento de apretar tecla
        private void keyDown(object sender, KeyEventArgs e)
        {
            //Si se está presionando la tecla y el jugador no colisiona con la pared izquierda
            if (e.KeyCode == Keys.Left && player.Bounds.IntersectsWith(picLeftWall.Bounds) == false)
            {
                goToLeft = true;
            }
            //Si se está presionando la tecla y el jugador no colisiona con la pared derecha
            if (e.KeyCode == Keys.Right && player.Bounds.IntersectsWith(picRightWall.Bounds) == false)
            {
                goToRight = true;
            }
        } 

        //evento de soltar tecla
        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { goToLeft = false; }
            if (e.KeyCode == Keys.Right) { goToRight = false; }
        } 

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Vidas y puntaje
            lblScore.Text = "PUNTAJE: " + score;
            lblLifes.Text = "VIDA: " + life;
            
            //moviemiento del jugador
            if (goToLeft) { player.Left -= speed; } //ir izquierda
            if (goToRight) { player.Left += speed; } //ir derecha
            
            //moviemiento bola
            ball.Left += ballX;
            ball.Top += ballY;

            //Colisiones del jugador
            if (player.Bounds.IntersectsWith(ball.Bounds)) { ballY = -ballY; } //con la bola
            if (player.Bounds.IntersectsWith(picLeftWall.Bounds)) { goToLeft = false; } //con pared izquierda
            else if (player.Bounds.IntersectsWith(picRightWall.Bounds)) { goToRight = false; } //con pared derecha

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

                //Colisión con bloque básico (necesita 1 golpe)
                if (x is PictureBox && x.Tag == "basicblock")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ballY = -ballY;
                        score++;
                    }
                }
                
                //Colisión con bloque roto (necesita 2 golpes)
                if (x is PictureBox && x.Tag == "brokenblock")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        ballY = -ballY;
                        x.Tag = "basicblock"; 
                        x.BackgroundImage = Properties.Resources.Tile___red;
                    }
                }
                
                //Colisión con bloque blindado (necesita 3 golpes)
                if (x is PictureBox && x.Tag == "blindedblock")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        ballY = -ballY;
                        x.Tag = "brokenblock"; 
                        x.BackgroundImage = Properties.Resources.Tile___blinded_broken;
                    }
                }
                
                //Si la bola toca con el fondo 
                if (x is PictureBox && x.Tag == "downWall")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (life > 0) //Si tiene vidas
                        {
                            lostLife();
                        }
                        else //Si no le quedan vidas (Gameover)
                        {
                            gameover();
                        }
                    }
                }
                
                //si el jugador destruye todos los bloques
                if (score == 110)
                {
                    gameover();
                }
            }
        }

        private void gameover()
        {
            timer1.Stop();
            frmGameOver window = new frmGameOver();
            window.Show();
            this.Hide();
        }

        private void lostLife()
        {
            goToLeft = false; goToRight = false;
            timer1.Stop();
            MessageBox.Show("Perdiste 1 vida");
            life--;
            ball.Location = new Point(player.Location.X + 30, player.Location.Y - 50);
            timer1.Start();
        }
    }
}