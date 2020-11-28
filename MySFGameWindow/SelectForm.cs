using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace MySFGameWindow
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        // Create Game Button
        private void newGameBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewGame newGame = new CreateNewGame();
            newGame.Show();
        }

        // Continue Button
        private void continueGameBTN_Click(object sender, EventArgs e)
        {
            List<string> playerName = new List<string>(File.ReadAllLines("nameP.txt"));
            List<string> playerPassword = new List<string>(File.ReadAllLines("passwordP.txt"));

            if (playerName.Count >= 1 && playerPassword.Count >= 1)
            {
                this.Hide();
                SelectPlayer selectPlayer = new SelectPlayer();
                selectPlayer.Show();
            }
            else MessageBox.Show("V aktuální době není vytvořena žádná hra");
        }

        // End Button
        private void endMenuBTN_Click_1(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
                /*
                Environment.Exit(0);
                */
            }
            catch (Exception)
            {
            }
        }

        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SelectForm.ModifierKeys == Keys.Alt || SelectForm.ModifierKeys == Keys.F4) e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictures(pictureBox2, 476, 388, 81, 3);
            pictures(pictureBox3, 476, 60, -17, 4);
            pictures(pictureBox4, 476, 30, -17, 5);
            pictures(pictureBox5, 476, 220, -17, 6);
        }

        void pictures(PictureBox pic, int end, int xx, int yy, int speed)
        {
            pic.Top += speed;
            if (pic.Location.Y >= end) pic.Location = new Point(x: xx, y: yy);
        }
    }
}