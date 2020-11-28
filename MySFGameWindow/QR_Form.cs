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
using MessagingToolkit.QRCode.Codec.Data;

namespace MySFGameWindow
{
    public partial class QR_Form : Form
    {
        int dailyBonus;
        int resetMission = 0;
        int contains = 0;
        string qrCodeName;

        public QR_Form()
        {
            InitializeComponent();
        }

        private void loadQRCodeBTN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog f = new OpenFileDialog() { Filter = "PNG(*.PNG)|*.png", ValidateNames = true, Multiselect = false })
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    pictureBox1.Image = Image.FromFile(f.FileName);
                    MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                    qrCodeName = decoder.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void logBTN_Click(object sender, EventArgs e)
        {
            List<string> playerName = new List<string>(File.ReadAllLines("nameP.txt"));
            List<string> playerPassword = new List<string>(File.ReadAllLines("passwordP.txt"));
            List<string> playerMoney = new List<string>(File.ReadAllLines("moneyP.txt"));
            List<string> playerScore = new List<string>(File.ReadAllLines("scoreP.txt"));
            List<string> playerLastLog = new List<string>(File.ReadAllLines("lastLogP.txt"));
            List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));
            List<string> weaponRemain = new List<string>(File.ReadAllLines("weaponDaysP.txt"));
            List<string> eventChecker = new List<string>(File.ReadAllLines("eventChecker.txt"));

            if (playerName.Contains(qrCodeName))
            {
                foreach (var item in playerName)
                {
                    if (item == qrCodeName) break;
                    else contains++;
                }

                DialogResult dialog = MessageBox.Show($"Pokoušíte se přihlásit pod jménem: '{playerName[contains]}' \nPřejete si pokračovat?", "Zpět", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    using (StreamWriter sw = new StreamWriter("selectP.txt")) sw.WriteLine(contains);

                    List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
                    int selected = int.Parse(playerSelect[0]);
                    int level = int.Parse(playerLevel[selected]);

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
                else contains = 0;
            }
            else MessageBox.Show("Nepoužili jste správný QR kód !!");
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectForm main = new SelectForm();
            main.Show();
        }

        private void QR_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (QR_Form.ModifierKeys == Keys.Alt || QR_Form.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}