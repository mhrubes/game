using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.IO;

namespace MySFGameWindow
{
  public partial class RockScissorsPaperForm : Form
    {
        SourceClass source = new SourceClass();

        Random rnd = new Random();
        int chips;
        static int bet;
        string playerChoice;
        string computerChoice;
        int computer;

        public RockScissorsPaperForm()
        {
            InitializeComponent();

            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            timer1.Start();
            timer2.Stop();
            timer3.Stop();

            chips = int.Parse(playerMoney[selected]);
            chipLabel.Text = "Hráčovi zlaťáky: " + chips;

            rockBTN.Enabled = false;
            scissorsBTN.Enabled = false;
            paperBTN.Enabled = false;
            resultLabel.Hide();
            playerBet.Hide();
        }

        // Method On Get Bet
        public int getChips(int bet, int multiple) => bet * multiple;

        private void checkBTN_Click(object sender, EventArgs e)
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            chips = int.Parse(playerMoney[selected]);

            try
            {
                if (chipGetBox.Text != "")
                {
                    bet = int.Parse(chipGetBox.Text);
                    if (bet > 0 && bet <= chips)
                    {
                        chips -= bet;
                        checkBTN.Hide();
                        chipGetBox.Hide();
                        backBTN.Hide();

                        chipLabel.Text = "Hráčovi zlaťáky: " + chips;
                        playerBet.Text = "Sázka: " + bet;

                        int money = int.Parse(playerMoney[selected]) - bet;
                        playerMoney.RemoveAt(selected);
                        playerMoney.Insert(selected, money.ToString());
                        File.WriteAllLines("moneyP.txt", playerMoney.ToArray());

                        backBTN.Hide();
                        resultLabel.Text = "";
                        resultLabel.Hide();

                        playerBet.Show();

                        decisionMethod(true);
                    }
                    else MessageBox.Show("Špatné rozmezí");
                }
                else if (chipGetBox.Text == "") MessageBox.Show("Musíte zadat svoji sázku");
            }
            catch (Exception)
            {
                MessageBox.Show("Vyskytla se chyba. Zkuste to později");

                decisionMethod(false);
                backBTN.Show();

                int money = int.Parse(playerMoney[selected]) + bet;
                playerMoney.RemoveAt(selected);
                playerMoney.Insert(selected, money.ToString());
                File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
            }
        }

        private void decisionMethod(bool decision)
        {
            rockBTN.Enabled = decision;
            scissorsBTN.Enabled = decision;
            paperBTN.Enabled = decision;
        }

