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

        public static string actualPlayer;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT username FROM gamerank WHERE username='{txt_name.Text}'";
                var dt = ConnectionDB.ExecuteQuery(query);
                var dr = dt.Rows[0];
                var val = Convert.ToString(dr[0].ToString());

                if (val == txt_name.Text)
                {
                    MessageBox.Show("Bienvenido " + txt_name.Text);
                    actualPlayer = txt_name.Text;
                    starGame();
                }
            }
            
            catch(Exception)
            {
                string nonQuery = $"INSERT INTO gamerank(username, gamescore) VALUES ('{txt_name.Text}', 0)";

                ConnectionDB.ExecuteNonQuery(nonQuery);
                MessageBox.Show("Nuevo jugador registrado ... ¡Bienvenido " + txt_name.Text + "!");
                actualPlayer = txt_name.Text;
                starGame();
            }
        }

        private void starGame()
        {
            frmGame window = new frmGame();
            window.Show();
            this.Close();
        }
    }
}