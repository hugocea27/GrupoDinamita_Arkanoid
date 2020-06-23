using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        #region buttonPlay
        private void btmPlay_Click(object sender, EventArgs e)
        {
            //se cambia al formulario de incio de sesión
            frmLogin window = new frmLogin();
            window.Show();
            this.Hide();
        }
        #endregion

        #region showRanking
        private void button2_Click(object sender, EventArgs e)
        {
            //se cambia al formulario de ranking
            frmRankingMenu window = new frmRankingMenu();
            window.Show();
            this.Hide();
        }
        #endregion

        #region exitButton
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo...\n\n" +
                            "Esperamos que vuelvas pronto.");
            this.Close();
            Application.Exit();
        }
        #endregion
    }
}