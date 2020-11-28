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
    public partial class GloryLevel : Form
    {
        int counter = 1;

        public GloryLevel()
        {
            InitializeComponent();
            
            List<string> playerName = new List<string>(File.ReadAllLines("nameP.txt"));
            List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));

            List<int> levelList = new List<int>();
            for (int i = 0; i < playerLevel.Count; i++) levelList.Add(int.Parse(playerLevel[i]));

            Dictionary<string, int> diction = new Dictionary<string, int>();
            for (int i = 0; i < playerName.Count; i++) diction.Add(playerName[i], levelList[i]);

            // ----------------------------------------------------------------------------------

            var items = from pair in diction orderby pair.Value descending select pair;

            foreach (KeyValuePair<string, int> pair in items)
            {
                if(counter <= 3) gloryListBox.Items.Add($"{counter}. {pair.Key}");
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

        private void GloryLevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GloryLevel.ModifierKeys == Keys.Alt || GloryLevel.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}