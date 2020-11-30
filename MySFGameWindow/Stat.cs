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
    public partial class Stat : Form
    {
        SourceClass source = new SourceClass();
        public Stat()
        {
            InitializeComponent();

            nextLevelLabel.Hide();

            progressBar1.BackColor = Color.Black;
            progressBar1.ForeColor = Color.DarkBlue;
            progressBar1.ForeColor = Color.DarkBlue;

            Form fc = Application.OpenForms["Adventure"];
            if (fc != null) timer1.Start();

            List<string> playerName = new List<string>(File.ReadAllLines("nameP.txt"));
            List<string> playerPassword = new List<string>(File.ReadAllLines("passwordP.txt"));
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> playerScore = new List<string>(File.ReadAllLines("scoreP.txt"));
            List<string> playerMush = new List<string>(File.ReadAllLines("mushP.txt"));
            List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));
            List<string> playerPower = new List<string>(File.ReadAllLines("powerP.txt"));
            List<string> plusDamage = new List<string>(File.ReadAllLines("plusDamageP.txt"));
            List<string> weaponName = new List<string>(File.ReadAllLines("weaponBuyName.txt"));
            List<string> weaponDaysP = new List<string>(File.ReadAllLines("weaponDaysP.txt"));
            List<string> pictureCharP = new List<string>(File.ReadAllLines("pictureCharP.txt"));
            List<string> playerGuild = new List<string>(File.ReadAllLines("guildP.txt"));
            List<string> charP = new List<string>(File.ReadAllLines("charP.txt"));
            List<string> evolveP = new List<string>(File.ReadAllLines("evolveP.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));

            int selected = int.Parse(playerSelect[0]);

            nextLevelLabel.Text = $"{playerScore[selected]}/" + (int.Parse(playerLevel[selected]) * 100).ToString();

            try
            {
                progressBar1.Maximum = int.Parse(playerLevel[selected]) * 100;
                progressBar1.Value = int.Parse(playerScore[selected]);
            }
            catch (Exception)
            {
            }

            try
            {
                chooseCharPictureMethod(source.source + @"game\MySFGameWindow\charPictures\" + pictureCharP[selected]);
                // Need Change A Road
            }
            catch (Exception)
            {
                charPictureBox.BackColor = Color.Transparent;
            }

            nameLabel.Text = playerName[selected];
            moneyBox.Text = playerMoney[selected];
            coinBox.Text = playerMush[selected];
            powerBox.Text = playerPower[selected];
            plusWeaponDamage.Text = plusDamage[selected];
            remainTimeBox.Text = weaponDaysP[selected];
            label7.Text = playerGuild[selected];
            evolveBox.Text = evolveP[selected];

            if (charP[selected] == "Valecnik") classLabel.Text = "Válečník";
            else if (charP[selected] == "Kouzelnik") classLabel.Text = "Kouzelník";
            else if (charP[selected] == "Lovec") classLabel.Text = "Lovec";
            else if (charP[selected] == "Alchymista") classLabel.Text = "Alchymista";
            else if (charP[selected] == "Lord") classLabel.Text = "Lord";
            else if (charP[selected] == "Paladin") classLabel.Text = "Paladin";

      if (weaponName[selected] == "Sekerokyj") weaponNameBox.Text = "Sekerokyj";
            else if (weaponName[selected] == "Hnedorez") weaponNameBox.Text = "Hnědořez";
            else if (weaponName[selected] == "Drakorezak") weaponNameBox.Text = "Drakořezák";
            else if (weaponName[selected] == "Zabijak koz") weaponNameBox.Text = "Zabiják koz";
            else if (weaponName[selected] == "Mlatic medvedu") weaponNameBox.Text = "Mlátič medvědů";
            else if (weaponName[selected] == "Placacka") weaponNameBox.Text = "Plácačka";
            else if (weaponName[selected] == "Mlatic komaru") weaponNameBox.Text = "Mlátič komárů";
            else if (weaponName[selected] == "Komari zabijak") weaponNameBox.Text = "Komáří zabiják";
            else if (weaponName[selected] == "Vajecny prak") weaponNameBox.Text = "Vaječný prak";

            // Legendary Weapon
            else if (weaponName[selected] == "Legendarni luk") weaponNameBox.Text = "Legendární luk";

            passwordBOX.Text = "******";

            /*
            progressBar1.BackColor = Color.Purple;
            progressBar1.ForeColor = Color.Orange;
            progressBar1.Maximum = int.Parse(playerLevel[selected]) * 100;
            progressBar1.Value = int.Parse(playerScore[selected]);
            */

            if (int.Parse(evolveP[selected]) == 0) changeColor(Color.White, Color.Black);
            else if (int.Parse(evolveP[selected]) == 1) changeColor(Color.GhostWhite, Color.Black);
            else if (int.Parse(evolveP[selected]) == 2) changeColor(Color.Purple, Color.Yellow);
            else if (int.Parse(evolveP[selected]) == 3) changeColor(Color.Black, Color.White);
            else if (int.Parse(evolveP[selected]) == 4) changeColor(Color.Black, Color.Gold);
            else if (int.Parse(evolveP[selected]) >= 5) changeColor(Color.Gold, Color.Black);

            int level = int.Parse(playerLevel[selected]);
            int score = int.Parse(playerScore[selected]);

            nextLevelLabel.Text = score + " / " + level * 100;
        }

        public void changeColor(Color one, Color two)
        {
            evolveBox.BackColor = one;
            evolveBox.ForeColor = two;
        }

        // Method On Picture
        private void chooseCharPictureMethod(string root)
        {
            charPictureBox.Image = new Bitmap($"{root}");
            charPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // Set New Password Button
        private void newPasswordBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            NewPassword setPassword = new NewPassword();
            setPassword.Show();
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        // Glory Button
        private void gloryBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glory glory = new Glory();
            glory.Show();
        }

        // Evolve Button
        private void evolveHelpBTN_Click(object sender, EventArgs e) => MessageBox.Show(
          "Evolve 1 \n• Odemknutí povolání 'Lord' \nZískání bonusů z království od levelu 1 \n• Snížený čas v dobrodružství na polovinu Od levelu '20' " +
          "\n\nEvolve 2 \n• Dvojnásobná doba zbraně při nákupu \n• Zvýšený čas v Challenge o 5 vteřin " +
          "\n\nEvolve 3 \n• Bonus k penězům za výpravu " +
          "\n\nEvolve 4 \n• Bonus ke zkušenostem za výpravu " +
          "\n\nEvolve 5 \n• Snížený čas v dobrodružství na polovinu Od levelu '10' \n\nEvolve 10 \n• Bonus k surovinám za výpravu od levelu 1 \n• Odemknutí povolání Paladin");

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            try
            {
                for (int i = 0; i < 2; i++)
                {
                    progressBar1.Refresh();
                    progressBar1.CreateGraphics().DrawString(playerLevel[selected], new Font("Arial", (float)18.25, FontStyle.Regular), Brushes.White, new PointF(progressBar1.Width / 2 - 18, progressBar1.Height / 2 - 15));
                }
            }
            catch (Exception)
            {
            }
        }

        private void progressBar1_MouseMove(object sender, MouseEventArgs e) => nextLevelLabel.Show();
        private void progressBar1_MouseLeave(object sender, EventArgs e) => nextLevelLabel.Hide();

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e) => nextLevelLabel.Show();
        private void pictureBox2_MouseLeave(object sender, EventArgs e) => nextLevelLabel.Hide();

        private void inventoryBTN_Click(object sender, EventArgs e)
        {
            Form inv = Application.OpenForms["Inventory"];
            if (inv == null) new Inventory().Show();
            else MessageBox.Show("V aktuální době není možné otevřít Inventář");
        }

        private void Stat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Stat.ModifierKeys == Keys.Alt || Stat.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}