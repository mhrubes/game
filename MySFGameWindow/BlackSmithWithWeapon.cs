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
    public partial class BlackSmithWithWeapon : Form
    {
        int count = 0;
        public BlackSmithWithWeapon()
        {
            InitializeComponent();
            List<string> weaponBuyName = new List<string>(File.ReadAllLines("weaponBuyName.txt"));
            List<string> plusDamage = new List<string>(File.ReadAllLines("plusDamageP.txt"));
            List<string> weaponDaysP = new List<string>(File.ReadAllLines("weaponDaysP.txt"));
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> weaponPrice = new List<string>(File.ReadAllLines("weaponPrice.txt"));
            List<string> weaponNameShop = new List<string>(File.ReadAllLines("weaponName.txt"));
            List<string> weaponRarity = new List<string>(File.ReadAllLines("weaponRarity.txt"));
            List<string> weaponName = new List<string>(File.ReadAllLines("weaponName.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            weaponNameBox.Text = weaponBuyName[selected];
            count = weaponNameShop.IndexOf(weaponBuyName[selected]);

            int days = int.Parse(weaponDaysP[selected]);
            int res;

            if (days >= 7) res = days - 7;
            else res = 0;

            int sellPrice = 0;
            try
            {
                sellPrice = int.Parse(weaponPrice[count]) / 2;

                if (int.Parse(weaponPrice[count]) == int.Parse(weaponPrice[count]) && int.Parse(weaponPrice[count]) + ((res * 1000) / 2) == 10000) sellPrice = int.Parse(weaponPrice[count]) / 2;

                sellWeaponBTN.Text = sellPrice.ToString();
                plusWeaponDamage.Text = plusDamage[selected];
                remainTimeBox.Text = weaponDaysP[selected];

                if (weaponName[9] != weaponBuyName[selected]) moreDaysBTN.Text = $"1 000";
                else
                {
                    label1.Location = new Point(105, 290);
                    moreDamageBTN.Location = new Point(136, 320);

                    label2.Hide();
                    moreDaysBTN.Hide();
                }
            }
            catch (Exception)
            {
            }

            try
            {
                int damageWeapon = int.Parse(plusDamage[selected]);
                moreDamageBTN.Text = $"{(damageWeapon / 2) * 1000}";
            }
            catch (Exception)
            {
            }
        }

        // More Damage Button
        private void moreDamageBTN_Click(object sender, EventArgs e)
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> plusDamage = new List<string>(File.ReadAllLines("plusDamageP.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            double money = int.Parse(playerMoney[selected]);
            int damage = int.Parse(plusDamage[selected]);

            if (money >= int.Parse(moreDamageBTN.Text))
            {
                MessageBox.Show("Nákup byl 'ÚSPĚŠNÝ'");
                damage++;
                money -= int.Parse(moreDamageBTN.Text);

                playerMoney.RemoveAt(selected);
                playerMoney.Insert(selected, money.ToString());

                plusDamage.RemoveAt(selected);
                plusDamage.Insert(selected, damage.ToString());

                plusWeaponDamage.Text = plusDamage[selected];

                int damageWeapon = int.Parse(plusDamage[selected]);
                moreDamageBTN.Text = $"{(damageWeapon / 2) * 1500}";

                File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
                File.WriteAllLines("plusDamageP.txt", plusDamage.ToArray());
            }
            else MessageBox.Show("Na tento nákup 'NEMÁTE' dostatek prostředků");
        }

        // More Days Button
        private void moreDaysBTN_Click(object sender, EventArgs e)
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> weaponDaysP = new List<string>(File.ReadAllLines("weaponDaysP.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            int days = int.Parse(weaponDaysP[selected]);
            double money = int.Parse(playerMoney[selected]);

            if (money >= 1000)
            {
                MessageBox.Show("Nákup byl 'ÚSPĚŠNÝ'");
                days++;
                money -= 1000;

                weaponDaysP.RemoveAt(selected);
                weaponDaysP.Insert(selected, days.ToString());

                playerMoney.RemoveAt(selected);
                playerMoney.Insert(selected, money.ToString());

                remainTimeBox.Text = weaponDaysP[selected];

                File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
                File.WriteAllLines("weaponDaysP.txt", weaponDaysP.ToArray());
            }
            else MessageBox.Show("Na tento nákup 'NEMÁTE' dostatek prostředků");
        }

        // Sell Weapon Button
        private void sellWeaponBTN_Click(object sender, EventArgs e)
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> plusDamage = new List<string>(File.ReadAllLines("plusDamageP.txt"));
            List<string> weaponBuyName = new List<string>(File.ReadAllLines("weaponBuyName.txt"));
            List<string> weaponRemain = new List<string>(File.ReadAllLines("weaponDaysP.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            double money = int.Parse(playerMoney[selected]);

            money += int.Parse(sellWeaponBTN.Text);

            string plusDamageText = "Null";
            string weaponBuyNameText = "Null";
            string remain = "0";

            playerMoney.RemoveAt(selected);
            playerMoney.Insert(selected, money.ToString());

            plusDamage.RemoveAt(selected);
            plusDamage.Insert(selected, plusDamageText);

            weaponBuyName.RemoveAt(selected);
            weaponBuyName.Insert(selected, weaponBuyNameText);

            weaponRemain.RemoveAt(selected);
            weaponRemain.Insert(selected, remain);


            File.WriteAllLines("plusDamageP.txt", plusDamage.ToArray());
            File.WriteAllLines("weaponBuyName.txt", weaponBuyName.ToArray());
            File.WriteAllLines("weaponDaysP.txt", weaponRemain.ToArray());
            File.WriteAllLines("moneyP.txt", playerMoney.ToArray());

            MessageBox.Show("Úspěšně jste prodali svojí zbraň");

            this.Close();

            Menu menu = new Menu();
            menu.Show();
        }

        // Back Button
        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void BlackSmithWithWeapon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BlackSmithWithWeapon.ModifierKeys == Keys.Alt || BlackSmithWithWeapon.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}