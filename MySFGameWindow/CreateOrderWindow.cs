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
    public partial class CreateOrderWindow : Form
    {
        List<string> sellOut = new List<string>(File.ReadAllLines("sell.txt"));
        List<string> selected = new List<string>(File.ReadAllLines("selectP.txt"));

        List<string> wood = new List<string>(File.ReadAllLines("wood.txt"));
        List<string> stone = new List<string>(File.ReadAllLines("stone.txt"));
        List<string> wool = new List<string>(File.ReadAllLines("wool.txt"));

        public CreateOrderWindow()
        {
            InitializeComponent();

            createOrderBTN.Enabled = false;
            countLabel.Hide();
            TypeBox.Items.AddRange(new object[] { "dřevo", "kámen", "vlna" });
        }

        int number(List<int> list)
        {
            int cont = 1;
            while (list.Contains(cont)) cont++;
            return cont;
        }

        private void createOrderBTN_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            foreach (var item in sellOut)
            {
                string[] data = item.Split(';');
                list.Add(int.Parse(data[0]));
            }

            if (TypeBox.Text == "dřevo") sellOut.Add($"{number(list)};{selected[0]};drevo;{countBox.Text};{priceBox.Text}");
            else if (TypeBox.Text == "kámen") sellOut.Add($"{number(list)};{selected[0]};kamen;{countBox.Text};{priceBox.Text}");
            else if (TypeBox.Text == "vlna") sellOut.Add($"{number(list)};{selected[0]};vlna;{countBox.Text};{priceBox.Text}");
            File.WriteAllLines("sell.txt", sellOut.ToArray());

            int typeCount = int.Parse(countLabel.Text);
            typeCount -= int.Parse(countBox.Text);

            if (TypeBox.Text == "dřevo")
            {
                wood.Insert(int.Parse(selected[0]), typeCount.ToString());
                wood.RemoveAt(int.Parse(selected[0]) + 1);
                File.WriteAllLines("wood.txt", wood.ToArray());
            }
            else if (TypeBox.Text == "kámen")
            {
                stone.Insert(int.Parse(selected[0]), typeCount.ToString());
                stone.RemoveAt(int.Parse(selected[0]) + 1);
                File.WriteAllLines("stone.txt", stone.ToArray());
            }
            else if (TypeBox.Text == "vlna")
            {
                wool.Insert(int.Parse(selected[0]), typeCount.ToString());
                wool.RemoveAt(int.Parse(selected[0]) + 1);
                File.WriteAllLines("wool.txt", wool.ToArray());
            }

            Market market = new Market();
            market.Show();
            this.Close();
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            Market market = new Market();
            market.Show();
            this.Close();
        }

        void Show(List<string> list, List<string> select)
        {
            countLabel.Text = list[int.Parse(select[0])];
            countLabel.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (TypeBox.Text == "dřevo") Show(wood, selected);
            else if (TypeBox.Text == "kámen") Show(stone, selected);
            else if (TypeBox.Text == "vlna") Show(wool, selected);
            else countLabel.Hide();

            try
            {
                if (TypeBox.Text != "" && int.Parse(countLabel.Text) >= int.Parse(countBox.Text) && priceBox.Text != "") createOrderBTN.Enabled = true;
                else createOrderBTN.Enabled = false;
            }
            catch (Exception)
            {
            }
        }

        private void TypeBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        private void countBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != '.') errorStringMethod(e);
            else if (ch == '.') errorStringMethod(e);
        }

        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != '.') errorStringMethod(e);
            else if (ch == '.') errorStringMethod(e);
        }

        void errorStringMethod(KeyPressEventArgs e) => e.Handled = true;

        private void countBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (countBox.Text[0] == ' ') countBox.Clear();
                else if (countBox.Text[0] == '0') countBox.Clear();
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (priceBox.Text[0] == ' ') priceBox.Clear();
                else if (priceBox.Text[0] == '0') priceBox.Clear();
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void CreateOrderWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CreateOrderWindow.ModifierKeys == Keys.Alt || CreateOrderWindow.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}