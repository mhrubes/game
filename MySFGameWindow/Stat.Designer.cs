namespace MySFGameWindow
{
    partial class Stat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stat));
            this.gloryBTN = new System.Windows.Forms.Button();
            this.moneyBox = new System.Windows.Forms.TextBox();
            this.passwordBOX = new System.Windows.Forms.TextBox();
            this.newPasswordBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.coinBox = new System.Windows.Forms.TextBox();
            this.nextLevelLabel = new System.Windows.Forms.Label();
            this.powerBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plusWeaponDamage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.remainTimeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.weaponNameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.evolveBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.evolveHelpBTN = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.charPictureBox = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.inventoryBTN = new System.Windows.Forms.Button();
            this.classLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gloryBTN
            // 
            this.gloryBTN.BackColor = System.Drawing.Color.Orange;
            this.gloryBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gloryBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.gloryBTN.Location = new System.Drawing.Point(745, 726);
            this.gloryBTN.Name = "gloryBTN";
            this.gloryBTN.Size = new System.Drawing.Size(193, 56);
            this.gloryBTN.TabIndex = 1;
            this.gloryBTN.Text = "Síň slávy";
            this.gloryBTN.UseVisualStyleBackColor = false;
            this.gloryBTN.Click += new System.EventHandler(this.gloryBTN_Click);
            // 
            // moneyBox
            // 
            this.moneyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moneyBox.Location = new System.Drawing.Point(759, 122);
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.ReadOnly = true;
            this.moneyBox.Size = new System.Drawing.Size(179, 30);
            this.moneyBox.TabIndex = 9;
            this.moneyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordBOX
            // 
            this.passwordBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordBOX.Location = new System.Drawing.Point(17, 294);
            this.passwordBOX.Name = "passwordBOX";
            this.passwordBOX.PasswordChar = '*';
            this.passwordBOX.ReadOnly = true;
            this.passwordBOX.Size = new System.Drawing.Size(142, 30);
            this.passwordBOX.TabIndex = 12;
            this.passwordBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newPasswordBTN
            // 
            this.newPasswordBTN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.newPasswordBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.newPasswordBTN.Location = new System.Drawing.Point(17, 330);
            this.newPasswordBTN.Name = "newPasswordBTN";
            this.newPasswordBTN.Size = new System.Drawing.Size(215, 68);
            this.newPasswordBTN.TabIndex = 2;
            this.newPasswordBTN.Text = "Změnit heslo";
            this.newPasswordBTN.UseVisualStyleBackColor = false;
            this.newPasswordBTN.Click += new System.EventHandler(this.newPasswordBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.SystemColors.Info;
            this.backBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.backBTN.Location = new System.Drawing.Point(745, 788);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(193, 50);
            this.backBTN.TabIndex = 0;
            this.backBTN.Text = "Zpět";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(190, 67);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "jméno";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordLabel.Location = new System.Drawing.Point(12, 262);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 29);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Heslo";
            // 
            // coinBox
            // 
            this.coinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coinBox.Location = new System.Drawing.Point(759, 192);
            this.coinBox.Name = "coinBox";
            this.coinBox.ReadOnly = true;
            this.coinBox.Size = new System.Drawing.Size(179, 30);
            this.coinBox.TabIndex = 10;
            this.coinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nextLevelLabel
            // 
            this.nextLevelLabel.AutoSize = true;
            this.nextLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.nextLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextLevelLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextLevelLabel.Location = new System.Drawing.Point(433, 414);
            this.nextLevelLabel.Name = "nextLevelLabel";
            this.nextLevelLabel.Size = new System.Drawing.Size(112, 26);
            this.nextLevelLabel.TabIndex = 16;
            this.nextLevelLabel.Text = "Další level";
            // 
            // powerBox
            // 
            this.powerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.powerBox.Location = new System.Drawing.Point(258, 739);
            this.powerBox.Name = "powerBox";
            this.powerBox.ReadOnly = true;
            this.powerBox.Size = new System.Drawing.Size(137, 30);
            this.powerBox.TabIndex = 23;
            this.powerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 740);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Síla útoku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(7, 776);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "plus k síle útoku";
            // 
            // plusWeaponDamage
            // 
            this.plusWeaponDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusWeaponDamage.Location = new System.Drawing.Point(258, 775);
            this.plusWeaponDamage.Name = "plusWeaponDamage";
            this.plusWeaponDamage.ReadOnly = true;
            this.plusWeaponDamage.Size = new System.Drawing.Size(137, 30);
            this.plusWeaponDamage.TabIndex = 25;
            this.plusWeaponDamage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(7, 812);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Zbývající dny zbraně";
            // 
            // remainTimeBox
            // 
            this.remainTimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.remainTimeBox.Location = new System.Drawing.Point(258, 811);
            this.remainTimeBox.Name = "remainTimeBox";
            this.remainTimeBox.ReadOnly = true;
            this.remainTimeBox.Size = new System.Drawing.Size(137, 30);
            this.remainTimeBox.TabIndex = 27;
            this.remainTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(7, 684);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Název zbraně";
            // 
            // weaponNameBox
            // 
            this.weaponNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weaponNameBox.Location = new System.Drawing.Point(202, 685);
            this.weaponNameBox.Name = "weaponNameBox";
            this.weaponNameBox.ReadOnly = true;
            this.weaponNameBox.Size = new System.Drawing.Size(263, 30);
            this.weaponNameBox.TabIndex = 21;
            this.weaponNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(95, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Království";
            // 
            // evolveBox
            // 
            this.evolveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.evolveBox.Location = new System.Drawing.Point(801, 495);
            this.evolveBox.Name = "evolveBox";
            this.evolveBox.ReadOnly = true;
            this.evolveBox.Size = new System.Drawing.Size(137, 36);
            this.evolveBox.TabIndex = 19;
            this.evolveBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(796, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Evolve";
            // 
            // evolveHelpBTN
            // 
            this.evolveHelpBTN.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.evolveHelpBTN.Location = new System.Drawing.Point(759, 496);
            this.evolveHelpBTN.Name = "evolveHelpBTN";
            this.evolveHelpBTN.Size = new System.Drawing.Size(36, 37);
            this.evolveHelpBTN.TabIndex = 18;
            this.evolveHelpBTN.Text = "?";
            this.evolveHelpBTN.UseVisualStyleBackColor = true;
            this.evolveHelpBTN.Click += new System.EventHandler(this.evolveHelpBTN_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(703, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 55);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(345, 402);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 50);
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(703, 183);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 55);
            this.pictureBox3.TabIndex = 65;
            this.pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // charPictureBox
            // 
            this.charPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.charPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.charPictureBox.Location = new System.Drawing.Point(345, 40);
            this.charPictureBox.Name = "charPictureBox";
            this.charPictureBox.Size = new System.Drawing.Size(263, 314);
            this.charPictureBox.TabIndex = 100;
            this.charPictureBox.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(345, 360);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(263, 36);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 101;
            this.progressBar1.MouseLeave += new System.EventHandler(this.progressBar1_MouseLeave);
            this.progressBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseMove);
            // 
            // inventoryBTN
            // 
            this.inventoryBTN.BackColor = System.Drawing.Color.Indigo;
            this.inventoryBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.inventoryBTN.ForeColor = System.Drawing.Color.White;
            this.inventoryBTN.Location = new System.Drawing.Point(745, 664);
            this.inventoryBTN.Name = "inventoryBTN";
            this.inventoryBTN.Size = new System.Drawing.Size(193, 56);
            this.inventoryBTN.TabIndex = 102;
            this.inventoryBTN.Text = "Inventář";
            this.inventoryBTN.UseVisualStyleBackColor = false;
            this.inventoryBTN.Click += new System.EventHandler(this.inventoryBTN_Click);
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.BackColor = System.Drawing.Color.Transparent;
            this.classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.classLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classLabel.Location = new System.Drawing.Point(97, 135);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(111, 29);
            this.classLabel.TabIndex = 103;
            this.classLabel.Text = "Povolání";
            // 
            // Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(950, 850);
            this.ControlBox = false;
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.inventoryBTN);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.charPictureBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.evolveHelpBTN);
            this.Controls.Add(this.evolveBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.weaponNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.remainTimeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plusWeaponDamage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.powerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nextLevelLabel);
            this.Controls.Add(this.coinBox);
            this.Controls.Add(this.gloryBTN);
            this.Controls.Add(this.moneyBox);
            this.Controls.Add(this.passwordBOX);
            this.Controls.Add(this.newPasswordBTN);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.passwordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 850);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 850);
            this.Name = "Stat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stat_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gloryBTN;
        private System.Windows.Forms.TextBox moneyBox;
        private System.Windows.Forms.TextBox passwordBOX;
        private System.Windows.Forms.Button newPasswordBTN;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox coinBox;
        private System.Windows.Forms.Label nextLevelLabel;
        private System.Windows.Forms.TextBox powerBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox plusWeaponDamage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox remainTimeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox weaponNameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox evolveBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button evolveHelpBTN;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox charPictureBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button inventoryBTN;
        private System.Windows.Forms.Label classLabel;
    }
}