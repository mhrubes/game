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
    public partial class DeletePlayer : Form
    {
        SourceClass source = new SourceClass();
        public DeletePlayer()
        {
            InitializeComponent();
        }

        int getIndex()
        {
            List<string> playerList = new List<string>(File.ReadAllLines("nameP.txt"));
            int counter = 0;

            foreach (var item in playerList)
            {
                if (nameBOX.Text == item) break;
                counter++;
            }

            return counter;
        }

        // Delete Button
        private void deleteBTN_Click(object sender, EventArgs e)
        {
            List<string> playerName = new List<string>(File.ReadAllLines("nameP.txt"));
            if (playerName.Contains(nameBOX.Text))
            {
                DialogResult dialog = MessageBox.Show("Opravdu Chcete SMAZAT tento účet?", "Zpět", MessageBoxButtons.YesNo);

                string name = nameBOX.Text;
                string password = passwordBOX.Text;

                List<string> playerPassword = new List<string>(File.ReadAllLines("passwordP.txt"));
                List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
                List<string> playerScore = new List<string>(File.ReadAllLines("scoreP.txt"));
                List<string> playerLastLog = new List<string>(File.ReadAllLines("lastLogP.txt"));
                List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));
                List<string> playerMush = new List<string>(File.ReadAllLines("mushP.txt"));
                List<string> playerPower = new List<string>(File.ReadAllLines("powerP.txt"));
                List<string> playerFloor = new List<string>(File.ReadAllLines("floorP.txt"));
                List<string> remainTimeP = new List<string>(File.ReadAllLines("remainTimeP.txt"));
                List<string> bossHP = new List<string>(File.ReadAllLines("bossHP.txt"));
                List<string> pictureCharP = new List<string>(File.ReadAllLines("pictureCharP.txt"));
                List<string> plusDamage = new List<string>(File.ReadAllLines("plusDamageP.txt"));
                List<string> weaponName = new List<string>(File.ReadAllLines("weaponBuyName.txt"));
                List<string> weaponRemain = new List<string>(File.ReadAllLines("weaponDaysP.txt"));
                List<string> guildP = new List<string>(File.ReadAllLines("guildP.txt"));
                List<string> charP = new List<string>(File.ReadAllLines("charP.txt"));
                List<string> evolveP = new List<string>(File.ReadAllLines("evolveP.txt"));
                List<string> countLevel = new List<string>(File.ReadAllLines("countLevel.txt"));
                List<string> wood = new List<string>(File.ReadAllLines("wood.txt"));
                List<string> stone = new List<string>(File.ReadAllLines("stone.txt"));
                List<string> wool = new List<string>(File.ReadAllLines("wool.txt"));

                List<string> sell = new List<string>(File.ReadAllLines("sell.txt"));

                List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
                int selected = getIndex();

            back:
                try
                {
                    int counter = 0;
                    foreach (var item in sell)
                    {
                        string[] data = item.Split(';');

                        if (data[1] == playerSelect[0])
                        {
                            sell.RemoveAt(counter);
                            File.WriteAllLines("sell.txt", sell.ToArray());
                            goto back;
                        }
                        counter++;
                    }
                }
                catch (Exception)
                {
                }

                if (playerName[selected] == name && playerPassword[selected] == password)
                {
                    if (dialog == DialogResult.Yes)
                    {
                        string playerNamePicture = playerName[selected];

                        try
                        {
                            playerName.RemoveAt(selected);
                            playerPassword.RemoveAt(selected);
                            playerScore.RemoveAt(selected);
                            playerMoney.RemoveAt(selected);
                            playerLastLog.RemoveAt(selected);
                            playerLevel.RemoveAt(selected);
                            playerMush.RemoveAt(selected);
                            playerPower.RemoveAt(selected);
                            playerFloor.RemoveAt(selected);
                            remainTimeP.RemoveAt(selected);
                            bossHP.RemoveAt(selected);
                            pictureCharP.RemoveAt(selected);
                            plusDamage.RemoveAt(selected);
                            weaponName.RemoveAt(selected);
                            weaponRemain.RemoveAt(selected);
                            guildP.RemoveAt(selected);
                            charP.RemoveAt(selected);
                            evolveP.RemoveAt(selected);
                            countLevel.RemoveAt(selected);
                            wood.RemoveAt(selected);
                            stone.RemoveAt(selected);
                            wool.RemoveAt(selected);
                        }
                        catch (Exception)
                        {
                        }

                        File.WriteAllLines("nameP.txt", playerName.ToArray());
                        File.WriteAllLines("passwordP.txt", playerPassword.ToArray());
                        File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
                        File.WriteAllLines("scoreP.txt", playerScore.ToArray());
                        File.WriteAllLines("lastLogP.txt", playerLastLog.ToArray());
                        File.WriteAllLines("levelP.txt", playerLevel.ToArray());
                        File.WriteAllLines("mushP.txt", playerMush.ToArray());
                        File.WriteAllLines("powerP.txt", playerPower.ToArray());
                        File.WriteAllLines("floorP.txt", playerFloor.ToArray());
                        File.WriteAllLines("remainTimeP.txt", remainTimeP.ToArray());
                        File.WriteAllLines("bossHP.txt", bossHP.ToArray());
                        File.WriteAllLines("pictureCharP.txt", pictureCharP.ToArray());
                        File.WriteAllLines("plusDamageP.txt", plusDamage.ToArray());
                        File.WriteAllLines("weaponBuyName.txt", weaponName.ToArray());
                        File.WriteAllLines("weaponDaysP.txt", weaponRemain.ToArray());
                        File.WriteAllLines("guildP.txt", guildP.ToArray());
                        File.WriteAllLines("charP.txt", charP.ToArray());
                        File.WriteAllLines("evolveP.txt", evolveP.ToArray());
                        File.WriteAllLines("countLevel.txt", countLevel.ToArray());
                        File.WriteAllLines("wood.txt", wood.ToArray());
                        File.WriteAllLines("stone.txt", stone.ToArray());
                        File.WriteAllLines("wool.txt", wool.ToArray());

                        // Need Change A Road
                        var filePath = source.source + $@"My_Sf_upgrade\MySFGameWindow\Qr_codes\{playerNamePicture}.png";
                        try
                        {
                            File.Delete(filePath);
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"{err}");
                        }

                        MessageBox.Show("Účet byl úspěšně smazán");
                        this.Close();
                        SelectForm main = new SelectForm();
                        main.Show(); 
                    }
                }
                else
                {
                    MessageBox.Show("Jméno nebo Heslo bylo zadáno špatně");
                    nameBOX.Text = "";
                    passwordBOX.Text = "";
                } 
            }
            else MessageBox.Show("Účet s tímto uživatelským jménem neexistuje");
        }

        // Back Button
        private void backToMenuBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectForm main = new SelectForm();
            main.Show();
        }

        private void DeletePlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DeletePlayer.ModifierKeys == Keys.Alt || DeletePlayer.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}