using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using System.IO;

using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Profile;
using System.Web.Security;
using System.Web.Configuration;
using System.Net.Configuration;

namespace MySFGameWindow
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        
        private void helpBTN_Click(object sender, EventArgs e)
        {
            List<string> playerName = new List<string>(File.ReadAllLines("nameP.txt"));
            List<string> playerPassword = new List<string>(File.ReadAllLines("passwordP.txt"));

            List<string> playerSelect = new List<string>(File.ReadAllLines("selectP.txt"));
            int selected = int.Parse(playerSelect[0]);

            string pass = Guid.NewGuid().ToString("d").Substring(10, 21);

            playerPassword.RemoveAt(selected);
            playerPassword.Insert(selected, pass);
            File.WriteAllLines("passwordP.txt", playerPassword.ToArray());

            string subject = "Set New Password";
            string text = $"RESET password \n\nName: {playerName[selected]}, \nPassword: {pass}";

            sendInfoMethod(subject, text);
        }

        // "HardFightCz@gmail.com"

        private void sendInfoMethod(string subject, string text)
        {
            if (emailBox.Text.Contains("gmail.com"))
            {
                try
                {
                    MailMessage msg = new MailMessage(emailBox.Text, emailBox.Text, subject, text);

                    SmtpClient smt = new SmtpClient("smtp.gmail.com", 587);
                    System.Net.NetworkCredential ntcd = new NetworkCredential(emailBox.Text, passwordBox.Text);
                    smt.Credentials = ntcd;
                    smt.EnableSsl = true;
                    smt.Port = 587;
                    smt.Send(msg);

                    MessageBox.Show("Požadavek na resetování hesla byl odeslán na zadaný E-mail");
                    this.Close();
                    SelectForm form = new SelectForm();
                    form.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Něco se nepovedlo");
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectForm form = new SelectForm();
            form.Show();
        }

        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ContactForm.ModifierKeys == Keys.Alt || ContactForm.ModifierKeys == Keys.F4) e.Cancel = true;
        }

        private void ContactForm_Shown(object sender, EventArgs e) => MessageBox.Show("Podmínky pro resetování hesla: \n\nÚčet na 'Gmail' \nPovolený přístup méně zabezpečených aplikací");
    }
}