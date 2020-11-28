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
using System.Net.NetworkInformation;
using MaterialSkin;

namespace MySFGameWindow
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            evolveBTN.Hide();

            List<string> autoplay = new List<string>(File.ReadAllLines("autoplay.txt"));
            bool auto = bool.Parse(autoplay[0]);

            if (auto) autoPlayBTN.BackColor = Color.Green;
            else autoPlayBTN.BackColor = Color.Red;

            List<string> eventChecker = new List<string>(File.ReadAllLines("eventChecker.txt"));
            List<string> remainTimeP = new List<string>(File.ReadAllLines("remainTimeP.txt"));
            List<string> levelP = new List<string>(File.ReadAllLines("levelP.txt"));
            List<string> evolveP = new List<string>(File.ReadAllLines("evolveP.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            if (int.Parse(levelP[selected]) >= 30) evolveBTN.Show();
            else if (int.Parse(evolveP[selected]) == 5) evolveBTN.Hide();

            Form fc = Application.OpenForms["Adventure"];
            if (int.Parse(eventChecker[0]) == 1 && fc == null) resetBTN.Show();
            else resetBTN.Hide();

            timer2.Start();
        }

        // Adventure Button
        private void adventureBTN_Click(object sender, EventArgs e)
        {
            List<string> eventChecker = new List<string>(File.ReadAllLines("eventChecker.txt"));

            if (int.Parse(eventChecker[0]) == 0)
            {
                // this.Hide();

                Adventure adventure = new Adventure();
                adventure.Show();

                int a = 1;

                eventChecker.RemoveAt(0);
                eventChecker.Insert(0, a.ToString());

                File.WriteAllLines("eventChecker.txt", eventChecker.ToArray());
            }
            else
            {
                MessageBox.Show("V aktuální době probíhá výprava. Pokud tomu tak není, klikněte na tlačítko 'Reset'");
                this.Close();
                Menu menu = new Menu();
                menu.Show();
            }
        }

        // Shop Button
        private void shopBTN_Click(object sender, EventArgs e)
        {
            List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));

            int selected = int.Parse(playerSelect[0]);
            int level = int.Parse(playerLevel[selected]);

            if (level >= 2)
            {
                this.Hide();
                Shop shop = new Shop();
                shop.Show();
            }
            else MessageBox.Show("Musíte mít nejméně level '2'");
        }

        // BlackSmith Button
        private void blacksmithBTN_Click(object sender, EventArgs e)
        {
            List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));
            List<string> weaponBuyName = new List<string>(File.ReadAllLines("weaponBuyName.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);
            int level = int.Parse(playerLevel[selected]);
            string weaponName = weaponBuyName[selected];

            if (level >= 5)
            {
                if (weaponName != "Null")
                {
                    this.Close();
                    BlackSmithWithWeapon bsw = new BlackSmithWithWeapon();
                    bsw.Show();
                }
                else
                {
                    this.Close();
                    Blacksmith bs = new Blacksmith();
                    bs.Show();
                }
            }
            else MessageBox.Show("Musíte mít nejméně level '5'");
        }

        // Open Game Form
        private void gameBTN_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Adventure"];

            if (fc == null)
            {
                this.Close();
                MiniGamesForm mini = new MiniGamesForm();
                mini.Show();
            }
            else MessageBox.Show("Nejprve musíte ukončit výpravu");
        }

        // Player Stats Button
        private void playerBTN_Click(object sender, EventArgs e)
        {
            this.Close();

            Stat stat = new Stat();
            stat.Show();
        }

        // Guild Button
        private void guildBTN_Click(object sender, EventArgs e)
        {
            List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));
            List<string> playerGuild = new List<string>(File.ReadAllLines("guildP.txt"));
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            List<string> evolveP = new List<string>(File.ReadAllLines("evolveP.txt"));

            int selected = int.Parse(playerSelect[0]);
            int level = int.Parse(playerLevel[selected]);
            string guild = playerGuild[selected];

            if (level >= 15 || int.Parse(evolveP[selected]) >= 1)
            {
                if (guild == "Elderon")
                {
                    this.Close();
                    Elderon elderon = new Elderon();
                    elderon.Show();
                }
                else if (guild == "Aras")
                {
                    this.Close();
                    Aras aras = new Aras();
                    aras.Show();
                }
                else if (guild == "Bundur")
                {
                    this.Close();
                    Bundur bundur = new Bundur();
                    bundur.Show();
                }
            }
            else MessageBox.Show("Musíte mít nejméně level '15'");
        }

        // Glory Button
        private void gloryBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Glory glory = new Glory();
            glory.Show();
        }

        // Challenge Button
        private void challengeBTN_Click(object sender, EventArgs e)
        {
            List<string> playerLevel = new List<string>(File.ReadAllLines("levelP.txt"));
            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));

            int selected = int.Parse(playerSelect[0]);
            int level = int.Parse(playerLevel[selected]);

            Form fc = Application.OpenForms["Adventure"];

            if (level >= 5)
            {
                if (fc == null)
                {
                    this.Close();
                    Boss booses = new Boss();
                    booses.Show();
                }
                else MessageBox.Show("Nejprve musíte ukončit výpravu");
            }
            else MessageBox.Show("Musíte mít nejméně level '5'");
        }

        // Back Button
        private void backBTN_Click(object sender, EventArgs e)
        {
            List<string> eventChecker = new List<string>(File.ReadAllLines("eventChecker.txt"));

            try
            {
                if (int.Parse(eventChecker[0]) == 1)
                {
                    MessageBox.Show("Nejprve musíte ukončit výpravu");
                    MessageBox.Show("Pokud v aktuální době neprobíhá žádná výprava a nelze se odhlásit, klikněte na tlačítko 'Reset' a poté opět na tlačítko 'Odhlásit' ");
                    this.Close();
                    Menu menu = new Menu();
                    menu.Show();
                }
                else
                {
                    Form inv = Application.OpenForms["Inventory"];
                    if (inv != null) Application.OpenForms["Inventory"].Close();

                    using (StreamWriter sw = new StreamWriter("selectP.txt")) sw.WriteLine("");

                    List<string> autoplay = new List<string>(File.ReadAllLines("autoplay.txt"));
                    bool auto = bool.Parse(autoplay[0]);
                    autoplay.RemoveAt(0);
                    autoplay.Insert(0, "false");
                    File.WriteAllLines("autoplay.txt", autoplay.ToArray());

                    MessageBox.Show("Byli jste úspěšně odhlášeni");
                    this.Close();
                    SelectForm form = new SelectForm();
                    form.Show();
                }
            }
            catch (Exception)
            {
            }
        }

        // Reset Button        
        private void resetBTN_Click_1(object sender, EventArgs e)
        {
            List<string> eventChecker = new List<string>(File.ReadAllLines("eventChecker.txt"));

            eventChecker.RemoveAt(0);
            eventChecker.Insert(0, "0");

            MessageBox.Show("Resetováno");
            resetBTN.Hide();

            File.WriteAllLines("eventChecker.txt", eventChecker.ToArray());
        }

        // FeedBack Button
        private void feedBackBTN_Click(object sender, EventArgs e)
        {

        }

        // Evolve Button
        private void evolveBTN_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Adventure"];

            if (fc == null)
            {
                this.Close();
                Evolve evolve = new Evolve();
                evolve.Show();
            }
            else MessageBox.Show("Nejprve Musíte zavřít všechna ostatní okna");
        }

        // private void Menu_Shown(object sender, EventArgs e) => MessageBox.Show("Verze 1.17 \n• Nová třída: 'Alchymista'");
        // Show News Button
        private void newsBTN_Click(object sender, EventArgs e) => MessageBox.Show("Verze 1.02 \n• Nově vytvoření uživatelé nyní uvidí celkový čas ztrávený na cestách \n• Upravený ukazatel času v okně dobrodružství \n\nVerze 1.03 \n• Nastavena maximální délka jména při vytváření nového hráče \n• Úpravy v síni slávy \n\nVerze 1.04 \n• Drobné úpravy 'Stat' \n\nVerze 1.05 \n• Drobné úpravy \n\nVerze 1.06 \n• Nyní si hráč musí vybrat království, za které bude hrát a které se zpřístupní od levelu '15' \n• Království poskytuje výhody jako třeba více peněz nebo více zkušeností za dobrodružství \n\nVerze 1.07 \n• Oprava drobných chyb \n\nVerze 1.08 \n• Hráči mohou nyní vidět, kdo kolik do království vložil peněz po kliknutí na tlačítko 'Zobrazit historii' \n\nVerze 1.09 \n• Nyní si hráčí musí na začátku hry vybrat jedno ze tří povolání \n• Každé povolání nabízí jiné výhody \n\nVerze 1.10 \n• Hráči nyní mohou od levelu 30 použít evolve, díky kterému se odemkne 'Paladin' a jeho výhody \n\nVerze 1.11 \n• Drobné úpravy \n\nVerze 1.12 \n• Možnost o zažádání si nového heslo \n\nVerze 1.13  \n• Přidána hra BlackJack \n\nVerze 1.14 \n• Přidána hra Kámen Nůžky Papír \n• Všechny hry jsou nyní k nalezení pod tlačítkem Mini Hry \n\nVerze 1.15 \n• Přihlášení přes QR kód \n\nVerze 1.16 \n• Vytvoření a přidání inventáře a marketu pro obchod získaných zdrojů za výpravu \n\nVerze 1.17 \n• Nová třída: 'Alchymista'");
        private void feedBackBTN_MouseMove(object sender, MouseEventArgs e) => MessageBox.Show("Pracujeme na tom");

        // Doesn't work
        private void timer1_Tick(object sender, EventArgs e)
        {
            bool connect = NetworkInterface.GetIsNetworkAvailable();
            if (connect == true) evolveBTN.Enabled = true;
            else evolveBTN.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Form lf = Application.OpenForms["LoginTrue"];
            if (lf != null) lf.Close();
            else timer2.Stop();
        }

        private void marketBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Market market = new Market();
            market.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MySFGameWindow.Menu.ModifierKeys == Keys.Alt || MySFGameWindow.Menu.ModifierKeys == Keys.F4) e.Cancel = true;
        }

        private void autoPlayBTN_Click(object sender, EventArgs e)
        {
            List<string> autoplay = new List<string>(File.ReadAllLines("autoplay.txt"));
            bool auto = bool.Parse(autoplay[0]);

            switch (auto)
            {
                case true:
                    autoplay.RemoveAt(0);
                    autoplay.Insert(0, "false");
                    autoPlayBTN.BackColor = Color.Red;
                    File.WriteAllLines("autoplay.txt", autoplay.ToArray());
                    break;
                case false:
                    autoplay.RemoveAt(0);
                    autoplay.Insert(0, "true");
                    autoPlayBTN.BackColor = Color.Green;
                    File.WriteAllLines("autoplay.txt", autoplay.ToArray());
                    break;
            }
        }
    }
}