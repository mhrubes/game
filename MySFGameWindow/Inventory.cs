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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<string> money = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> wood = new List<string>(File.ReadAllLines("wood.txt"));
            List<string> stone = new List<string>(File.ReadAllLines("stone.txt"));
            List<string> wool = new List<string>(File.ReadAllLines("wool.txt"));
            List<string> selected = new List<string>(File.ReadAllLines("selectP.txt"));

            try
            {
                woodLabel.Text = wood[int.Parse(selected[0])];
                stoneLabel.Text = stone[int.Parse(selected[0])];
                woolLabel.Text = wool[int.Parse(selected[0])];
                moneyLabel.Text = money[int.Parse(selected[0])];
            }
            catch (Exception)
            {
            }
        }
    }
}