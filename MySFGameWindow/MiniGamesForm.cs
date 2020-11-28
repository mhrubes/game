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
    public partial class MiniGamesForm : Form
    {
        public MiniGamesForm() => InitializeComponent();

        private void jackpotBTN_Click(object sender, EventArgs e)
        {
            List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));

            int selected = int.Parse(playerSelect[0]);
            int level = int.Parse(playerLevel[selected]);

            if (level >= 3)
            {
                this.Hide();
                Jackpot jackpot = new Jackpot();
                jackpot.Show();
            }
            else MessageBox.Show("Musíte mít nejméně level '3'");
        }

        private void blackJackBTN_Click(object sender, EventArgs e)
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            if (int.Parse(playerMoney[selected]) >= 100)
            {
                this.Close();
                BlackJackGameForm blackJack = new BlackJackGameForm();
                blackJack.Show();
            }
            else MessageBox.Show($"Abyste mohli začít hrát, potřebujete minimálně 100 zlaťáků. \nNyní máte: {playerMoney[selected]}");
        }

        private void rockBTN_Click(object sender, EventArgs e)
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            if (int.Parse(playerMoney[selected]) >= 100)
            {
                this.Close();
                RockScissorsPaperForm rock = new RockScissorsPaperForm();
                rock.Show();
            }
            else MessageBox.Show($"Abyste mohli začít hrát, potřebujete minimálně 100 zlaťáků. \nNyní máte: {playerMoney[selected]}");
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void MiniGamesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MiniGamesForm.ModifierKeys == Keys.Alt || MiniGamesForm.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}