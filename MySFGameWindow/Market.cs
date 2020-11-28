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
    public partial class Market : Form
    {
        List<string> sellOut = new List<string>(File.ReadAllLines("sell.txt"));
        List<string> selected = new List<string>(File.ReadAllLines("selectP.txt"));
        List<string> detailOrder = new List<string>(File.ReadAllLines("detailOrder.txt"));

        public Market()
        {
            InitializeComponent();
        }

        private void createOrderBTN_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (var item in sellOut)
            {
                string[] data = item.Split(';');
                if (data[1] == selected[0]) counter++;
            }

            if (counter <= 10)
            {
                CreateOrderWindow order = new CreateOrderWindow();
                order.Show();
                this.Close();
            }
            else MessageBox.Show("V aktuální době máte maximální počet vytvořených nabídek");
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        int SelectedIndex()
        {
            if (ProductList.SelectedIndices.Count > 0) return ProductList.SelectedIndices[0];
            else return 0;
        }

        private void ProductList_MouseClick(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
            {
                try
                {
                    string number = ProductList.SelectedItems[0].SubItems[0].Text;
                    using (StreamWriter sw = new StreamWriter("detailOrder.txt")) sw.WriteLine($"{number}");
                }
                catch (Exception)
                {
                }

                DetailOrderWindow detail = new DetailOrderWindow();
                detail.Show();
                this.Close();
            }
            else MessageBox.Show("Neprve musíte vypnout refresh nabídek");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check.Checked == true) myCheck.Enabled = false;
            else myCheck.Enabled = true;

            if (myCheck.Checked == true) check.Enabled = false;
            else check.Enabled = true;

            if (check.Checked == true && myCheck.Checked == false)
            {
                if (searchBox.Text == "" && searchBox.Text != "dřevo" && searchBox.Text != "kámen" && searchBox.Text != "vlna")
                {

                    ProductList.Clear();

                    ProductList.Columns.Add("číslo nabídky");
                    ProductList.Columns.Add("Typ");
                    ProductList.Columns.Add("Počet");
                    ProductList.Columns.Add("Cena za kus");

                    ProductList.Columns[0].Width = 102;
                    ProductList.Columns[1].Width = 60;
                    ProductList.Columns[2].Width = 210;
                    ProductList.Columns[3].Width = 210;

                    foreach (var item in sellOut)
                    {
                        try
                        {
                            string[] array = item.Split(';');
                            if (int.Parse(array[1]) != int.Parse(selected[0]))
                            {
                                string name = "";
                                if (array[2] == "drevo")
                                {
                                    name = "dřevo";
                                }
                                else if (array[2] == "kamen")
                                {
                                    name = "kámen";
                                }
                                else if (array[2] == "vlna")
                                {
                                    name = "vlna";
                                }

                                ListViewItem thing = new ListViewItem(array[0]);
                                thing.SubItems.Add(name);
                                thing.SubItems.Add(array[3]);
                                thing.SubItems.Add(array[4]);
                                ProductList.Items.Add(thing);
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                else if (searchBox.Text == "dřevo") showTrue("drevo");
                else if (searchBox.Text == "kámen") showTrue("kamen");
                else if (searchBox.Text == "vlna") showFalse("vlna");
            }

            else if (myCheck.Checked == true && check.Checked == false)
            {
                if (searchBox.Text == "" && searchBox.Text != "dřevo" && searchBox.Text != "kámen" && searchBox.Text != "vlna")
                {
                    ProductList.Clear();

                    ProductList.Columns.Add("číslo nabídky");
                    ProductList.Columns.Add("Typ");
                    ProductList.Columns.Add("Počet");
                    ProductList.Columns.Add("Cena za kus");

                    ProductList.Columns[0].Width = 102;
                    ProductList.Columns[1].Width = 60;
                    ProductList.Columns[2].Width = 210;
                    ProductList.Columns[3].Width = 210;

                    foreach (var item in sellOut)
                    {
                        try
                        {
                            string[] array = item.Split(';');
                            if (int.Parse(array[1]) == int.Parse(selected[0]))
                            {
                                string name = "";
                                if (array[2] == "drevo")
                                {
                                    name = "dřevo";
                                }
                                else if (array[2] == "kamen")
                                {
                                    name = "kámen";
                                }
                                else if (array[2] == "vlna")
                                {
                                    name = "vlna";
                                }

                                ListViewItem thing = new ListViewItem(array[0]);
                                thing.SubItems.Add(name);
                                thing.SubItems.Add(array[3]);
                                thing.SubItems.Add(array[4]);
                                ProductList.Items.Add(thing);
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                else if (searchBox.Text == "dřevo") showMyTrue("drevo");
                else if (searchBox.Text == "kámen") showMyTrue("kamen");
                else if (searchBox.Text == "vlna") showMyTrue("vlna");
            }
            else if (check.Checked == false && myCheck.Checked == false)
            {
                if (searchBox.Text == "" && searchBox.Text != "dřevo" && searchBox.Text != "kámen" && searchBox.Text != "vlna")
                {
                    try
                    {
                        ProductList.Clear();

                        ProductList.Columns.Add("číslo nabídky");
                        ProductList.Columns.Add("Typ");
                        ProductList.Columns.Add("Počet");
                        ProductList.Columns.Add("Cena za kus");

                        ProductList.Columns[0].Width = 102;
                        ProductList.Columns[1].Width = 60;
                        ProductList.Columns[2].Width = 210;
                        ProductList.Columns[3].Width = 210;

                        foreach (var item in sellOut)
                        {
                            string[] array = item.Split(';');

                            string name = "";
                            if (array[2] == "drevo")
                            {
                                name = "dřevo";
                            }
                            else if (array[2] == "kamen")
                            {
                                name = "kámen";
                            }
                            else if (array[2] == "vlna")
                            {
                                name = "vlna";
                            }

                            ListViewItem thing = new ListViewItem(array[0]);
                            thing.SubItems.Add(name);
                            thing.SubItems.Add(array[3]);
                            thing.SubItems.Add(array[4]);
                            ProductList.Items.Add(thing);
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                else if (searchBox.Text == "dřevo") showFalse("drevo");
                else if (searchBox.Text == "kámen") showFalse("kamen");
                else if (searchBox.Text == "vlna") showFalse("vlna");
            }
        }

        void showMyTrue(string text)
        {
            try
            {
                ProductList.Clear();

                ProductList.Columns.Add("číslo nabídky");
                ProductList.Columns.Add("Typ");
                ProductList.Columns.Add("Počet");
                ProductList.Columns.Add("Cena za kus");

                ProductList.Columns[0].Width = 102;
                ProductList.Columns[1].Width = 60;
                ProductList.Columns[2].Width = 210;
                ProductList.Columns[3].Width = 210;

                foreach (var item in sellOut)
                {
                    string[] array = item.Split(';');
                    if (int.Parse(array[1]) == int.Parse(selected[0]))
                    {
                        string name = "";
                        if (array[2] == text)
                        {
                            if (text == "drevo") name = "dřevo";
                            else if (text == "kamen") name = "kámen";
                            else if (text == "vlna") name = "vlna";

                            ListViewItem thing = new ListViewItem(array[0]);
                            thing.SubItems.Add(name);
                            thing.SubItems.Add(array[3]);
                            thing.SubItems.Add(array[4]);
                            ProductList.Items.Add(thing);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        void showTrue(string text)
        {
            try
            {
                ProductList.Clear();

                ProductList.Columns.Add("číslo nabídky");
                ProductList.Columns.Add("Typ");
                ProductList.Columns.Add("Počet");
                ProductList.Columns.Add("Cena za kus");

                ProductList.Columns[0].Width = 102;
                ProductList.Columns[1].Width = 60;
                ProductList.Columns[2].Width = 210;
                ProductList.Columns[3].Width = 210;

                foreach (var item in sellOut)
                {
                    string[] array = item.Split(';');
                    if (int.Parse(array[1]) != int.Parse(selected[0]))
                    {
                        string name = "";
                        if (array[2] == text)
                        {
                            if (text == "drevo") name = "dřevo";
                            else if (text == "kamen") name = "kámen";
                            else if (text == "vlna") name = "vlna";

                            ListViewItem thing = new ListViewItem(array[0]);
                            thing.SubItems.Add(name);
                            thing.SubItems.Add(array[3]);
                            thing.SubItems.Add(array[4]);
                            ProductList.Items.Add(thing);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        void showFalse(string text)
        {
            try
            {
                ProductList.Clear();

                ProductList.Columns.Add("číslo nabídky");
                ProductList.Columns.Add("Typ");
                ProductList.Columns.Add("Počet");
                ProductList.Columns.Add("Cena za kus");

                ProductList.Columns[0].Width = 102;
                ProductList.Columns[1].Width = 60;
                ProductList.Columns[2].Width = 210;
                ProductList.Columns[3].Width = 210;

                foreach (var item in sellOut)
                {
                    string[] array = item.Split(';');
                    string name = "";
                    if (array[2] == text)
                    {
                        if (text == "drevo") name = "dřevo";
                        else if (text == "kamen") name = "kámen";
                        else if (text == "vlna") name = "vlna";

                        ListViewItem thing = new ListViewItem(array[0]);
                        thing.SubItems.Add(name);
                        thing.SubItems.Add(array[3]);
                        thing.SubItems.Add(array[4]);
                        ProductList.Items.Add(thing);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void stopBTN_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                pictureBoxIsActive.BackColor = Color.Red;

                check.Enabled = false;
                myCheck.Enabled = false;
            }
            else
            {
                timer1.Start();
                pictureBoxIsActive.BackColor = Color.LawnGreen;

                check.Enabled = true;
                myCheck.Enabled = true;
            }
        }

        private void Market_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Market.ModifierKeys == Keys.Alt || Market.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}