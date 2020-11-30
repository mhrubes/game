using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySFGameWindow
{
    public partial class LoginTrue : Form
    {
        public LoginTrue()
        {
            InitializeComponent();
        }

        int dir = 10;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bar.Value <= 40)
            {
                bar.Value += dir;

                if (bar.Value == 0 || bar.Value == 20 || bar.Value == 40) selectColorMethod(Color.SeaGreen, 20);
                else selectColorMethod(Color.DeepSkyBlue, 20);
            }
            if (bar.Value == 40)
            {
                this.Close();

                Inventory inventory = new Inventory();
                inventory.Show();

                Menu menu = new Menu();
                menu.Show();
                timer1.Stop();
            }
        }

        private void selectColorMethod(Color one, int number)
        {
            bar.ProgressColor = one;
            bar.animationIterval = number;
        }

        private void LoginTrue_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LoginTrue.ModifierKeys == Keys.Alt || LoginTrue.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}