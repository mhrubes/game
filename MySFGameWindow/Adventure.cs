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
    public partial class Adventure : Form
    {
        SourceClass source = new SourceClass();

        int reset = 0;

        WindowsMediaPlayer player = new WindowsMediaPlayer();
        // WindowsMediaPlayer playerLevelUp = new WindowsMediaPlayer();

        Random time = new Random();
        int zbyva;
        int timer;

        Random rnd = new Random();

        int score;
        int money;
        int level;
        int actuallLevel;
        int counterLevel;

        string charSelect;

        int remainTime;

        int minute = 0;

        public Adventure()
        {
            InitializeComponent();

            timeLabel.Text = "";
            timeLabel.Hide();

            Random rand = new Random();
            int selectBackground = rand.Next(9);

            try
            {
                if (selectBackground == 1) this.BackgroundImage = new Bitmap(source.source + @"My_Sf_upgrade\MySFGameWindow\backPicture\oneBack.jpg");
                else if (selectBackground == 2) this.BackgroundImage = new Bitmap(source.source + @"My_Sf_upgrade\MySFGameWindow\backPicture\twoBack.jpg");
                else if (selectBackground == 3) this.BackgroundImage = new Bitmap(source.source + @"My_Sf_upgrade\MySFGameWindow\backPicture\threeBack.jpg");
                else if (selectBackground == 4) this.BackgroundImage = new Bitmap(source.source + @"My_Sf_upgrade\MySFGameWindow\backPicture\fourBack.jpg");
                else if (selectBackground == 5) this.BackgroundImage = new Bitmap(source.source + @"My_Sf_upgrade\MySFGameWindow\backPicture\fiveBack.jpg");
                else if (selectBackground == 6) this.BackgroundImage = new Bitmap(source.source + @"My_Sf_upgrade\MySFGameWindow\backPicture\sixBack.jpg");
                else if (selectBackground == 7) this.BackgroundImage = new Bitmap(source.source + @"My_Sf_upgrade\MySFGameWindow\backPicture\sevenBack.jpg");
                else if (selectBackground == 8) this.BackgroundImage = new Bitmap(source.source + @"My_Sf_upgrade\MySFGameWindow\backPicture\eightBack.jpg");
            }
            catch (Exception)
            {
                this.BackColor = Color.Black;
            }

            panel1.Hide();
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);

            /*
            player.URL = "tickTime.mp3";
            */
            // playerLevelUp.URL = "levelUpSong.mp3";
            // playerLevelUp.controls.stop();

            moneyLabel.Hide();
            scoreLabel.Hide();

            pictureBox1.Hide();
            pictureBox2.Hide();

            progressBar1.BackColor = Color.Black;
            progressBar1.ForeColor = Color.DarkBlue;
            backBTN.BackColor = Color.Crimson;

            List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));
            List<string> playerScore = new List<string>(File.ReadAllLines("scoreP.txt"));
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> remainTimeP = new List<string>(File.ReadAllLines("remainTimeP.txt"));
            List<string> charP = new List<string>(File.ReadAllLines("charP.txt"));
            List<string> evolveP = new List<string>(File.ReadAllLines("evolveP.txt"));
            List<string> countLevel = new List<string>(File.ReadAllLines("countLevel.txt"));
            List<string> wood = new List<string>(File.ReadAllLines("wood.txt"));
            List<string> stone = new List<string>(File.ReadAllLines("stone.txt"));
            List<string> wool = new List<string>(File.ReadAllLines("wool.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);
            level = int.Parse(playerLevel[selected]);
            actuallLevel = int.Parse(playerLevel[selected]);
            charSelect = charP[selected];
            counterLevel = int.Parse(countLevel[selected]);

            try
            {
                remainTime = int.Parse(remainTimeP[selected]);
            }
            catch (Exception)
            {
            }

            timer1.Start();
            /*
            player.controls.play();
            */

            // Set Random Time Of Adventure
            if (remainTime == 0)
            {
                if (level <= 4) setterMethod(10, 15);
                else if (level > 4 && level <= 10) setterMethod(15, 30);
                else if (level > 10 && level <= 15) setterMethod(30, 100);
                else if (level > 15 && level <= 20) setterMethod(100, 250);
                else if (level > 20 && level <= 25) setterMethod(250, 300);
                else if (level > 25 && level <= 30) setterMethod(300, 400);
                else if (level > 30 && level <= 40) setterMethod(400, 500);
                else if (level > 40 && level <= 50) setterMethod(500, 600);
                else if (level > 50 && level <= 60) setterMethod(600, 700);
                else if (level > 60 && level <= 70) setterMethod(600, 800);
                else if (level > 70 && level <= 80) setterMethod(600, 900);
                else if (level > 80 && level <= 90) setterMethod(600, 1000);
                else if (level > 90 && level <= 100) setterMethod(600, 1100);
                else if (level > 100 && level <= 150) setterMethod(800, 1300);
                else if (level > 150 && level <= 200) setterMethod(800, 1500);

                if (level >= 20 && int.Parse(evolveP[selected]) < 5)
                {
                    if (charP[selected] == "Paladin") resMethod(2);
                }
                else if (int.Parse(evolveP[selected]) >= 5 && level >= 10)
                {
                    if (charP[selected] == "Paladin") resMethod(2);
                }
            }
            else
            {
                progressBar1.Maximum = remainTime;
                zbyva = progressBar1.Maximum;
                timer = progressBar1.Maximum;
            }

            if (timer >= 60)
            {
                while (timer >= 60)
                {
                    timer -= 60;
                    minute++;
                }
            }
        }

        // Method Set After Select Time
        private void resMethod(int a)
        {
            progressBar1.Maximum = progressBar1.Maximum / a;
            zbyva = progressBar1.Maximum;
            timer = progressBar1.Maximum;
        }

        // Method Set Timer For Adventure
        private void setterMethod(int a, int b)
        {
            progressBar1.Maximum = time.Next(a, b);
            zbyva = progressBar1.Maximum;
            timer = progressBar1.Maximum;
        }

        // Tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            List<string> playerScore = new List<string>(File.ReadAllLines("scoreP.txt"));
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));
            List<string> remainTimeP = new List<string>(File.ReadAllLines("remainTimeP.txt"));
            List<string> evolveP = new List<string>(File.ReadAllLines("evolveP.txt"));
            List<string> countLevel = new List<string>(File.ReadAllLines("countLevel.txt"));
            List<string> wood = new List<string>(File.ReadAllLines("wood.txt"));
            List<string> stone = new List<string>(File.ReadAllLines("stone.txt"));
            List<string> wool = new List<string>(File.ReadAllLines("wool.txt"));

            List<string> guildP = new List<string>(File.ReadAllLines("guildP.txt"));

            List<string> plusMoneyP = new List<string>(File.ReadAllLines("guildMoneyPlus.txt"));
            List<string> plusPointP = new List<string>(File.ReadAllLines("guildPointPlus.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));

            List<string> autoplay = new List<string>(File.ReadAllLines("autoplay.txt"));

            int selected = 0;
            int actuallScore = 0;
            int actuallMoney = 0;

            int plusMoney = 0;
            int plusPoint = 0;

            int actuallWoodCount = 0;
            int actuallStoneCount = 0;
            int actuallWoolCount = 0;

            bool automat = false;
            try
            {
                selected = int.Parse(playerSelect[0]);
                actuallScore = int.Parse(playerScore[selected]);
                actuallMoney = int.Parse(playerMoney[selected]);

                actuallWoodCount = int.Parse(wood[selected]);
                actuallStoneCount = int.Parse(stone[selected]);
                actuallWoolCount = int.Parse(wool[selected]);

                automat = bool.Parse(autoplay[0]);

                if (guildP[selected] == "Elderon")
                {
                    plusMoney = int.Parse(plusMoneyP[0]);
                    plusPoint = int.Parse(plusPointP[0]);
                }
                else if (guildP[selected] == "Aras")
                {
                    plusMoney = int.Parse(plusMoneyP[1]);
                    plusPoint = int.Parse(plusPointP[1]);
                }
                else if (guildP[selected] == "Bundur")
                {
                    plusMoney = int.Parse(plusMoneyP[2]);
                    plusPoint = int.Parse(plusPointP[2]);
                }
            }
            catch (Exception)
            {
            }

            if (progressBar1.Value != progressBar1.Maximum)
            {
                if (timer == 0)
                {
                    timer += 59;
                    minute--;
                }
                else
                {
                    // playerLevelUp.controls.stop();
                    timer--;
                    progressBar1.Value++;
                }

                progressBar1.Refresh();

                if (minute > 0 && timer >= 10)
                {
                    timeLabel.Text = minute.ToString() + ":" + timer.ToString();
                    progressBar1.CreateGraphics().DrawString(timeLabel.Text, new Font("Arial", (float)15.25, FontStyle.Regular), Brushes.White, new PointF(progressBar1.Width / 2 - 25, progressBar1.Height / 2 - 13));
                }
                else if (minute > 0 && timer < 10)
                {
                    timeLabel.Text = minute.ToString() + ":" + "0" + timer.ToString();
                    progressBar1.CreateGraphics().DrawString(timeLabel.Text, new Font("Arial", (float)15.25, FontStyle.Regular), Brushes.White, new PointF(progressBar1.Width / 2 - 25, progressBar1.Height / 2 - 13));
                }
                else if (minute == 0 && timer == 0)
                {
                    timeLabel.Text = "0" + " sekund";
                    progressBar1.Value = progressBar1.Maximum;
                }
                else
                {
                    timeLabel.Text = timer.ToString() + " sekund";
                    progressBar1.CreateGraphics().DrawString(timeLabel.Text, new Font("Arial", (float)15.25, FontStyle.Regular), Brushes.White, new PointF(progressBar1.Width / 2 - 45, progressBar1.Height / 2 - 13));
                }
            }
            else
            {
                List<int> numberList = new List<int>();
                Random rnd = new Random();
                for (int i = 0; i < 20; i++) numberList.Add(rnd.Next(1, 101));

                int woodCount = 0;
                int stoneCount = 0;
                int woolCount = 0;
                foreach (var item in numberList)
                {
                    if (level >= 10 && level < 20)
                    {
                        if (item == 2 || item == 11 || item == 22 || item == 33 || item == 44 || item == 55 || item == 66 || item == 77 || item == 88 || item == 90) woodCount++;
                    }
                    else if (level >= 20 && level < 30)
                    {
                        if (item == 2 || item == 11 || item == 22 || item == 33 || item == 44 || item == 55 || item == 66 || item == 77 || item == 88 || item == 90) woodCount++;
                        else if (item == 1 || item == 5 || item == 20 || item == 50 || item == 99) stoneCount++;
                    }
                    else if (level >= 30)
                    {
                        if (item == 2 || item == 11 || item == 22 || item == 33 || item == 44 || item == 55 || item == 66 || item == 77 || item == 88 || item == 90) woodCount++;
                        else if (item == 1 || item == 5 || item == 20 || item == 50 || item == 99) stoneCount++;
                        else if (item == 100) woolCount++;
                    }
                }

                if (woodCount != 0 && int.Parse(playerLevel[selected]) >= 20) woodCount += int.Parse(playerLevel[selected]);
                if (stoneCount != 0 && int.Parse(playerLevel[selected]) >= 30) stoneCount += int.Parse(playerLevel[selected]) / 2;

                while (money == score)
                {
                    if (int.Parse(playerLevel[selected]) >= 15 || int.Parse(evolveP[selected]) >= 1)
                    {
                        money = rnd.Next(1 * level, 10 * level) + plusMoney;
                        score = rnd.Next(1 * level, 10 * level) + plusPoint;
                    }
                    else
                    {
                        money = rnd.Next(1 * level, 10 * level);
                        score = rnd.Next(1 * level, 10 * level);
                    }
                }
                /*
                player.controls.stop();
                */
                timer1.Stop();
                backBTN.BackColor = Color.DarkSeaGreen;

                int addMoney = 0;
                int addScore = 0;

                if (charSelect == "Lovec" || int.Parse(evolveP[selected]) >= 3)
                {
                    addMoney = (money / 2) + money;
                    addScore = score;
                }
                else if (charSelect == "Kouzelnik" || int.Parse(evolveP[selected]) >= 4)
                {
                    addScore = (score / 2) + score;
                    addMoney = money;
                }
                else if (charSelect == "Valecnik" || charSelect == "Paladin" || charSelect == "Alchymista")
                {
                    addMoney = money;
                    addScore = score;
                }

                pictureBox3.Hide();
                pictureBox4.Hide();

                timeLabel.Hide();
                panel1.Show();

                moneyLabel.Text = addMoney.ToString();
                scoreLabel.Text = addScore.ToString();

                pictureBox1.Show();
                pictureBox2.Show();
                moneyLabel.Show();
                scoreLabel.Show();

                actuallScore += addScore;

                if (actuallScore >= level * 100)
                {
                    do
                    {
                        actuallScore -= level * 100;

                        if (charSelect == "Kouzelnik")
                        {
                            actuallScore = 0;

                            playerScore.RemoveAt(selected);
                            playerScore.Insert(selected, actuallScore.ToString());

                            actuallScore += 300;
                        }

                        if (charSelect == "Alchymista" && level >= 10 || int.Parse(evolveP[selected]) >= 10)
                        {
                            woodCount += 50 + (level * 1);
                            stoneCount += 10 + (level * 1);
                            woolCount += 1 + (level * 1);
                        }

                        // playerLevelUp.controls.play();
                        if (!automat) MessageBox.Show("Získali jste nový level");

                        level++;
                        counterLevel++;
                        actuallMoney += addMoney;
                        actuallWoodCount += woodCount;
                        actuallStoneCount += stoneCount;
                        actuallWoolCount += woolCount;

                        countLevel.RemoveAt(selected);
                        countLevel.Insert(selected, counterLevel.ToString());

                        playerScore.RemoveAt(selected);
                        playerScore.Insert(selected, actuallScore.ToString());

                        playerMoney.RemoveAt(selected);
                        playerMoney.Insert(selected, actuallMoney.ToString());

                        wood.RemoveAt(selected);
                        wood.Insert(selected, actuallWoodCount.ToString());

                        stone.RemoveAt(selected);
                        stone.Insert(selected, actuallStoneCount.ToString());

                        wool.RemoveAt(selected);
                        wool.Insert(selected, actuallWoolCount.ToString());

                        remainTimeP.RemoveAt(selected);
                        remainTimeP.Insert(selected, "0");

                        playerLevel.RemoveAt(selected);
                        playerLevel.Insert(selected, level.ToString());

                        File.WriteAllLines("scoreP.txt", playerScore.ToArray());
                        File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
                        File.WriteAllLines("wood.txt", wood.ToArray());
                        File.WriteAllLines("stone.txt", stone.ToArray());
                        File.WriteAllLines("wool.txt", wool.ToArray());
                        File.WriteAllLines("remainTimeP.txt", remainTimeP.ToArray());
                        File.WriteAllLines("levelP.txt", playerLevel.ToArray());
                        File.WriteAllLines("countLevel.txt", countLevel.ToArray());
                    } while (actuallScore >= level * 100);
                }
                else
                {
                    // playerLevelUp.controls.stop();
                    actuallMoney += addMoney;
                    level = actuallLevel;
                    actuallWoodCount += woodCount;
                    actuallStoneCount += stoneCount;
                    actuallWoolCount += woolCount;

                    playerLevel.RemoveAt(selected);
                    playerLevel.Insert(selected, level.ToString());

                    playerScore.RemoveAt(selected);
                    playerScore.Insert(selected, actuallScore.ToString());

                    playerMoney.RemoveAt(selected);
                    playerMoney.Insert(selected, actuallMoney.ToString());

                    wood.RemoveAt(selected);
                    wood.Insert(selected, actuallWoodCount.ToString());

                    stone.RemoveAt(selected);
                    stone.Insert(selected, actuallStoneCount.ToString());

                    wool.RemoveAt(selected);
                    wool.Insert(selected, actuallWoolCount.ToString());

                    try
                    {
                        remainTimeP.RemoveAt(selected);
                        remainTimeP.Insert(selected, "0");
                    }
                    catch (Exception)
                    {
                    }

                    File.WriteAllLines("levelP.txt", playerLevel.ToArray());
                    File.WriteAllLines("scoreP.txt", playerScore.ToArray());
                    File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
                    File.WriteAllLines("wood.txt", wood.ToArray());
                    File.WriteAllLines("stone.txt", stone.ToArray());
                    File.WriteAllLines("wool.txt", wool.ToArray());
                    File.WriteAllLines("remainTimeP.txt", remainTimeP.ToArray());
                }

                if (automat)
                {
                    this.Close();
                    new Adventure().Show();
                }
            }
        }

        // Back Button
        private void backBTN_Click(object sender, EventArgs e)
        {
            List<string> eventChecker = new List<string>(File.ReadAllLines("eventChecker.txt"));
            List<string> remainTimeP = new List<string>(File.ReadAllLines("remainTimeP.txt"));

            List<string> autoplay = new List<string>(File.ReadAllLines("autoplay.txt"));
            bool auto = bool.Parse(autoplay[0]);

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            if (minute > 0)
            {
                while (minute > 0)
                {
                    timer += 60;
                    minute--;
                }
            }

            try
            {
                eventChecker.RemoveAt(0);
                eventChecker.Insert(0, reset.ToString());

                remainTimeP.RemoveAt(selected);
                remainTimeP.Insert(selected, timer.ToString());

                autoplay.RemoveAt(0);
                autoplay.Insert(0, "false");
            }
            catch (Exception)
            {
            }

            File.WriteAllLines("eventChecker.txt", eventChecker.ToArray());
            File.WriteAllLines("remainTimeP.txt", remainTimeP.ToArray());
            File.WriteAllLines("autoplay.txt", autoplay.ToArray());
            // playerLevelUp.controls.stop();
            this.Close();
        }

        private void Adventure_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Adventure.ModifierKeys == Keys.Alt || Adventure.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}