using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region userValidation
        
        //variable auxiliar para establecer el usuario que está jugando
        public static string actualPlayer;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //se mandan a llamar a todos los usuarios en la base de datos
                string query = $"SELECT username FROM gamerank WHERE username='{txt_name.Text}'";
                var dt = ConnectionDB.ExecuteQuery(query);
                var dr = dt.Rows[0];
                var val = Convert.ToString(dr[0].ToString());

                //se comparan todos los usuarios con el que el usuario ingresa, si coincide con alguno inicia sesión
                if (val == txt_name.Text)
                {
                    MessageBox.Show("Bienvenido " + txt_name.Text);
                    actualPlayer = txt_name.Text;
                    starGame();
                    this.Close();
                }
            }
            //si cuando se está comparando no coincide con ninguno se almacena el nuevo usuario ingresado a la base
            catch(Exception)
            {
                string nonQuery = $"INSERT INTO gamerank(username, gamescore) VALUES ('{txt_name.Text}', 0)";

                ConnectionDB.ExecuteNonQuery(nonQuery);
                MessageBox.Show("Nuevo jugador registrado ... ¡Bienvenido " + txt_name.Text + "!");
                actualPlayer = txt_name.Text;
                starGame();
                this.Close();
            }
        }
        #endregion
        
        #region startGame
        private void starGame()
        {
            frmGame window = new frmGame();
            window.Show();
        }
        #endregion
    }
}