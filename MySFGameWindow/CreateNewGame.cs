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
using System.Drawing.Imaging;
using System.Globalization;

/*
    selectP.txt
*/

namespace MySFGameWindow
{
    public partial class CreateNewGame : Form
    {
        string playerName;
        SourceClass source = new SourceClass();

        public CreateNewGame()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            
            charPictureBox.Show();

            createPlayerBTN.BackColor = Color.Crimson;
            createPlayerBTN.ForeColor = Color.White;

            guildBox.Items.AddRange(new object[] { "Elderon", "Aras", "Bundur" });
            guildBox.DropDownStyle = ComboBoxStyle.DropDownList;
            charBox.Items.AddRange(new object[] { "Válečník", "Kouzelník", "Lovec", "Alchymista", "Lord" });
            charBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // Create Player Button
        private void createPlayerBTN_Click(object sender, EventArgs e)
        {
            List<string> playerNameList = new List<string>(File.ReadAllLines("nameP.txt"));

            playerName = nameBOX.Text;
            string playerPassword = passwordBOX.Text;

            string selectChar = charBox.Text;
            if (selectChar == "Válečník") selectChar = "Valecnik";
            else if (selectChar == "Kouzelník") selectChar = "Kouzelnik";
            else if (selectChar == "Lovec") selectChar = "Lovec";
            else if (selectChar == "Alchymista") selectChar = "Alchymista";
            else if (selectChar == "Lord") selectChar = "Lord";

            if (!playerNameList.Contains(playerName))
            {
                if (playerName != "" && playerName.Length <= 9 && guildBox.Text != "" && charBox.Text != "" && charBox.Text != "Lord" && checkBox.Checked == true)
                {
                    DialogResult dialog = MessageBox.Show("Opravdu Chcete VYTVOŘIT nový účet?", "Zpět", MessageBoxButtons.YesNo);

                    if (dialog == DialogResult.Yes)
                    {
                        string time = DateTime.Now.ToString();
                        string splitTime = time.Substring(0, 10);

                        using (StreamWriter sw = new StreamWriter("nameP.txt", true)) sw.WriteLine(playerName);
                        using (StreamWriter sw = new StreamWriter("passwordP.txt", true)) sw.WriteLine(playerPassword);
                        using (StreamWriter sw = new StreamWriter("scoreP.txt", true)) sw.WriteLine(0);

                        if (selectChar == "Lovec") using (StreamWriter sw = new StreamWriter("moneyP.txt", true)) sw.WriteLine(100);
                        else using (StreamWriter sw = new StreamWriter("moneyP.txt", true)) sw.WriteLine(0);

                        using (StreamWriter sw = new StreamWriter("lastLogP.txt", true)) sw.WriteLine(splitTime);

                        if (selectChar == "Kouzelnik")
                        {
                            using (StreamWriter sw = new StreamWriter("levelP.txt", true)) sw.WriteLine(3);
                            using (StreamWriter sw = new StreamWriter("countLevel.txt", true)) sw.WriteLine(3);
                        }
                        else
                        {
                            using (StreamWriter sw = new StreamWriter("levelP.txt", true)) sw.WriteLine(1);
                            using (StreamWriter sw = new StreamWriter("countLevel.txt", true)) sw.WriteLine(1);
                        }

                        // Need Change A Road
                        if (selectChar == "Valecnik") using (StreamWriter sw = new StreamWriter("pictureCharP.txt", true)) sw.WriteLine("warrior.png");
                        else if (selectChar == "Kouzelnik") using (StreamWriter sw = new StreamWriter("pictureCharP.txt", true)) sw.WriteLine("mage.png");
                        else if (selectChar == "Lovec") using (StreamWriter sw = new StreamWriter("pictureCharP.txt", true)) sw.WriteLine("hunter.png");
                        else if (selectChar == "Alchymista") using (StreamWriter sw = new StreamWriter("pictureCharP.txt", true)) sw.WriteLine("alchemist.png");
                        else if (selectChar == "Lord") using (StreamWriter sw = new StreamWriter("pictureCharP.txt", true)) sw.WriteLine("lord.png");

                        using (StreamWriter sw = new StreamWriter("mushP.txt", true)) sw.WriteLine(0);
                        using (StreamWriter sw = new StreamWriter("powerP.txt", true)) sw.WriteLine(1);
                        using (StreamWriter sw = new StreamWriter("floorP.txt", true)) sw.WriteLine(1);
                        using (StreamWriter sw = new StreamWriter("bossHP.txt", true)) sw.WriteLine(50);
                        using (StreamWriter sw = new StreamWriter("remainTimeP.txt", true)) sw.WriteLine(0);
                        using (StreamWriter sw = new StreamWriter("plusDamageP.txt", true)) sw.WriteLine(0);
                        using (StreamWriter sw = new StreamWriter("weaponBuyName.txt", true)) sw.WriteLine("Null");
                        using (StreamWriter sw = new StreamWriter("weaponDaysP.txt", true)) sw.WriteLine(0);
                        using (StreamWriter sw = new StreamWriter("guildP.txt", true)) sw.WriteLine(guildBox.Text);
                        using (StreamWriter sw = new StreamWriter("charP.txt", true)) sw.WriteLine(selectChar);
                        using (StreamWriter sw = new StreamWriter("evolveP.txt", true)) sw.WriteLine("0");
                        using (StreamWriter sw = new StreamWriter("wood.txt", true)) sw.WriteLine("0");
                        using (StreamWriter sw = new StreamWriter("stone.txt", true)) sw.WriteLine("0");
                        using (StreamWriter sw = new StreamWriter("wool.txt", true)) sw.WriteLine("0");

                        try
                        {
                            // Need Change A Road
                            pictureBox1.Image.Save(source.source + $"@" + source.folderName + $@"\MySFGameWindow\Qr_codes\{playerName}.png", System.Drawing.Imaging.ImageFormat.Png);
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"{err}");
                        }

                        MessageBox.Show("Vytvořili jste novou hru. \n\nNyní klikněte v hlavním menu na 'Vytvořené hry' a pomocí zadaných údajů se můžete přihlásit");
                        MessageBox.Show("POKUD ZAPOMENETE HESLO NEBO DOJDE K JEHO ZTRÁTĚ, POŽÁDEJTE O POMOC ADMINA");

                        this.Close();
                        // Jump to SelectForm
                        SelectForm form = new SelectForm();
                        form.Show();
                    }
                    else if (dialog == DialogResult.No)
                    {
                        checkBox.Checked = false;
                        MessageBox.Show("Nevytvořili jste novou postavu");
                    }
                }
                else if (playerName == "") MessageBox.Show("Musíte vytvořit jméno úúčtu");
                else if (guildBox.Text == "") MessageBox.Show("Musíte vybrat království");
                else if (charBox.Text == "") MessageBox.Show("Musíte vybrat povolání");
                else if (charBox.Text == "Lord")
                {
                    MessageBox.Show("V tuto dobu není možné začít hru za Lorda");
                    charBox.Text = "";
                }
                else if (checkBox.Checked == false) MessageBox.Show("Pro pokračování Musíte souhlasit s podmínkami");
            }
            else
            {
                MessageBox.Show("Toto jméno není dostupné");
                nameBOX.Clear();
                passwordBOX.Clear();
                checkBox.Checked = false;
            }
        }

