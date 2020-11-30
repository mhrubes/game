using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WMPLib;
using System.Media;
using System.IO;

namespace MySFGameWindow
{
    public partial class Fight : Form
    {
        //WindowsMediaPlayer playerLevelUp = new WindowsMediaPlayer();

        int remainingTime;
        int bossHP;
        int power;

        Random rnd = new Random();

        int score;
        int money;
        int level;
        int floor;

        int counterLevel;

        int hp;

        public Fight()
        {
            InitializeComponent();
            //playerLevelUp.URL = "levelUpSong.mp3";
            //playerLevelUp.controls.stop();

            List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));
            List<string> playerScore = new List<string>(File.ReadAllLines("scoreP.txt"));
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> playerPower = new List<string>(File.ReadAllLines("powerP.txt"));
            List<string> plusDamageP = new List<string>(File.ReadAllLines("plusDamageP.txt"));
            List<string> bossesHP = new List<string>(File.ReadAllLines("bossHP.txt"));
            List<string> playerFloor = new List<string>(File.ReadAllLines("floorP.txt"));
            List<string> charP = new List<string>(File.ReadAllLines("charP.txt"));
            List<string> evolveP = new List<string>(File.ReadAllLines("evolveP.txt"));
            List<string> countLevel = new List<string>(File.ReadAllLines("countLevel.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            floor = int.Parse(playerFloor[selected]);
            level = int.Parse(playerLevel[selected]);
            bossHP = int.Parse(bossesHP[selected]);

            counterLevel = int.Parse(countLevel[selected]);
            power = int.Parse(playerPower[selected]) + int.Parse(plusDamageP[selected]);

            hp = bossHP;
            liveBox.Text = hp.ToString();

            if (floor < 5) remainingTime = 10;
            else if (floor >= 5 && floor < 10) remainingTime = 15;
            else if (floor >= 10 && floor < 15) remainingTime = 20;
            else if (floor >= 15 && floor < 20) remainingTime = 30;

            try
            {
                progressBar1.Value = 100;
                progressBar1.Maximum = 100;
            }
            catch (Exception)
            {
            }

            if (charP[selected] == "Valecnik" || int.Parse(evolveP[selected]) >= 2) remainingTime += 5;

            timeBox.Text = remainingTime.ToString();
            lootLabel.Hide();
            lootLabel.Text = "";

            backBTN.Hide();

            timer1.Start();
        }

        // Tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remainingTime != 0)
            {
                //playerLevelUp.controls.stop();
                remainingTime--;
                timeBox.Text = remainingTime.ToString();
                liveBox.Text = hp.ToString();
            }
            if (progressBar1.Value <= 0)
            {
                if (hp < 0)
                {
                    progressBar1.Value = 0;
                    liveBox.Text = "0";

                    timer1.Stop();

                    attackBTN.Hide();
                    backBTN.Show();

                    List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));
                    List<string> playerScore = new List<string>(File.ReadAllLines("scoreP.txt"));
                    List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
                    List<string> playerFloor = new List<string>(File.ReadAllLines("floorP.txt"));
                    List<string> bossesHP = new List<string>(File.ReadAllLines("bossHP.txt"));
                    List<string> charP = new List<string>(File.ReadAllLines("charP.txt"));
                    List<string> countLevel = new List<string>(File.ReadAllLines("countLevel.txt"));

                    List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));

                    int selected = int.Parse(playerSelect[0]);
                    int actuallScore = int.Parse(playerScore[selected]);
                    int actuallMoney = int.Parse(playerMoney[selected]);
                    double actuallBossesHP = int.Parse(playerMoney[selected]);
                    int actuallFloor = int.Parse(playerFloor[selected]);

                    while (money == score)
                    {
                        money = rnd.Next(5 * level, 20 * level) * 3;
                        score = rnd.Next(2 * level, 20 * level) * 3;
                    }

                    lootLabel.Show();
                    lootLabel.Text = $"Získali jste: {money} peněz a {score} skóre";

                    actuallScore += score;

                    if (actuallScore >= level * 100)
                    {
                        do
                        {
                            actuallScore -= level * 100;

                            if (charP[selected] == "Kouzelnik")
                            {
                                actuallScore = 0;

                                playerScore.RemoveAt(selected);
                                playerScore.Insert(selected, actuallScore.ToString());

                                actuallScore += 300;
                            }

                            //playerLevelUp.controls.play();
                            MessageBox.Show("Získali jste nový level");

                            level++;
                            counterLevel++;
                            actuallFloor++;
                            actuallBossesHP = bossHP * 2;
                            actuallMoney += money;

                            countLevel.RemoveAt(selected);
                            countLevel.Insert(selected, counterLevel.ToString());

                            playerScore.RemoveAt(selected);
                            playerScore.Insert(selected, actuallScore.ToString());

                            playerMoney.RemoveAt(selected);
                            playerMoney.Insert(selected, actuallMoney.ToString());

                            playerLevel.RemoveAt(selected);
                            playerLevel.Insert(selected, level.ToString());

                            bossesHP.RemoveAt(selected);
                            bossesHP.Insert(selected, actuallBossesHP.ToString());

                            playerFloor.RemoveAt(selected);
                            playerFloor.Insert(selected, actuallFloor.ToString());

                            File.WriteAllLines("scoreP.txt", playerScore.ToArray());
                            File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
                            File.WriteAllLines("levelP.txt", playerLevel.ToArray());
                            File.WriteAllLines("bossHP.txt", bossesHP.ToArray());
                            File.WriteAllLines("floorP.txt", playerFloor.ToArray());
                            File.WriteAllLines("countLevel.txt", countLevel.ToArray());
                        } while (actuallScore >= level * 100);
                    }
                    else
                    {
                        //playerLevelUp.controls.stop();
                        actuallFloor++;
                        actuallBossesHP = bossHP * 2;
                        actuallMoney += money;

                        playerScore.RemoveAt(selected);
                        playerScore.Insert(selected, actuallScore.ToString());

                        playerMoney.RemoveAt(selected);
                        playerMoney.Insert(selected, actuallMoney.ToString());

                        bossesHP.RemoveAt(selected);
                        bossesHP.Insert(selected, actuallBossesHP.ToString());

                        playerFloor.RemoveAt(selected);
                        playerFloor.Insert(selected, actuallFloor.ToString());

                        File.WriteAllLines("scoreP.txt", playerScore.ToArray());
                        File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
                        File.WriteAllLines("bossHP.txt", bossesHP.ToArray());
                        File.WriteAllLines("floorP.txt", playerFloor.ToArray());
                    }
                }
            }
            if (remainingTime == 0 && progressBar1.Value >= 0)
            {
                //playerLevelUp.controls.stop();
                timer1.Stop();
                attackBTN.Hide();
                backBTN.Show();

                MessageBox.Show("Neporazili jste protivníka");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (hp <= 0) liveBox.Text = "0";
        }

        // Attack Button
        private void attackBTN_Click(object sender, EventArgs e)
        {
            try
            {
                hp -= power;
                progressBar1.Value -= hp;
                liveBox.Text = hp.ToString();

                if (hp < 0 || int.Parse(liveBox.Text) < 0) progressBar1.Value -= progressBar1.Value;
            }
            catch (Exception)
            {
            }
        }

        // Back Button
        private void backBTN_Click(object sender, EventArgs e)
        {
            //playerLevelUp.controls.stop();
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void Fight_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Fight.ModifierKeys == Keys.Alt || Fight.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}