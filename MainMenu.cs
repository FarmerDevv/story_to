using System;
using System.Drawing;
using System.Windows.Forms;

namespace SeninBorcun
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ana menüyü gizle
            Form1 gameForm = new Form1(); // Oyunu başlat
            gameForm.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Oyundan çık
        }

        // Hover efekti: Butonun rengi değişsin
        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.DarkGray;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.Gray;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.DarkGray;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Gray;
        }
    }
}
