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
    public partial class DetailOrderWindow : Form
    {
        public DetailOrderWindow()
        {
            InitializeComponent();

            label1.Hide();

            countBox.Hide();
            countTrack.Hide();
            countLabel.Hide();
            timer1.Stop();

            minus.Hide();
            plus.Hide();
            label4.Hide();
            label5.Hide();
            fullPrice.Hide();

            List<string> sell = new List<string>(File.ReadAllLines("sell.txt"));
            List<string> selected = new List<string>(File.ReadAllLines("selectP.txt"));
            List<string> detail = new List<string>(File.ReadAllLines("detailOrder.txt"));

            try
            {
                foreach (var item in sell)
                {
                    string[] data = item.Split(';');

                    if (int.Parse(data[0]) == int.Parse(detail[0]))
                    {
                        if (data[2] == "drevo") TypeBox.Text = "dřevo";
                        else if (data[2] == "kamen") TypeBox.Text = "kámen";
                        else if (data[2] == "vlna") TypeBox.Text = "vlna";

                        countTrack.Minimum = 1;
                        countTrack.Maximum = int.Parse(data[3]);
                        countBox.Text = data[3];
                        priceBox.Text = data[4];

                        if (int.Parse(selected[0]) == int.Parse(data[1]))
                        {
                            label1.Show();
                            countBox.Show();
                            workBTN.Text = "Odebrat nabídku";
                        }
                        else
                        {
                            countTrack.Show();
                            countLabel.Show();
                            minus.Show();
                            plus.Show();
                            minus.Show();
                            plus.Show();
                            label4.Show();
                            label5.Show();
                            fullPrice.Show();
                            workBTN.Text = "Koupit";
                            timer1.Start();
                        }

                        break;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        void getResources(int buyerId, List<string> type, string text)
        {
            int Count = int.Parse(type[buyerId]);
            Count += countTrack.Value;

            type.RemoveAt(buyerId);
            type.Insert(buyerId, Count.ToString());
            File.WriteAllLines(text, type.ToArray());
        }

        private void workBTN_Click(object sender, EventArgs e)
        {
            if (workBTN.Text == "Koupit")
            {
                int sellerId = 0;
                double sellerMoney = 0;

                int buyerId = 0;
                double buyerMoney = 0;

                List<string> sell = new List<string>(File.ReadAllLines("sell.txt"));
                List<string> wood = new List<string>(File.ReadAllLines("wood.txt"));
                List<string> stone = new List<string>(File.ReadAllLines("stone.txt"));
                List<string> wool = new List<string>(File.ReadAllLines("wool.txt"));
                List<string> detail = new List<string>(File.ReadAllLines("detailOrder.txt"));
                List<string> selected = new List<string>(File.ReadAllLines("selectP.txt"));
                List<string> moneyP = new List<string>(File.ReadAllLines("moneyP.txt"));

                buyerId = int.Parse(selected[0]);

                foreach (var item in sell)
                {
                    string[] data = item.Split(';');
                    if (data[0] == detail[0])
                    {
                        sellerId = int.Parse(data[1]);
                        sellerMoney = double.Parse(moneyP[sellerId]);
                        break;
                    }
                }

                buyerMoney = double.Parse(moneyP[buyerId]);

                if (buyerMoney >= double.Parse(fullPrice.Text))
                {
                    try
                    {
                        sellerMoney += double.Parse(fullPrice.Text);
                        buyerMoney -= double.Parse(fullPrice.Text);

                        moneyP.RemoveAt(sellerId);
                        moneyP.Insert(sellerId, sellerMoney.ToString());

                        moneyP.RemoveAt(buyerId);
                        moneyP.Insert(buyerId, buyerMoney.ToString());
                        File.WriteAllLines("moneyP.txt", moneyP.ToArray());

                        if (TypeBox.Text == "dřevo") getResources(buyerId, wood, "wood.txt");
                        else if (TypeBox.Text == "kámen") getResources(buyerId, stone, "stone.txt");
                        else if (TypeBox.Text == "vlna") getResources(buyerId, wool, "wool.txt");

                        int counter = 0;
                        foreach (var item in sell)
                        {
                            string[] data = item.Split(';');
                            if (data[0] == detail[0])
                            {
                                string idSell = data[0];
                                string idPlayer = data[1];
                                string type = data[2];
                                int countNumber = int.Parse(data[3]);
                                string priceNumber = data[4];

                                int getNumber = countNumber - countTrack.Value;

                                if (getNumber != 0)
                                {
                                    sell.RemoveAt(counter);
                                    sell.Insert(counter, $"{idSell};{idPlayer};{type};{getNumber};{priceNumber}");
                                    File.WriteAllLines("sell.txt", sell.ToArray());
                                }
                                else
                                {
                                    sell.RemoveAt(counter);
                                    File.WriteAllLines("sell.txt", sell.ToArray());
                                }

                                break;
                            }
                            counter++;
                        }

                        MessageBox.Show("Nákup byl úspěšný");
                        this.Close();
                        Market market = new Market();
                        market.Show();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.ToString());
                        this.Close();
                        Market market = new Market();
                        market.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Nemáte dostatek prostředků");
                    this.Close();
                    Market market = new Market();
                    market.Show();
                }
            }
            else if (workBTN.Text == "Odebrat nabídku")
            {
                List<string> sell = new List<string>(File.ReadAllLines("sell.txt"));
                List<string> wood = new List<string>(File.ReadAllLines("wood.txt"));
                List<string> stone = new List<string>(File.ReadAllLines("stone.txt"));
                List<string> wool = new List<string>(File.ReadAllLines("wool.txt"));
                List<string> detail = new List<string>(File.ReadAllLines("detailOrder.txt"));
                List<string> selected = new List<string>(File.ReadAllLines("selectP.txt"));

                int counter = 0;
                foreach (var item in sell)
                {
                    string[] data = item.Split(';');

                    if (data[0] == detail[0])
                    {
                        sell.RemoveAt(counter);
                        File.WriteAllLines("sell.txt", sell.ToArray());
                        break;
                    }
                    counter++;
                }

                if (TypeBox.Text == "dřevo")
                {
                    saveCount(wood, selected, "wood.txt");
                }
                else if (TypeBox.Text == "kámen")
                {
                    saveCount(stone, selected, "stone.txt");
                }
                else if (TypeBox.Text == "vlna")
                {
                    saveCount(wool, selected, "wool.txt");
                }

                this.Close();
                Market market = new Market();
                market.Show();
            }
        }

        void saveCount(List<string> type, List<string> selected, string text)
        {
            int actuallType = int.Parse(type[int.Parse(selected[0])]);
            int typeCount = int.Parse(countBox.Text);

            actuallType += typeCount;

            type.RemoveAt(int.Parse(selected[0]));
            type.Insert(int.Parse(selected[0]), actuallType.ToString());

            File.WriteAllLines(text, type.ToArray());
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            Market market = new Market();
            market.Show();
            this.Close();
        }

        private void DetailOrderWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DetailOrderWindow.ModifierKeys == Keys.Alt || DetailOrderWindow.ModifierKeys == Keys.F4) e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countLabel.Text = countTrack.Value.ToString();

            fullPrice.Text = (int.Parse(priceBox.Text) * countTrack.Value).ToString();

            if (countTrack.Value == 1) minus.Enabled = false;
            else minus.Enabled = true;
            if (countTrack.Value == countTrack.Maximum) plus.Enabled = false;
            else plus.Enabled = true;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            try
            {
                countTrack.Value++;
            }
            catch (Exception)
            {

            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            try
            {
                countTrack.Value--;
            }
            catch (Exception)
            {
            }
        }
    }
}