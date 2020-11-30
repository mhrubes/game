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
    public partial class SelectPlayer : Form
    {
        int dailyBonus;
        int resetMission = 0;

        public SelectPlayer()
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

        // Login Button
        private void loginBTN_Click(object sender, EventArgs e)
        {
            List<string> playerList = new List<string>(File.ReadAllLines("nameP.txt"));
            List<string> playerPassword = new List<string>(File.ReadAllLines("passwordP.txt"));

            if (playerList.Contains(nameBOX.Text))
            {
                if (nameBOX.Text == playerList[getIndex()])
                {
                    using (StreamWriter sw = new StreamWriter("selectP.txt")) sw.WriteLine(getIndex());

                    List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
                    List<string> playerScore = new List<string>(File.ReadAllLines("scoreP.txt"));
                    List<string> playerLastLog = new List<string>(File.ReadAllLines("lastLogP.txt"));
                    List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));
                    List<string> weaponRemain = new List<string>(File.ReadAllLines("weaponDaysP.txt"));
                    List<string> eventChecker = new List<string>(File.ReadAllLines("eventChecker.txt"));

                    List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
                    int selected = int.Parse(playerSelect[0]);
                    int level = int.Parse(playerLevel[selected]);

                    string name = nameBOX.Text;
                    string password = passwordBOX.Text;

                    string time = DateTime.Now.ToString();
                    string splitTime = time.Substring(0, 10);

                    string lastLog = playerLastLog[selected];
                    string substrLastLog = lastLog.Substring(0, 10);

                    DateTime d1 = DateTime.Parse(splitTime);
                    DateTime d2 = DateTime.Parse(substrLastLog);

                    TimeSpan t = d2 - d1;
                    double countDays = t.TotalDays;

                    double removeWeaponDay = int.Parse(weaponRemain[selected]);
                    int random = 0;

                    var decrypt = "";
                    try
                    {
                      decrypt = SecurePasswordHasher.Decrypt(playerPassword[selected]);
                    }
                    catch (Exception)
                    {
                    }

                    if (playerList[selected] == name && decrypt == password)
                    {
                        if (playerLastLog[selected] != splitTime)
                        {
                            try
                            {
                                Random rnd = new Random();

                                random = rnd.Next(1 * level, 10 * level) * 2;

                                dailyBonus = random + int.Parse(playerMoney[selected]);
                                removeWeaponDay += countDays;

                                playerMoney.RemoveAt(selected);
                                playerMoney.Insert(selected, dailyBonus.ToString());

                                weaponRemain.RemoveAt(selected);
                                weaponRemain.Insert(selected, removeWeaponDay.ToString());

                                string times = DateTime.Now.ToString();
                                string splitTimes = times.Substring(0, 10);
                                playerLastLog.RemoveAt(selected);
                                playerLastLog.Insert(selected, splitTimes);

                                eventChecker.RemoveAt(selected);
                                eventChecker.Insert(selected, resetMission.ToString());
                            }
                            catch (Exception)
                            {
                            }

                            List<string> plusDamage = new List<string>(File.ReadAllLines("plusDamageP.txt"));
                            List<string> weaponBuyName = new List<string>(File.ReadAllLines("weaponBuyName.txt"));

                            if (int.Parse(weaponRemain[selected]) <= 0)
                            {
                                string plusDamageText = "0";
                                string weaponBuyNameText = "Null";
                                string remain = "0";

                                plusDamage.RemoveAt(selected);
                                plusDamage.Insert(selected, plusDamageText);

                                weaponBuyName.RemoveAt(selected);
                                weaponBuyName.Insert(selected, weaponBuyNameText);

                                weaponRemain.RemoveAt(selected);
                                weaponRemain.Insert(selected, remain);
                            }

                            File.WriteAllLines("plusDamageP.txt", plusDamage.ToArray());
                            File.WriteAllLines("weaponBuyName.txt", weaponBuyName.ToArray());
                            File.WriteAllLines("weaponDaysP.txt", weaponRemain.ToArray());
                            File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
                            File.WriteAllLines("lastLogP.txt", playerLastLog.ToArray());
                            File.WriteAllLines("eventChecker.txt", eventChecker.ToArray());

                            MessageBox.Show($"Obdrželi jste {random} zlaťáků jako odměnu za denní přihlášení");
                            this.Close();
                            LoginTrue log = new LoginTrue();
                            log.Show();
                        }
                        else
                        {
                            try
                            {
                                dailyBonus = 0 + int.Parse(playerMoney[selected]);
                                playerMoney.RemoveAt(selected);
                                playerMoney.Insert(selected, dailyBonus.ToString());

                                eventChecker.RemoveAt(selected);
                                eventChecker.Insert(selected, resetMission.ToString());
                            }
                            catch (Exception)
                            {
                            }

                            File.WriteAllLines("moneyP.txt", playerMoney.ToArray());
                            File.WriteAllLines("eventChecker.txt", eventChecker.ToArray());

                            MessageBox.Show("Denní odměna již obdržena");
                            this.Close();
                            LoginTrue log = new LoginTrue();
                            log.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Jméno nebo Heslo bylo zadáno špatně");
                        nameBOX.Text = "";
                        passwordBOX.Text = "";

                        DialogResult dialog = MessageBox.Show("Přejete si obnovit heslo?", "Zpět", MessageBoxButtons.YesNo);

                        if (dialog == DialogResult.Yes)
                        {
                            this.Close();
                            ContactForm contact = new ContactForm();
                            contact.Show();
                        }
                    }
                }
                else MessageBox.Show("Zadané informace nejsou správně");
            }
            else MessageBox.Show("Účet s tímto uživatelským jménem neexistuje");
        }

        // Delete Button
        private void delBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeletePlayer del = new DeletePlayer();
            del.Show();
        }

        /*
        private void loginQRCodeBTN_Click(object sender, EventArgs e)
        {
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            string checker = playerSelect[0];

            if (checker != "") using (StreamWriter sw = new StreamWriter("selectP.txt")) sw.WriteLine("");

            this.Close();
            QR_Form qr = new QR_Form();
            qr.Show();
        }
        */

        // Back Button
        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectForm form = new SelectForm();
            form.Show();
        }

        private void forgetPassword_Click(object sender, EventArgs e)
        {
            List<string> playerList = new List<string>(File.ReadAllLines("nameP.txt"));
            if (playerList.Contains(nameBOX.Text))
            {
                using (StreamWriter sw = new StreamWriter("selectP.txt")) sw.WriteLine(getIndex());

                this.Close();
                ContactForm cf = new ContactForm();
                cf.Show();
            }
            else if (nameBOX.Text.Length == 0) MessageBox.Show("Nejprve zadejte uživatelské jméno");
            else MessageBox.Show("Musíte zadat platné uživatelské jméno");
        }

        private void SelectPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SelectPlayer.ModifierKeys == Keys.Alt || SelectPlayer.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}