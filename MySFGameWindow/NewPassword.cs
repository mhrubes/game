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
    public partial class NewPassword : Form
    {
        public NewPassword()
        {
            InitializeComponent();
        }

        // Set New Password Button
        private void setNewPasswordBTN_Click(object sender, EventArgs e)
        {
            List<string> playerPassword = new List<string>(File.ReadAllLines("passwordP.txt"));
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));

            int selected = int.Parse(playerSelect[0]);

            string oldPassword = oldPasswordBOX.Text;
            string newPassword = newPasswordBOX.Text;

            var decrypt = "";
            try
            {
              decrypt = SecurePasswordHasher.Decrypt(playerPassword[selected]);
            }
            catch (Exception)
            {
            }

            if (decrypt == oldPassword)
            {
                if (newPassword != "" && newPassword != decrypt)
                {
                    var encrypt = SecurePasswordHasher.Encrypt(newPassword);

                    playerPassword.RemoveAt(selected);
                    playerPassword.Insert(selected, encrypt);

                    File.WriteAllLines("passwordP.txt", playerPassword.ToArray());

                    MessageBox.Show("Heslo bylo změněno");
                    this.Hide();
                    Stat stat = new Stat();
                    stat.Show();
                }
                else
                {
                    MessageBox.Show("Zadejte jiné heslo");
                    oldPasswordBOX.Text = "";
                    newPasswordBOX.Text = "";
                }
            }
            else MessageBox.Show("Aktuální heslo není zadáno správně");
        }

        // Back Button
        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stat stat = new Stat();
            stat.Show();
        }

        private void NewPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NewPassword.ModifierKeys == Keys.Alt || NewPassword.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}