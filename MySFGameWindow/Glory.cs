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
    public partial class Glory : Form
    {
        public Glory() => InitializeComponent();

        // Back Button
        private void backToMenuBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        // Level Button
        private void levelBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            GloryLevel gloryLevel = new GloryLevel();
            gloryLevel.Show();
        }

        // Floor Button
        private void floorBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            GloryFloor gloryFloor = new GloryFloor();
            gloryFloor.Show();
        }

        private void Glory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Glory.ModifierKeys == Keys.Alt || Glory.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}