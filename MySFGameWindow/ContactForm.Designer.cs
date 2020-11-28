namespace MySFGameWindow
{
    partial class ContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.helpBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.backBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // helpBTN
            // 
            this.helpBTN.ActiveBorderThickness = 1;
            this.helpBTN.ActiveCornerRadius = 20;
            this.helpBTN.ActiveFillColor = System.Drawing.Color.White;
            this.helpBTN.ActiveForecolor = System.Drawing.Color.Black;
            this.helpBTN.ActiveLineColor = System.Drawing.Color.Black;
            this.helpBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.helpBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpBTN.BackgroundImage")));
            this.helpBTN.ButtonText = "Klikněte ZDE pro resetování hesla";
            this.helpBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBTN.ForeColor = System.Drawing.Color.SeaGreen;
            this.helpBTN.IdleBorderThickness = 2;
            this.helpBTN.IdleCornerRadius = 30;
            this.helpBTN.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.helpBTN.IdleForecolor = System.Drawing.Color.White;
            this.helpBTN.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.helpBTN.Location = new System.Drawing.Point(151, 308);
            this.helpBTN.Margin = new System.Windows.Forms.Padding(5);
            this.helpBTN.Name = "helpBTN";
            this.helpBTN.Size = new System.Drawing.Size(194, 80);
            this.helpBTN.TabIndex = 0;
            this.helpBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.helpBTN.Click += new System.EventHandler(this.helpBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.ActiveBorderThickness = 1;
            this.backBTN.ActiveCornerRadius = 20;
            this.backBTN.ActiveFillColor = System.Drawing.Color.White;
            this.backBTN.ActiveForecolor = System.Drawing.Color.Black;
            this.backBTN.ActiveLineColor = System.Drawing.Color.Black;
            this.backBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.backBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBTN.BackgroundImage")));
            this.backBTN.ButtonText = "Zpět";
            this.backBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBTN.ForeColor = System.Drawing.Color.SeaGreen;
            this.backBTN.IdleBorderThickness = 2;
            this.backBTN.IdleCornerRadius = 30;
            this.backBTN.IdleFillColor = System.Drawing.Color.Black;
            this.backBTN.IdleForecolor = System.Drawing.Color.White;
            this.backBTN.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.backBTN.Location = new System.Drawing.Point(337, 430);
            this.backBTN.Margin = new System.Windows.Forms.Padding(5);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(149, 56);
            this.backBTN.TabIndex = 1;
            this.backBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailBox.ForeColor = System.Drawing.Color.White;
            this.emailBox.Location = new System.Drawing.Point(87, 100);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(336, 23);
            this.emailBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zadejte váš email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zadejte heslo od vašeho emailu";
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordBox.ForeColor = System.Drawing.Color.White;
            this.passwordBox.Location = new System.Drawing.Point(135, 228);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(239, 23);
            this.passwordBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(87, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 1);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(135, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 1);
            this.panel2.TabIndex = 9;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.helpBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "ContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactForm_FormClosing);
            this.Shown += new System.EventHandler(this.ContactForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 helpBTN;
        private Bunifu.Framework.UI.BunifuThinButton2 backBTN;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}