        private void timer1_Tick(object sender, EventArgs e) => chipLabel.Text = "Hráčovi zlaťáky: " + chips;

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            timer2.Stop();
            AIChoice();
            checkWinner();
        }

        private void rockBTN_Click(object sender, EventArgs e)
        {
            try
            {
                rockBTN.Enabled = false;

                playerPictureBox.Image = new Bitmap(source.source + source.folderName + @"\MySFGameWindow\pictures\rock.jpg");
                playerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                playerChoice = "kámen";

                timer3.Start();
                timer2.Start();
            }
            catch (Exception)
            {
                rescueMethod();
            }
        }

        private void scissorsBTN_Click(object sender, EventArgs e)
        {
            try
            {
                scissorsBTN.Enabled = false;

                playerPictureBox.Image = new Bitmap(source.source + source.folderName + @"\MySFGameWindow\pictures\scissors.jpg");
                playerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                playerChoice = "nůžky";

                timer3.Start();
                timer2.Start();
            }
            catch (Exception)
            {
                rescueMethod();
            }
        }

        private void paperBTN_Click(object sender, EventArgs e)
        {
            try
            {
                paperBTN.Enabled = false;

                playerPictureBox.Image = new Bitmap(source.source + source.folderName + @"\MySFGameWindow\pictures\paper.jpg");
                playerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                playerChoice = "papír";

                timer3.Start();
                timer2.Start();
            }
            catch (Exception)
            {
                rescueMethod();
            }
        }

        // Rescue Method If Image Missing
        private void rescueMethod()
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            MessageBox.Show("Vyskytla se chyba");

            decisionMethod(false);
            backBTN.Show();
            chipLabel.Hide();
            playerBet.Hide();

            rockBTN.Hide();
            scissorsBTN.Hide();
            paperBTN.Hide();
            label1.Hide();

            int money = int.Parse(playerMoney[selected]) + bet;
            playerMoney.RemoveAt(selected);
            playerMoney.Insert(selected, money.ToString());
            File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
        }

        public void AIChoice()
        {
            try
            {
                computer = rnd.Next(0, 2 + 1);
                for (int i = 0; i < 5; i++)
                {
                    switch (computer)
                    {
                        case 0:
                            aiPictureBox.Image = new Bitmap(source.source + source.folderName + @"\MySFGameWindow\pictures\rock.jpg");
                            aiPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            computerChoice = "kámen";
                            break;

                        case 1:
                            aiPictureBox.Image = new Bitmap(source.source + source.folderName + @"\MySFGameWindow\pictures\scissors.jpg");
                            aiPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            computerChoice = "nůžky";
                            break;

                        case 2:
                            aiPictureBox.Image = new Bitmap(source.source + source.folderName + @"\MySFGameWindow\pictures\paper.jpg");
                            aiPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            computerChoice = "papír";
                            break;
                    }
                }
            }
            catch (Exception)
            {
              rescueMethod();
            }
        }

        public void checkWinner()
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            if (playerChoice == "kámen")
            {
                if (playerChoice == "kámen" && computerChoice == "kámen") RemizaMethod(playerMoney, selected);
                if (playerChoice == "kámen" && computerChoice == "nůžky") VyhraMethod(playerMoney, selected);
                if (playerChoice == "kámen" && computerChoice == "papír") ProhraMethod();
            }

            else if (playerChoice == "nůžky")
            {
                if (playerChoice == "nůžky" && computerChoice == "nůžky") RemizaMethod(playerMoney, selected);
                if (playerChoice == "nůžky" && computerChoice == "papír") VyhraMethod(playerMoney, selected);
                if (playerChoice == "nůžky" && computerChoice == "kámen") ProhraMethod();
            }

            else
            {
                if (playerChoice == "papír" && computerChoice == "papír") RemizaMethod(playerMoney, selected);
                if (playerChoice == "papír" && computerChoice == "kámen") VyhraMethod(playerMoney, selected);
                if (playerChoice == "papír" && computerChoice == "nůžky") ProhraMethod();
            }
        }

        // Method If Lose
        private void ProhraMethod()
        {
            resultLabel.Text = "Prohráváte: " + bet;
            resultLabel.Show();

            chipGetBox.Text = "";
            playerBet.Text = "Sázka: 0";

            chipGetBox.Show();
            checkBTN.Show();
            backBTN.Show();
        }

        // Method If Win
        private void VyhraMethod(List<string> playerMoney, int selected)
        {
            bet = getChips(bet, 2);

            chips += bet;

            resultLabel.Text = "Vyhráváte: " + bet;
            resultLabel.Show();

            int actuallMoney = int.Parse(playerMoney[selected]) + bet;

            playerMoney.RemoveAt(selected);
            playerMoney.Insert(selected, actuallMoney.ToString());
            File.WriteAllLines("moneyP.txt", playerMoney.ToArray());

            chipGetBox.Text = "";
            playerBet.Text = "Sázka: 0";

            chipGetBox.Show();
            checkBTN.Show();
            backBTN.Show();
        }

        // Method If Draw
        private void RemizaMethod(List<string> playerMoney, int selected)
        {
            resultLabel.Text = "Remíza";
            resultLabel.Show();

            chips += bet;
            int actuallMoney = int.Parse(playerMoney[selected]) + bet;

            playerMoney.RemoveAt(selected);
            playerMoney.Insert(selected, actuallMoney.ToString());
            File.WriteAllLines("moneyP.txt", playerMoney.ToArray());

            chipGetBox.Text = "";
            playerBet.Text = "Sázka: 0";

            chipGetBox.Show();
            checkBTN.Show();
            backBTN.Show();
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            MiniGamesForm mini = new MiniGamesForm();
            mini.Show();
        }

        private void timer3_Tick(object sender, EventArgs e) => decisionMethod(false);

        private void chipGetBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != '.') errorStringMethod(e);
            else if (ch == '.') errorStringMethod(e);
        }

        public void errorStringMethod(KeyPressEventArgs e)
        {
            MessageBox.Show("Musíte zadat čísla");
            chipGetBox.Clear();
            e.Handled = true;
        }

        private void chipGetBox_TextChanged(object sender, EventArgs e)
        {
            string noSpace = chipGetBox.Text;

            try
            {
                if (noSpace[0] == '0')
                {
                    MessageBox.Show("Sázka nemůže začínat 0");
                    chipGetBox.Clear();
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void RockScissorsPaperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RockScissorsPaperForm.ModifierKeys == Keys.Alt || RockScissorsPaperForm.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}
