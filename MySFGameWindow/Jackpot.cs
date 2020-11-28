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
    public partial class Jackpot : Form
    {
        int coin;

        int money;
        Random rndMoney = new Random();

        int number;
        int timer = 5;

        Random rndNumber = new Random();
        int randomNumber;

        int resultNumber;

        public Jackpot()
        {
            InitializeComponent();

            List<string> playerMush = new List<string>(File.ReadAllLines("mushP.txt"));
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));

            int selected = int.Parse(playerSelect[0]);
            coin = int.Parse(playerMush[selected]);

            coinBox.Text = coin.ToString();

            timer1.Stop();
            startBTN.Hide();
            randomNumberBox.Hide();
        }

        // User Number Box
        private void userNumberBox_TextChanged(object sender, EventArgs e) => userNumberBox.MaxLength = 2;

        // Key Press
        private void userNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != '.') errorStringMethod(e);
            else if (ch == '.') errorStringMethod(e);
        }

        void errorStringMethod(KeyPressEventArgs e)
        {
            MessageBox.Show("Musíte zadat čísla");
            userNumberBox.Clear();
            e.Handled = true;
        }

        // Start Game Button
        private void startBTN_Click(object sender, EventArgs e)
        {
            shopBTN.Hide();
            backBTN.Hide();
            startBTN.Hide();

            timer1.Start();
        }

        // Tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));

            int selected = int.Parse(playerSelect[0]);
            int level = int.Parse(playerLevel[selected]);
            int actuallMoney = int.Parse(playerMoney[selected]);

            if (timer != 0)
            {
                timer--;
                randomNumber = rndNumber.Next(1, 11);
                randomNumberBox.Text = randomNumber.ToString();
            }
            else
            {
                timer1.Stop();

                resultNumber = int.Parse(randomNumberBox.Text);

                if (resultNumber == number)
                {
                    timer = 5;

                    userNumberBox.BackColor = Color.Green;
                    randomNumberBox.BackColor = Color.Green;

                    money = rndMoney.Next(1 * level, 20 * level);
                    actuallMoney += money;

                    MessageBox.Show($"Vyhráli jste: {money}");

                    playerMoney.RemoveAt(selected);
                    playerMoney.Insert(selected, actuallMoney.ToString());
                    File.WriteAllLines("moneyP.txt", playerMoney.ToArray());

                    userNumberBox.Text = "";
                    userNumberBox.ReadOnly = false;
                    shopBTN.Show();
                    backBTN.Show();
                    startBTN.Hide();
                    acceptBTN.Show();
                }
                else
                {
                    timer = 5;
                    userNumberBox.BackColor = Color.Crimson;
                    randomNumberBox.BackColor = Color.Crimson;

                    MessageBox.Show($"Prohráli jste");

                    userNumberBox.Text = "";
                    userNumberBox.ReadOnly = false;
                    shopBTN.Show();
                    backBTN.Show();
                    startBTN.Hide();
                    acceptBTN.Show();
                }
            }
        }

        // Confirm Buttons
        private void acceptBTN_Click(object sender, EventArgs e)
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> playerMush = new List<string>(File.ReadAllLines("mushP.txt"));
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));

            int selected = int.Parse(playerSelect[0]);
            int coin = int.Parse(playerMush[selected]);

            if (userNumberBox.Text != "")
            {
                number = int.Parse(userNumberBox.Text);
                if (int.Parse(playerMush[selected]) > 0)
                {
                    if (number >= 1 && number <= 10)
                    {
                        coin--;

                        coinBox.Text = coin.ToString();

                        playerMush.RemoveAt(selected);
                        playerMush.Insert(selected, coin.ToString());
                        File.WriteAllLines("mushP.txt", playerMush.ToArray());

                        acceptBTN.Hide();

                        randomNumberBox.Show();
                        userNumberBox.ReadOnly = true;
                        startBTN.Show();

                        MessageBox.Show("Potvrdili jste svoje číslo");

                        userNumberBox.BackColor = Color.White;
                        randomNumberBox.Text = "";
                        randomNumberBox.BackColor = Color.DarkRed;
                        randomNumberBox.ForeColor = Color.White;
                    }
                    else
                    {
                        MessageBox.Show("Zadali jste špatné číslo");
                        userNumberBox.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Nemáte dostatek prostředků na zahájení hry");
                    acceptBTN.Enabled = false;
                    userNumberBox.Clear();
                }
            }
            else MessageBox.Show("Musíte zadat číslo od 1 do 10");
        }

        private void shopBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shop shop = new Shop();
            shop.Show();
        }

        // Back Button
        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            MiniGamesForm mini = new MiniGamesForm();
            mini.Show();
        }

        private void Jackpot_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Jackpot.ModifierKeys == Keys.Alt || Jackpot.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}