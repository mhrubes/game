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
    public partial class Boss : Form
    {
        public Boss()
        {
            InitializeComponent();

            List<string> playerFloor = new List<string>(File.ReadAllLines("floorP.txt"));
            List<string> bossHP = new List<string>(File.ReadAllLines("bossHP.txt"));
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));

            int selected = int.Parse(playerSelect[0]);

            floorBox.Text = playerFloor[selected];
            enemyHPBox.Text = bossHP[selected];

            // MessageBox.Show("Jakmile kliknete na tlačítko 'Začít souboj', Budete muset bojovat");
            // MessageBox.Show("Budete mít 10 vteřin na to, zabít bosse");
        }

        // On Load
        private void Boos_Load(object sender, EventArgs e)
        {
        }

        // Start Button
        private void startBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Fight fight = new Fight();
            fight.Show();
        }

        // Back Button
        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void Boss_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Boss.ModifierKeys == Keys.Alt || Boss.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}