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
    public partial class GloryFloor : Form
    {
        int counter = 1;

        public GloryFloor()
        {
            InitializeComponent();

            List<string> playerName = new List<string>(File.ReadAllLines("nameP.txt"));
            List<string> playerFloor = new List<string>(File.ReadAllLines("floorP.txt"));

            List<int> floorList = new List<int>();
            for (int i = 0; i < playerFloor.Count; i++) floorList.Add(int.Parse(playerFloor[i]));

            Dictionary<string, int> diction = new Dictionary<string, int>();
            for (int i = 0; i < playerName.Count; i++)
            {
                try
                {
                    diction.Add(playerName[i], floorList[i]);
                }
                catch (Exception)
                {
                }
            }

            // ----------------------------------------------------------------------------------

            var items = from pair in diction orderby pair.Value descending select pair;

            foreach (KeyValuePair<string, int> pair in items)
            {
                if (counter <= 3) gloryListBox.Items.Add($"{counter}. {pair.Key}");
                else gloryListBox.Items.Add($"    {pair.Key}");
                if (pair.Value >= 10) listBox1.Items.Add($"{pair.Value}");
                else listBox1.Items.Add($"{pair.Value}    ");
                counter++;
            }
        }

        // Back Button
        private void backToMenuBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Glory menu = new Glory();
            menu.Show();
        }

        private void GloryFloor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GloryFloor.ModifierKeys == Keys.Alt || GloryFloor.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}
