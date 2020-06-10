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
    }
}