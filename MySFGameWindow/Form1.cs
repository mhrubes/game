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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            rating.Value = 5;
            rating.Enabled = false;
            timer1.Start();
        }

        int time = 5;
        // Timer tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time != 0) time--;
            if (time == 0)
            {
                timer1.Stop();
                this.Hide();
                SelectForm select = new SelectForm();
                select.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Form1.ModifierKeys == Keys.Alt || Form1.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}