        // Back Button
        private void backToMenuBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectForm form = new SelectForm();
            form.Show();
        }

        // Name Box
        private void nameBOX_TextChanged(object sender, EventArgs e)
        {
            string noSpace = nameBOX.Text;

            if (nameBOX.Text.Length == 1)
            {
                char[] v = nameBOX.Text.ToCharArray();
                string s = v[0].ToString().ToUpper();
                for (int b = 1; b < v.Length; b++)
                    s += v[b].ToString().ToLower();
                nameBOX.Text = s;
                nameBOX.Select(nameBOX.Text.Length, 0);
            }

            try
            {
                if (noSpace[0] == ' ')
                {
                    MessageBox.Show("Jméno nemůže začínat mezerou");
                    nameBOX.Clear();
                }
            }
            catch (IndexOutOfRangeException)
            {
            }

            noSpace = String.Join("", noSpace.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            if (nameBOX.Text.Length == 9) MessageBox.Show("Dosažena maximální délka");
            if (nameBOX.Text.Length == 10) nameBOX.Text = "";
        }

        // Info Button
        private void charHelpBTN_Click(object sender, EventArgs e)
        {
            if (charBox.Text == "Válečník") MessageBox.Show("Válečník \n• Dvojnásobná doba zbraně při nákupu \n• Zvýšený čas v Challenge o 5 vteřin");
            else if (charBox.Text == "Kouzelník") MessageBox.Show("Kouzelník \n• Bonus ke zkušenostem za výpravu \n• Na začátku každého levelu dostane 300 bodů");
            else if (charBox.Text == "Lovec") MessageBox.Show("Lovec \n• Bonus k penězům za výpravu \n• na začátku hry dostane 100 peněz");
            else if (charBox.Text == "Alchymista") MessageBox.Show("Alchymista \n• Bonus k surovinám za výpravu od levelu 10");
            else if (charBox.Text == "Lord") MessageBox.Show("Lord \n• Snížený čas v dobrodružství na polovinu Od levelu '20'");
            else if (charBox.Text == "") MessageBox.Show("Nejprve musíte zvolit povolání");
        }

        int zero = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            List<string> name = new List<string>(File.ReadAllLines("nameP.txt"));

            string playerName = nameBOX.Text;

            if (zero == 0)
                if (playerName != "" && playerName.Length <= 9 && guildBox.Text != "" && charBox.Text != "" && charBox.Text != "Paladin" && checkBox.Checked == true && !name.Contains(playerName)) selectColorMethod(Color.SeaGreen, Color.Black);
                else selectColorMethod(Color.Crimson, Color.White);

            try
            {
                // Need Change A Road
                if (charBox.Text == "Válečník") chooseCharPictureMethod(source.source + @"My_Sf_Upgrade\MySFGameWindow\charPictures\warrior.png");
                else if (charBox.Text == "Lovec") chooseCharPictureMethod(source.source + @"My_Sf_Upgrade\MySFGameWindow\charPictures\hunter.png");
                else if (charBox.Text == "Kouzelník") chooseCharPictureMethod(source.source + @"My_Sf_Upgrade\MySFGameWindow\charPictures\mage.png");
                else if (charBox.Text == "Alchymista") chooseCharPictureMethod(source.source + @"My_Sf_Upgrade\MySFGameWindow\charPictures\alchemist.png");
                else if (charBox.Text == "Lord") chooseCharPictureMethod(source.source + @"My_Sf_Upgrade\MySFGameWindow\charPictures\lord.png");
                else if (charBox.Text == "") charPictureBox.BackColor = Color.Transparent;
            }
            catch (Exception)
            {
                charPictureBox.BackColor = Color.Transparent;
            }
        }

        // Method On Picture
        private void chooseCharPictureMethod(string root)
        {
            charPictureBox.Image = new Bitmap($"{root}");
            charPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void selectColorMethod(Color one, Color two)
        {
            createPlayerBTN.BackColor = one;
            createPlayerBTN.ForeColor = two;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (nameBOX.Text != "") pictureBox1.Show();
            else pictureBox1.Hide();

            try
            {
                QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
                var data = qr.CreateQrCode(nameBOX.Text, QRCoder.QRCodeGenerator.ECCLevel.Q);
                var code = new QRCoder.QRCode(data);
                pictureBox1.Image = code.GetGraphic(5);
            }
            catch (Exception)
            {
            }
        }

        private void CreateNewGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CreateNewGame.ModifierKeys == Keys.Alt || CreateNewGame.ModifierKeys == Keys.F4) e.Cancel = true;
        }
    }
}