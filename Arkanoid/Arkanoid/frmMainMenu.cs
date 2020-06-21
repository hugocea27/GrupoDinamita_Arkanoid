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

        private void btmPlay_Click(object sender, EventArgs e)
        {
            frmGame window = new frmGame();
            window.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRankingMenu window = new frmRankingMenu();
            window.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo...\n\n" +
                            "Esperamos que vuelvas pronto.");
            this.Close();
            Application.Exit();
        }
    }
}