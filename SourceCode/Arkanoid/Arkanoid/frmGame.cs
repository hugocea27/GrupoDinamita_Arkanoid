using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class frmGame : Form
    {
        #region atributes
        bool goToLeft, goToRight;
        int speed = 15, ballX = 10, ballY = 10, life=3;
        public static int score;
        #endregion

        public frmGame()
        {
            InitializeComponent();
            //inicializando la variable de puntaje
            score = 0;
        }
        
        #region presskeyEvent
        private void keyDown(object sender, KeyEventArgs e)
        {
            //Si se está presionando la tecla y el jugador no colisiona con la pared izquierda
            if (e.KeyCode == Keys.Left && btm_player.Bounds.IntersectsWith(pic_leftwall.Bounds) == false)
            {
                goToLeft = true;
            }
            //Si se está presionando la tecla y el jugador no colisiona con la pared derecha
            if (e.KeyCode == Keys.Right && btm_player.Bounds.IntersectsWith(pic_rightwall.Bounds) == false)
            {
                goToRight = true;
            }
        } 
        #endregion

        #region unpresskeyEvent
        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { goToLeft = false; }
            if (e.KeyCode == Keys.Right) { goToRight = false; }
        } 
        #endregion

        #region gameExecute
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Vidas y puntaje
            lbl_score.Text = "PUNTAJE: " + score;
            lbl_life.Text = "VIDA: " + life;
            
            //moviemiento del jugador
            if (goToLeft) { btm_player.Left -= speed; } //ir izquierda
            if (goToRight) { btm_player.Left += speed; } //ir derecha
            
            //moviemiento bola
            pic_ball.Left += ballX;
            pic_ball.Top += ballY;

            //Colisiones del jugador
            if (btm_player.Bounds.IntersectsWith(pic_ball.Bounds)) { ballY = -ballY; } //con la bola
            if (btm_player.Bounds.IntersectsWith(pic_leftwall.Bounds)) { goToLeft = false; } //con pared izquierda
            else if (btm_player.Bounds.IntersectsWith(pic_rightwall.Bounds)) { goToRight = false; } //con pared derecha

            //rebotes de la bola
            foreach (Control x in this.Controls)
            {
                //Rebotes con las paredes
                if (x is PictureBox && x.Tag == "wall")
                {
                    if(pic_ball.Bounds.IntersectsWith(x.Bounds)){ ballX = -ballX; }
                }
                
                //Rebotes con el techo
                if (x is PictureBox && x.Tag == "topwall")
                {
                    if(pic_ball.Bounds.IntersectsWith(x.Bounds)) { ballY = -ballY; }
                }

                //Colisión con bloque básico (necesita 1 golpe)
                if (x is PictureBox && x.Tag == "basicblock")
                {
                    if (pic_ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ballY = -ballY;
                        score++;
                    }
                }
                
                //Colisión con bloque roto (necesita 2 golpes)
                if (x is PictureBox && x.Tag == "brokenblock")
                {
                    if (pic_ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        ballY = -ballY;
                        x.Tag = "basicblock"; 
                        x.BackgroundImage = Properties.Resources.Tile___red;
                    }
                }
                
                //Colisión con bloque blindado (necesita 3 golpes)
                if (x is PictureBox && x.Tag == "blindedblock")
                {
                    if (pic_ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        ballY = -ballY;
                        x.Tag = "brokenblock"; 
                        x.BackgroundImage = Properties.Resources.Tile___blinded_broken;
                    }
                }
                
                //Si la bola toca con el fondo 
                if (x is PictureBox && x.Tag == "downWall")
                {
                    if (pic_ball.Bounds.IntersectsWith(x.Bounds))
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
        #endregion

        #region gameOver
        private void gameover()
        {
            timer1.Stop();
            frmGameOver window = new frmGameOver();
            window.Show();
            this.Hide();
        }
        #endregion

        #region lostLife
        private void lostLife()
        {
            goToLeft = false; goToRight = false;
            timer1.Stop();
            MessageBox.Show("Perdiste 1 vida");
            life--;
            pic_ball.Location = new Point(btm_player.Location.X + 30, btm_player.Location.Y - 50);
            timer1.Start();
        }
        #endregion
    }
}