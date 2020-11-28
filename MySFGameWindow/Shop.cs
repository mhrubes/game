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
    public partial class Shop : Form
    {
        double price;

        public Shop()
        {
            InitializeComponent();

            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> playerMush = new List<string>(File.ReadAllLines("mushP.txt"));
            List<string> playerPower = new List<string>(File.ReadAllLines("powerP.txt"));
            List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));

            int selected = int.Parse(playerSelect[0]);
            int level = int.Parse(playerLevel[selected]);
            int power = int.Parse(playerPower[selected]);

            price = (power + level) * 100;

            powerLabel.Text = "Vylepšit útok o +1 za: " + price;

            moneyBox.Text = playerMoney[selected];
            coinBox.Text = playerMush[selected];
            powerBox.Text = playerPower[selected];
        }

        // Coin Buy Button
        private void coinBuyBTN_Click(object sender, EventArgs e)
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> playerMush = new List<string>(File.ReadAllLines("mushP.txt"));
            List<string> playerPower = new List<string>(File.ReadAllLines("powerP.txt"));
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));

            int selected = int.Parse(playerSelect[0]);
            double money = double.Parse(playerMoney[selected]);
            int coin = int.Parse(playerMush[selected]);

            if (money >= 10)
            {
                money -= 10;
                coin++;

                playerMoney.RemoveAt(selected);
                playerMoney.Insert(selected, money.ToString());

                playerMush.RemoveAt(selected);
                playerMush.Insert(selected, coin.ToString());

                moneyBox.Text = playerMoney[selected];
                coinBox.Text = playerMush[selected];

                File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
                File.WriteAllLines("mushP.txt", playerMush.ToArray());

                MessageBox.Show("Nákup byl 'ÚSPĚŠNÝ'");
            }
            else MessageBox.Show("Na tento nákup 'NEMÁTE' dostatek prostředků");
        }

        // Coin Sell Button
        private void coinSellBTN_Click(object sender, EventArgs e)
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> playerMush = new List<string>(File.ReadAllLines("mushP.txt"));
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));

            int selected = int.Parse(playerSelect[0]);
            double money = double.Parse(playerMoney[selected]);
            int coin = int.Parse(playerMush[selected]);

            if (coin >= 1)
            {
                money += 5;
                coin--;

                playerMoney.RemoveAt(selected);
                playerMoney.Insert(selected, money.ToString());

                playerMush.RemoveAt(selected);
                playerMush.Insert(selected, coin.ToString());

                moneyBox.Text = playerMoney[selected];
                coinBox.Text = playerMush[selected];

                File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
                File.WriteAllLines("mushP.txt", playerMush.ToArray());

                MessageBox.Show("Prodej byl 'ÚSPĚŠNÝ'");
            }
            else MessageBox.Show("Na tento Prodej 'NEMÁTE' dostatek prostředků");
        }

        // Buy Power Button
        private void powerBTN_Click(object sender, EventArgs e)
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> playerPower = new List<string>(File.ReadAllLines("powerP.txt"));
            List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));

            int selected = int.Parse(playerSelect[0]);
            double money = int.Parse(playerMoney[selected]);
            int power = int.Parse(playerPower[selected]);
            int level = int.Parse(playerLevel[selected]);

            if (money >= price && level >= 5)
            {
                money -= price;
                power++;

                price = (power + level) * 100;

                playerMoney.RemoveAt(selected);
                playerMoney.Insert(selected, money.ToString());

                playerPower.RemoveAt(selected);
                playerPower.Insert(selected, power.ToString());

                moneyBox.Text = playerMoney[selected];
                powerBox.Text = playerPower[selected];
                powerLabel.Text = "Vylepšit útok o +1 za: " + price;

                File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
                File.WriteAllLines("powerP.txt", playerPower.ToArray());

                MessageBox.Show("Nákup byl 'ÚSPĚŠNÝ'");
            }
            else MessageBox.Show("Na tento nákup 'NEMÁTE' dostatek prostředků nebo máte nízký level (Min. level: 5)");
        }

        // Back Button
        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void Shop_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Shop.ModifierKeys == Keys.Alt || Shop.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}