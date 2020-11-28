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
    public partial class Elderon : Form
    {
        public Elderon()
        {
            InitializeComponent();

            memberListBox.DrawMode = DrawMode.OwnerDrawFixed;
            memberListBox.DrawItem += new DrawItemEventHandler(memberListBox_DrawItem);

            upMoneyBTN.Hide();
            upPointsBTN.Hide();

            priceMoneyLabel.Hide();
            pricePointsLabel.Hide();

            List<string> playerName = new List<string>(File.ReadAllLines("nameP.txt"));
            List<string> playerLevel = new List<string>(File.ReadAllLines("countLevel.txt"));
            List<string> playerGuild = new List<string>(File.ReadAllLines("guildP.txt"));

            List<string> guildMoneyPlusPrice = new List<string>(File.ReadAllLines("guildMoneyPlusPrice.txt"));
            List<string> guildPointPlusPrice = new List<string>(File.ReadAllLines("guildPointPlusPrice.txt"));

            List<string> guildMoneyPlus = new List<string>(File.ReadAllLines("guildMoneyPlus.txt"));
            List<string> guildPointPlus = new List<string>(File.ReadAllLines("guildPointPlus.txt"));

            List<string> guildStash = new List<string>(File.ReadAllLines("guildStash.txt"));
            List<string> evolveP = new List<string>(File.ReadAllLines("evolveP.txt"));
            List<string> charP = new List<string>(File.ReadAllLines("charP.txt"));

            moneyStashBox.Text = guildStash[0];
            plusMoneyBox.Text = guildMoneyPlus[0];
            plusPointsBox.Text = guildPointPlus[0];

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            guildBox.Text = playerGuild[selected];

            // ------------------------------------------------------------------------------------------

            List<int> levelList = new List<int>();

            for (int i = 0; i < playerLevel.Count; i++) levelList.Add(int.Parse(playerLevel[i]));

            Dictionary<string, int> diction = new Dictionary<string, int>();

            for (int i = 0; i < playerName.Count; i++)
                if ((playerGuild[i] == "Elderon" && int.Parse(playerLevel[i]) >= 15) || (playerGuild[i] == "Elderon" && int.Parse(evolveP[selected]) >= 1)) diction.Add(playerName[i], levelList[i]);

            // ---------------------------------------------------------------------------------------------------
            var items = from pair in diction orderby pair.Value descending select pair;

            foreach (var item in items)
                memberListBox.Items.Add($"{item.Key}");

            int counter = 1;
            foreach (var item in items)
            {
                if (playerName[selected] == item.Key && counter == 1)
                {
                    upMoneyBTN.Show();
                    upPointsBTN.Show();

                    priceMoneyLabel.Show();
                    pricePointsLabel.Show();

                    priceMoneyLabel.Text = $"Cena: {guildMoneyPlusPrice[0]}";
                    pricePointsLabel.Text = $"Cena: {guildPointPlusPrice[0]}";
                }
                counter++;
            }
        }

        private void upMoneyBTN_Click(object sender, EventArgs e)
        {
            List<string> guildMoneyPlusPrice = new List<string>(File.ReadAllLines("guildMoneyPlusPrice.txt"));
            List<string> guildMoneyPlus = new List<string>(File.ReadAllLines("guildMoneyPlus.txt"));
            List<string> guildStash = new List<string>(File.ReadAllLines("guildStash.txt"));

            int upPrice = int.Parse(guildMoneyPlusPrice[0]);
            int stashMoney = int.Parse(guildStash[0]);
            int moneyBonus = int.Parse(guildMoneyPlus[0]);

            if (stashMoney >= upPrice)
            {
                moneyBonus += 5;
                stashMoney -= upPrice;

                if (moneyBonus < 100) upPrice += 500;
                else if (moneyBonus >= 100) upPrice += 1000;

                guildMoneyPlusPrice.RemoveAt(0);
                guildMoneyPlusPrice.Insert(0, upPrice.ToString());

                guildMoneyPlus.RemoveAt(0);
                guildMoneyPlus.Insert(0, moneyBonus.ToString());

                guildStash.RemoveAt(0);
                guildStash.Insert(0, stashMoney.ToString());

                File.WriteAllLines("guildMoneyPlusPrice.txt", guildMoneyPlusPrice.ToArray());
                File.WriteAllLines("guildMoneyPlus.txt", guildMoneyPlus.ToArray());
                File.WriteAllLines("guildStash.txt", guildStash.ToArray());

                priceMoneyLabel.Text = $"Cena: {guildMoneyPlusPrice[0]}";
                moneyStashBox.Text = guildStash[0];
                plusMoneyBox.Text = guildMoneyPlus[0];

                MessageBox.Show("Vylepšení bylo úspěšné");
            }
            else MessageBox.Show($"V královské pokladnici není dostatek peněz. Chybí '{upPrice - stashMoney}'");
        }

        private void upPointsBTN_Click(object sender, EventArgs e)
        {
            List<string> guildPointPlusPrice = new List<string>(File.ReadAllLines("guildPointPlusPrice.txt"));
            List<string> guildPointPlus = new List<string>(File.ReadAllLines("guildPointPlus.txt"));
            List<string> guildStash = new List<string>(File.ReadAllLines("guildStash.txt"));

            int upPrice = int.Parse(guildPointPlusPrice[0]);
            int stashMoney = int.Parse(guildStash[0]);
            int PointBonus = int.Parse(guildPointPlus[0]);

            if (stashMoney >= upPrice)
            {
                PointBonus += 5;
                stashMoney -= upPrice;

                if (PointBonus < 100) upPrice += 500;
                else if (PointBonus >= 100) upPrice += 1000;

                guildPointPlusPrice.RemoveAt(0);
                guildPointPlusPrice.Insert(0, upPrice.ToString());

                guildPointPlus.RemoveAt(0);
                guildPointPlus.Insert(0, PointBonus.ToString());

                guildStash.RemoveAt(0);
                guildStash.Insert(0, stashMoney.ToString());

                File.WriteAllLines("guildPointPlusPrice.txt", guildPointPlusPrice.ToArray());
                File.WriteAllLines("guildPointPlus.txt", guildPointPlus.ToArray());
                File.WriteAllLines("guildStash.txt", guildStash.ToArray());

                pricePointsLabel.Text = $"Cena: {guildPointPlusPrice[0]}";
                moneyStashBox.Text = guildStash[0];
                plusPointsBox.Text = guildPointPlus[0];

                MessageBox.Show("Vylepšení bylo úspěšné");
            }
            else MessageBox.Show($"V královské pokladnici není dostatek peněz. Chybí '{upPrice - stashMoney}'");
        }

        private void giveBTN_Click(object sender, EventArgs e)
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> guildStash = new List<string>(File.ReadAllLines("guildStash.txt"));
            List<string> playerName = new List<string>(File.ReadAllLines("nameP.txt"));

            string time = DateTime.Now.ToString();

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            int stashMoney = int.Parse(guildStash[0]);
            int money = int.Parse(playerMoney[selected]);

            if (giveBox.Text != "")
            {
                if (money >= int.Parse(giveBox.Text))
                {
                    money -= int.Parse(giveBox.Text);
                    stashMoney += int.Parse(giveBox.Text);

                    guildStash.RemoveAt(0);
                    guildStash.Insert(0, stashMoney.ToString());

                    playerMoney.RemoveAt(selected);
                    playerMoney.Insert(selected, money.ToString());

                    int giveMoney = int.Parse(giveBox.Text);

                    giveBox.Text = "";
                    moneyStashBox.Text = guildStash[0];

                    File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
                    File.WriteAllLines("guildStash.txt", guildStash.ToArray());
                    
                    MessageBox.Show("Úspěšně jste vložili částku do království");
                }
                else MessageBox.Show($"Nemůžete darovat tuto částku. Váš aktuální stav peněz: {money}");
            }
            else MessageBox.Show("Nezadali jste žádné číslo");
        }

        private void giveAllBTN_Click(object sender, EventArgs e)
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> guildStash = new List<string>(File.ReadAllLines("guildStash.txt"));
            List<string> playerName = new List<string>(File.ReadAllLines("nameP.txt"));

            string time = DateTime.Now.ToString();

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            int stashMoney = int.Parse(guildStash[0]);
            int money = int.Parse(playerMoney[selected]);

            if (money > 0)
            {
                int giveMoney = money;
                stashMoney += money;
                money = 0;

                guildStash.RemoveAt(0);
                guildStash.Insert(0, stashMoney.ToString());

                playerMoney.RemoveAt(selected);
                playerMoney.Insert(selected, money.ToString());

                moneyStashBox.Text = guildStash[0];

                File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
                File.WriteAllLines("guildStash.txt", guildStash.ToArray());
                
                MessageBox.Show("Úspěšně jste vložili své peníze do království");
            }
            else MessageBox.Show("V aktuální dobu nemáte Peníze");
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void giveBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != '.') errorStringMethod(e);
            else if (ch == '.') errorStringMethod(e);
        }

        public void errorStringMethod(KeyPressEventArgs e)
        {
            MessageBox.Show("Musíte zadat čísla");
            giveBox.Text = "";
            e.Handled = true;
        }

        private void giveBox_TextChanged(object sender, EventArgs e)
        {
            string noSpace = giveBox.Text;

            try
            {
                if (noSpace[0] == '0')
                {
                    MessageBox.Show("Částka nemůže začínat 0");
                    giveBox.Clear();
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void Elderon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Elderon.ModifierKeys == Keys.Alt || Elderon.ModifierKeys == Keys.F4) e.Cancel = true;
        }

        private void memberListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox list = (ListBox)sender;
            if (e.Index > -1)
            {
                object item = list.Items[e.Index];
                e.DrawBackground();
                e.DrawFocusRectangle();
                Brush brush = new SolidBrush(e.ForeColor);
                SizeF size = e.Graphics.MeasureString(item.ToString(), e.Font);
                e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds.Left + (e.Bounds.Width / 2 - size.Width / 2), e.Bounds.Top + (e.Bounds.Height / 2 - size.Height / 2));
            }
        }
    }
}