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
    public partial class Blacksmith : Form
    {
        public Blacksmith()
        {
            InitializeComponent();

            timer1.Start();

            label1.Hide();
            label2.Hide();
            urovenLabel.Hide();
            priceLabel.Hide();
            type.Hide();
            buyBTN.Hide();
            label4.Hide();
            plusAttackLabel.Hide();

            List<string> weaponName = new List<string>(File.ReadAllLines("weaponName.txt"));
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            moneyBox.Text = playerMoney[selected];

            string time = DateTime.Now.ToString();
            string substr = time.Substring(0, 2);

            if (substr[0] == '0')
            {
                if (int.Parse(substr) >= 1 && int.Parse(substr) < 10) weaponBOX.Items.AddRange(new object[] { weaponName[0], weaponName[1], weaponName[2] });
            }
            else if (substr[0] != '0')
                if (int.Parse(substr) >= 10 && int.Parse(substr) < 20) weaponBOX.Items.AddRange(new object[] { weaponName[3], weaponName[4], weaponName[5] });
                else if (int.Parse(substr) >= 20 && int.Parse(substr) <= 30 || int.Parse(substr) > 20 && int.Parse(substr) <= 31) weaponBOX.Items.AddRange(new object[] { weaponName[6], weaponName[7], weaponName[8] });

            // Limited Weapon
            weaponBOX.Items.Add(weaponName[9]);
        }

        // Back Button
        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        // Block Write to Combo Box
        private void weaponBOX_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        // Buy Button
        private void buyBTN_Click(object sender, EventArgs e)
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> plusDamage = new List<string>(File.ReadAllLines("plusDamageP.txt"));
            List<string> weaponPrice = new List<string>(File.ReadAllLines("weaponPrice.txt"));
            List<string> wood = new List<string>(File.ReadAllLines("wood.txt"));
            List<string> stone = new List<string>(File.ReadAllLines("stone.txt"));
            List<string> wool = new List<string>(File.ReadAllLines("wool.txt"));
            List<string> weaponBuyName = new List<string>(File.ReadAllLines("weaponBuyName.txt"));
            List<string> weaponDaysRemain = new List<string>(File.ReadAllLines("weaponDaysP.txt"));
            List<string> charP = new List<string>(File.ReadAllLines("charP.txt"));
            List<string> evolveP = new List<string>(File.ReadAllLines("evolveP.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);
            double money = int.Parse(playerMoney[selected]);

            int selectedIndex = weaponBOX.SelectedIndex;
            int price = int.Parse(weaponPrice[selectedIndex]);

            if (priceLabel.Text == "30000")
            {
                if (money >= price)
                {
                    if (money >= int.Parse(priceLabel.Text))
                    {
                        DialogResult dialog = MessageBox.Show("Opravdu chcete koupit tuto zbraň?", "Zpět", MessageBoxButtons.YesNo);

                        if (dialog == DialogResult.Yes)
                        {
                            money -= int.Parse(priceLabel.Text);

                            playerMoney.RemoveAt(selected);
                            playerMoney.Insert(selected, money.ToString());

                            plusDamage.RemoveAt(selected);
                            plusDamage.Insert(selected, plusAttackLabel.Text.ToString());

                            int week;
                            if (charP[selected] == "Valecnik" || int.Parse(evolveP[selected]) >= 2) week = 14;
                            else week = 7;

                            weaponDaysRemain.RemoveAt(selected);
                            weaponDaysRemain.Insert(selected, week.ToString());

                            weaponBuyName.RemoveAt(selected);
                            weaponBuyName.Insert(selected, weaponBOX.Text.ToString());

                            File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
                            File.WriteAllLines("plusDamageP.txt", plusDamage.ToArray());
                            File.WriteAllLines("weaponBuyName.txt", weaponBuyName.ToArray());
                            File.WriteAllLines("weaponDaysP.txt", weaponDaysRemain.ToArray());

                            moneyBox.Text = playerMoney[selected];

                            MessageBox.Show("Nákup byl 'ÚSPĚŠNÝ'");

                            this.Close();
                            Menu menu = new Menu();
                            menu.Show();
                        }
                        else if (dialog == DialogResult.No) MessageBox.Show("Nekoupili jste zbraň");
                    }
                    else MessageBox.Show("Na tento nákup nemáte 'dostatek' prostředků");
                }
            }
            else if (type.Text == "dřeva" || type.Text == "kamene" || type.Text == "vlny")
            {
                if (int.Parse(wood[selected]) >= int.Parse(priceLabel.Text) || int.Parse(stone[selected]) >= int.Parse(priceLabel.Text) || int.Parse(wool[selected]) >= int.Parse(priceLabel.Text))
                {
                    DialogResult dialog = MessageBox.Show("Opravdu chcete koupit tuto zbraň?", "Zpět", MessageBoxButtons.YesNo);

                    if (dialog == DialogResult.Yes)
                    {
                        int woodCount = int.Parse(wood[selected]);
                        int stoneCount = int.Parse(stone[selected]);
                        int woolCount = int.Parse(wool[selected]);

                        if (type.Text == "dřeva") getResource(woodCount, selected, "wood.txt", wood);
                        else if (type.Text == "kamene") getResource(stoneCount, selected, "stone.txt", stone);
                        else if (type.Text == "vlny") getResource(woolCount, selected, "wool.txt", wool);

                        plusDamage.RemoveAt(selected);
                        plusDamage.Insert(selected, plusAttackLabel.Text.ToString());

                        int week;
                        if (charP[selected] == "Valecnik" || int.Parse(evolveP[selected]) >= 2) week = 14;
                        else week = 7;

                        weaponDaysRemain.RemoveAt(selected);
                        weaponDaysRemain.Insert(selected, week.ToString());

                        weaponBuyName.RemoveAt(selected);
                        weaponBuyName.Insert(selected, weaponBOX.Text.ToString());

                        File.WriteAllLines("plusDamageP.txt", plusDamage.ToArray());
                        File.WriteAllLines("weaponBuyName.txt", weaponBuyName.ToArray());
                        File.WriteAllLines("weaponDaysP.txt", weaponDaysRemain.ToArray());

                        MessageBox.Show("Nákup byl 'ÚSPĚŠNÝ'");

                        this.Close();
                        Menu menu = new Menu();
                        menu.Show();
                    }
                    else if (dialog == DialogResult.No) MessageBox.Show("Nekoupili jste zbraň");
                }
                else MessageBox.Show("Na tento nákup nemáte 'dostatek' zdrojů");
            }
            else MessageBox.Show("Nákup se nezdařil");
        }

        void getResource(int typeCount, int selected, string text, List<string> type)
        {
            typeCount -= int.Parse(priceLabel.Text);
            type.RemoveAt(selected);
            type.Insert(selected, typeCount.ToString());
            File.WriteAllLines(text, type.ToArray());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (weaponBOX.Text == "Sekerokyj") weaponBOX.Text = "Sekerokyj";
            else if (weaponBOX.Text == "Hnedorez") weaponBOX.Text = "Hnědořez";
            else if (weaponBOX.Text == "Drakorezak") weaponBOX.Text = "Drakořezák";
            else if (weaponBOX.Text == "Zabijak koz") weaponBOX.Text = "Zabiják koz";
            else if (weaponBOX.Text == "Mlatic medvedu") weaponBOX.Text = "Mlátič medvědů";
            else if (weaponBOX.Text == "Placacka") weaponBOX.Text = "Plácačka";
            else if (weaponBOX.Text == "Mlatic komaru") weaponBOX.Text = "Mlátič komárů";
            else if (weaponBOX.Text == "Komari zabijak") weaponBOX.Text = "Komáří zabiják";
            else if (weaponBOX.Text == "Vajecny prak") weaponBOX.Text = "Vaječný prak";

            // Legendary Weapon
            else if (weaponBOX.Text == "Legendarni luk") weaponBOX.Text = "Legendární luk";

            List<string> weaponRarity = new List<string>(File.ReadAllLines("weaponRarity.txt"));
            List<string> weaponDamage = new List<string>(File.ReadAllLines("weaponDamage.txt"));

            int selectedIndex = weaponBOX.SelectedIndex;
            //
            try
            {
                if (selectedIndex == 0) addWeaponsMethod(weaponRarity, weaponDamage, 0);
                else if (selectedIndex == 1) addWeaponsMethod(weaponRarity, weaponDamage, 1);
                else if (selectedIndex == 2) addWeaponsMethod(weaponRarity, weaponDamage, 2);
                else if (selectedIndex == 3) addLegendaryWeapon();
            }
            catch (Exception)
            {
            }

            if (weaponBOX.Text != "") buyBTN.Show();
            else buyBTN.Hide();
        }

        private void addWeaponsMethod(List<string> weaponRarity, List<string> weaponDamage, int numberSelected)
        {
            label1.Show();
            label2.Show();
            label4.Show();

            urovenLabel.Text = weaponRarity[numberSelected];
            urovenLabel.Show();

            int selectedIndex = weaponBOX.SelectedIndex;
            if (selectedIndex == 0)
            {
                priceLabel.Text = 5000.ToString();
                priceLabel.Show();

                type.Text = "dřeva";
                type.Show();
            }
            else if (selectedIndex == 1)
            {
                priceLabel.Text = 2500.ToString();
                priceLabel.Show();

                type.Text = "kamene";
                type.Show();
            }
            else if (selectedIndex == 2)
            {
                priceLabel.Text = 1000.ToString();
                priceLabel.Show();

                type.Text = "vlny";
                type.Show();
            }

            plusAttackLabel.Text = weaponDamage[numberSelected];
            plusAttackLabel.Show();
        }

        private void addLegendaryWeapon()
        {
            type.Hide();
            label1.Show();
            label2.Show();
            label4.Show();

            urovenLabel.Text = "Legendary";
            urovenLabel.Show();

            priceLabel.Text = "30000";
            priceLabel.Show();

            plusAttackLabel.Text = "30";
            plusAttackLabel.Show();
        }

        private void Blacksmith_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Blacksmith.ModifierKeys == Keys.Alt || Blacksmith.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}