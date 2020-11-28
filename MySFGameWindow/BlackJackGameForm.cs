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
    public partial class BlackJackGameForm : Form
    {
        static int chips;
        static Deck deck;
        static List<Card> userHand;
        static List<Card> dealerHand;

        // Variables
        static int totalCard = 0;
        static int totalCardDealer = 0;
        static int bet;
        static int aceTotal = 0;

        // Hide Components On Start Game
        public void allHide()
        {
            chipLabel.Hide();
            cardInDeckLabel.Hide();
            totalLabel.Hide();
            userListBox.Hide();
            checkBTN.Hide();
            chipGetBox.Hide();
            hitBTN.Hide();
            standBTN.Hide();
            resultLabel.Hide();
            newGameBTN.Hide();
            betLabel.Hide();
            dealerListBox.Hide();
            totalDealerLabel.Hide();
            closeAppBTN.Hide();
            closeBTN.Hide();
            giveUpBTN.Hide();
            doubleBTN.Hide();
        }

        // Hide Components If Lose
        public void hideIfLose()
        {
            newGameBTN.Hide();
            chipLabel.Hide();
            cardInDeckLabel.Hide();
            totalLabel.Hide();
            totalDealerLabel.Hide();
            userListBox.Hide();
            dealerListBox.Hide();
            checkBTN.Hide();
            chipGetBox.Hide();
            hitBTN.Hide();
            standBTN.Hide();
            resultLabel.Hide();
            betLabel.Hide();
            giveUpBTN.Hide();
            doubleBTN.Hide();

            closeAppBTN.Show();
        }

        // Method On Get Bet
        public int getChips(int bet, int multiple) => bet * multiple;

        public BlackJackGameForm()
        {
            InitializeComponent();

            totalCard = 0;
            totalCardDealer = 0;
            aceTotal = 0;


            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            timer1.Start();
            timer2.Stop();

            allHide();

            chips = int.Parse(playerMoney[selected]);
            chipLabel.Text = "";

            deck = new Deck();
            deck.Shuffle();
        }

        private void BlackJackGameForm_Shown(object sender, EventArgs e) => MessageBox.Show("Vítejte v Blackjack");

        private void startBTN_Click(object sender, EventArgs e)
        {
            startBTN.Hide();
            checkBTN.Show();
            chipGetBox.Show();
            chipLabel.Show();
            closeBTN.Show();
        }

        // Check Button
        private void checkBTN_Click(object sender, EventArgs e)
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            if (chipGetBox.Text != "")
            {
                closeBTN.Hide();
                bet = int.Parse(chipGetBox.Text);

                int original = chips;
                if (bet > 0 && bet <= chips)
                {
                    chips = chips - bet;
                    checkBTN.Hide();
                    chipGetBox.Hide();

                    int res = bet * 2;
                    if (original > res) doubleBTN.Show();


                    int money = int.Parse(playerMoney[selected]) - bet;
                    playerMoney.RemoveAt(selected);
                    playerMoney.Insert(selected, money.ToString());
                    File.WriteAllLines("moneyP.txt", playerMoney.ToArray());

                    cardInDeckLabel.Show();
                    userListBox.Show();
                    dealerListBox.Show();
                    totalLabel.Show();
                    betLabel.Show();

                    hitBTN.Show();
                    standBTN.Show();
                    giveUpBTN.Show();

                    userHand = new List<Card>();
                    userHand.Add(deck.DrawACard());
                    userHand.Add(deck.DrawACard());

                    foreach (Card card in userHand) userListBox.Items.Add($"{card.face} {card.suit}");
                    if (userHand[0].face == Face.Ace || userHand[1].face == Face.Ace)
                    {
                        DialogResult dialog = MessageBox.Show("Eso za 11?", "Zpět", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes) aceTotal += 10;
                    }

                    dealerHand = new List<Card>();
                    dealerHand.Add(deck.DrawACard());
                    dealerHand.Add(deck.DrawACard());

                    if (dealerHand[0].Value == 10 && dealerHand[1].face == Face.Ace) totalCardDealer += 10;
                    else if (dealerHand[1].Value == 10 && dealerHand[0].face == Face.Ace) totalCardDealer += 10;

                    dealerListBox.Items.Add($"{dealerHand[0].face} {dealerHand[0].suit}");
                    dealerListBox.Items.Add("?");

                    cardInDeckLabel.Text = "Karet v balíčku: " + deck.GetAmountOfRemainingCrads();

                    foreach (Card card in userHand) totalCard += card.Value;

                    totalCard += aceTotal;
                    totalLabel.Text = $"Součet: {totalCard}";
                }
                else MessageBox.Show("Špatné rozmezí");
            }
            else if (chipGetBox.Text == "") MessageBox.Show("Musíte zadat svoji sázku");
        }

        // Hit Button
        private void hitBTN_Click(object sender, EventArgs e)
        {
            giveUpBTN.Hide();
            doubleBTN.Hide();

            userHand.Add(deck.DrawACard());

            userListBox.Items.Clear();
            foreach (Card card in userHand) userListBox.Items.Add($"{card.face} {card.suit}");

            totalCard = 0;
            foreach (Card card in userHand) totalCard += card.Value;

            totalCard += aceTotal;

            if (totalCard > 21)
            {
                doubleBTN.Hide();
                hitBTN.Hide();
                standBTN.Hide();

                if (chips > 0)
                {
                    giveUpBTN.Hide();

                    resultLabel.Show();
                    resultLabel.Text = "Prohráli jste";

                    newGameBTN.Show();
                }
                else
                {
                    MessageBox.Show("Konec Hry");
                    // Method Up In Program
                    hideIfLose();
                }
            }
        }

        // Stand Button
        private void standBTN_Click(object sender, EventArgs e)
        {
            hitBTN.Hide();
            standBTN.Hide();
            giveUpBTN.Hide();
            doubleBTN.Hide();

            dealerListBox.Items.Clear();
            foreach (Card card in dealerHand) dealerListBox.Items.Add($"{card.face} {card.suit}");
            foreach (Card card in dealerHand) totalCardDealer += card.Value;

            totalDealerLabel.Show();
            timer2.Start();
        }

        // Give Round Button
        private void giveUpBTN_Click(object sender, EventArgs e)
        {
            chips += bet / 2;

            giveUpBTN.Hide();
            chipGetBox.Clear();
            chipLabel.Show();
            cardInDeckLabel.Show();
            totalLabel.Hide();
            totalDealerLabel.Hide();
            userListBox.Hide();
            dealerListBox.Hide();
            checkBTN.Show();
            chipGetBox.Show();
            hitBTN.Hide();
            standBTN.Hide();
            resultLabel.Hide();
            betLabel.Hide();
            doubleBTN.Hide();
            closeBTN.Show();

            bet = 0;
            totalCardDealer = 0;
            totalCard = 0;
            userListBox.Items.Clear();
            dealerListBox.Items.Clear();

            newGameBTN.Hide();
        }

        // Double Bet Button
        private void doubleBTN_Click(object sender, EventArgs e)
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            hitBTN.Hide();
            standBTN.Hide();
            giveUpBTN.Hide();
            doubleBTN.Hide();

            int actuallMoney = int.Parse(playerMoney[selected]) + bet;

            playerMoney.RemoveAt(selected);
            playerMoney.Insert(selected, actuallMoney.ToString());
            File.WriteAllLines("moneyP.txt", playerMoney.ToArray());

            chips += bet;
            chips -= getChips(bet, 2);
            bet *= 2;

            int actuallMoneyAfter = int.Parse(playerMoney[selected]) - bet;

            playerMoney.RemoveAt(selected);
            playerMoney.Insert(selected, actuallMoneyAfter.ToString());
            File.WriteAllLines("moneyP.txt", playerMoney.ToArray());

            userHand.Add(deck.DrawACard());

            userListBox.Items.Clear();
            foreach (Card card in userHand) userListBox.Items.Add($"{card.face} {card.suit}");

            totalCard = 0;
            foreach (Card card in userHand) totalCard += card.Value;

            if (userHand[2].face == Face.Ace)
            {
                DialogResult dialog = MessageBox.Show("Eso za 11?", "Zpět", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes) aceTotal += 10;
            }
            else
            {
                totalCard = 0;
                foreach (Card card in userHand) totalCard += card.Value;
            }

            totalCard += aceTotal;

            if (totalCard > 21)
            {
                resultLabel.Show();
                resultLabel.Text = "You Lose";

                newGameBTN.Show();
            }
            else
            {
                dealerListBox.Items.Clear();
                foreach (Card card in dealerHand) dealerListBox.Items.Add($"{card.face} {card.suit}");
                foreach (Card card in dealerHand) totalCardDealer += card.Value;

                totalDealerLabel.Show();
                timer2.Start();
            }
        }

        // New Game/Round Button
        private void newGameBTN_Click(object sender, EventArgs e)
        {
            if (chips != 0)
            {
                chipGetBox.Clear();
                newGameBTN.Hide();
                chipLabel.Show();
                cardInDeckLabel.Show();
                totalLabel.Hide();
                totalDealerLabel.Hide();
                userListBox.Hide();
                dealerListBox.Hide();
                doubleBTN.Hide();
                checkBTN.Show();
                chipGetBox.Show();
                hitBTN.Hide();
                standBTN.Hide();
                resultLabel.Hide();
                betLabel.Hide();
                closeBTN.Show();

                bet = 0;
                aceTotal = 0;
                totalCard = 0;
                totalCardDealer = 0;
                userListBox.Items.Clear();
                dealerListBox.Items.Clear();
            }
            else
            {
                MessageBox.Show("Konec Hry");
                // Method Up In Program
                hideIfLose();
            }
        }

        // Timer Works All Time
        private void timer1_Tick(object sender, EventArgs e)
        {
            cardInDeckLabel.Text = "Karet v balíčku: " + deck.GetAmountOfRemainingCrads();
            totalLabel.Text = $"Součet: {totalCard}";
            totalDealerLabel.Text = $"Součet: {totalCardDealer}";
            chipLabel.Text = "Hráčovi žetony: " + chips;
            betLabel.Text = "Sázka: " + bet;
        }

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
                    MessageBox.Show("Sázka nemůže začínat '0'");
                    chipGetBox.Clear();
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        // Timer Ends If Dealer Has Over 17 Points
        private void timer2_Tick(object sender, EventArgs e)
        {
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            if (totalCardDealer >= 17)
            {
                timer2.Stop();
                doubleBTN.Hide();
                betLabel.Hide();

                if (totalCardDealer > 21)
                {
                    if (userHand.Count == 2 && totalCard == 21 && (userHand[0].face == Face.Ace || userHand[1].face == Face.Ace))
                    {
                        MessageBox.Show("BlackJack, Vyhráli jste *3");
                        // Method In Up Program
                        bet = getChips(bet, 3);
                    }
                    else bet = getChips(bet, 2);

                    chips += bet;

                    resultLabel.Show();
                    resultLabel.Text = "Vyhráli jste: " + bet;

                    int actuallMoney = int.Parse(playerMoney[selected]) + bet;

                    playerMoney.RemoveAt(selected);
                    playerMoney.Insert(selected, actuallMoney.ToString());
                    File.WriteAllLines("moneyP.txt", playerMoney.ToArray());

                    newGameBTN.Show();
                }
                else if (totalCardDealer == totalCard)
                {
                    chips += bet;

                    resultLabel.Show();
                    resultLabel.Text = "Remíza";

                    int actuallMoney = int.Parse(playerMoney[selected]) + bet;

                    playerMoney.RemoveAt(selected);
                    playerMoney.Insert(selected, actuallMoney.ToString());
                    File.WriteAllLines("moneyP.txt", playerMoney.ToArray());

                    newGameBTN.Show();
                }
                else if (totalCardDealer < totalCard)
                {
                    if (userHand.Count == 2 && totalCard == 21 && (userHand[0].face == Face.Ace || userHand[1].face == Face.Ace))
                    {
                        MessageBox.Show("BlackJack, Vyhráli jste *3");
                        // Method In Up Program
                        bet = getChips(bet, 3);
                    }
                    else bet = getChips(bet, 2);

                    chips += bet;

                    resultLabel.Show();
                    resultLabel.Text = "Vyhráli jste: " + bet;

                    int actuallMoney = int.Parse(playerMoney[selected]) + bet;

                    playerMoney.RemoveAt(selected);
                    playerMoney.Insert(selected, actuallMoney.ToString());
                    File.WriteAllLines("moneyP.txt", playerMoney.ToArray());

                    newGameBTN.Show();
                }
                else if (totalCardDealer > totalCard)
                {
                    resultLabel.Show();
                    resultLabel.Text = "Prohráli jste";

                    if (chips > 0) newGameBTN.Show();
                    else
                    {
                        totalCard = 0;
                        totalCardDealer = 0;
                        aceTotal = 0;

                        MessageBox.Show("Konec hry");

                        newGameBTN.Hide();
                        chipLabel.Hide();
                        cardInDeckLabel.Hide();
                        totalLabel.Hide();
                        totalDealerLabel.Hide();
                        userListBox.Hide();
                        dealerListBox.Hide();
                        checkBTN.Hide();
                        chipGetBox.Hide();
                        hitBTN.Hide();
                        standBTN.Hide();
                        resultLabel.Hide();
                        betLabel.Hide();
                        doubleBTN.Hide();

                        closeAppBTN.Show();
                    }
                }
            }
            else
            {
                dealerHand.Add(deck.DrawACard());

                dealerListBox.Items.Clear();
                foreach (Card card in dealerHand) dealerListBox.Items.Add($"{card.face} {card.suit}");

                totalCardDealer = 0;
                foreach (Card card in dealerHand) totalCardDealer += card.Value;
            }
        }

        // Close Button
        private void closeAppBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            MiniGamesForm mini = new MiniGamesForm();
            mini.Show();
        }

        // Close Button
        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            MiniGamesForm mini = new MiniGamesForm();
            mini.Show();
        }

        private void BlackJackGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BlackJackGameForm.ModifierKeys == Keys.Alt || BlackJackGameForm.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}
