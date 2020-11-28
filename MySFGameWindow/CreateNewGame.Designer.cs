namespace MySFGameWindow
{
    partial class CreateNewGame
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
            this.backToMenuBTN = new System.Windows.Forms.Button();
            this.createPlayerBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guildBox = new System.Windows.Forms.ComboBox();
            this.charBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.charHelpBTN = new System.Windows.Forms.Button();
            this.checkBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.charPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameBOX = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordBOX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.charPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMenuBTN
            // 
            this.backToMenuBTN.BackColor = System.Drawing.Color.White;
            this.backToMenuBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.backToMenuBTN.Location = new System.Drawing.Point(275, 491);
            this.backToMenuBTN.Name = "backToMenuBTN";
            this.backToMenuBTN.Size = new System.Drawing.Size(202, 59);
            this.backToMenuBTN.TabIndex = 7;
            this.backToMenuBTN.Text = "Zpět";
            this.backToMenuBTN.UseVisualStyleBackColor = false;
            this.backToMenuBTN.Click += new System.EventHandler(this.backToMenuBTN_Click);
            // 
            // createPlayerBTN
            // 
            this.createPlayerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPlayerBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.createPlayerBTN.ForeColor = System.Drawing.Color.Tomato;
            this.createPlayerBTN.Location = new System.Drawing.Point(258, 426);
            this.createPlayerBTN.Name = "createPlayerBTN";
            this.createPlayerBTN.Size = new System.Drawing.Size(236, 59);
            this.createPlayerBTN.TabIndex = 6;
            this.createPlayerBTN.Text = "Vytvořit hráče";
            this.createPlayerBTN.UseVisualStyleBackColor = true;
            this.createPlayerBTN.Click += new System.EventHandler(this.createPlayerBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(57, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Zvolte heslo hráče";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Zvolte jméno hráče";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(57, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Zvolte království";
            // 
            // guildBox
            // 
            this.guildBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.guildBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guildBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guildBox.ForeColor = System.Drawing.Color.White;
            this.guildBox.FormattingEnabled = true;
            this.guildBox.Location = new System.Drawing.Point(61, 222);
            this.guildBox.Name = "guildBox";
            this.guildBox.Size = new System.Drawing.Size(236, 37);
            this.guildBox.TabIndex = 2;
            // 
            // charBox
            // 
            this.charBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.charBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.charBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.charBox.ForeColor = System.Drawing.Color.White;
            this.charBox.FormattingEnabled = true;
            this.charBox.Location = new System.Drawing.Point(61, 309);
            this.charBox.Name = "charBox";
            this.charBox.Size = new System.Drawing.Size(236, 37);
            this.charBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(57, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Zvolte povolání";
            // 
            // charHelpBTN
            // 
            this.charHelpBTN.BackColor = System.Drawing.Color.White;
            this.charHelpBTN.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.charHelpBTN.Location = new System.Drawing.Point(303, 310);
            this.charHelpBTN.Name = "charHelpBTN";
            this.charHelpBTN.Size = new System.Drawing.Size(36, 37);
            this.charHelpBTN.TabIndex = 4;
            this.charHelpBTN.Text = "?";
            this.charHelpBTN.UseVisualStyleBackColor = false;
            this.charHelpBTN.Click += new System.EventHandler(this.charHelpBTN_Click);
            // 
            // checkBox
            // 
            this.checkBox.BackColor = System.Drawing.Color.Crimson;
            this.checkBox.ChechedOffColor = System.Drawing.Color.Crimson;
            this.checkBox.Checked = false;
            this.checkBox.CheckedOnColor = System.Drawing.Color.Gold;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox.ForeColor = System.Drawing.Color.Black;
            this.checkBox.Location = new System.Drawing.Point(258, 379);
            this.checkBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(20, 20);
            this.checkBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(299, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Souhlasím s podmínkami";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // charPictureBox
            // 
            this.charPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.charPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.charPictureBox.Location = new System.Drawing.Point(435, 33);
            this.charPictureBox.Name = "charPictureBox";
            this.charPictureBox.Size = new System.Drawing.Size(263, 314);
            this.charPictureBox.TabIndex = 13;
            this.charPictureBox.TabStop = false;
            this.charPictureBox.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(536, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 186);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(61, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 9;
            // 
            // nameBOX
            // 
            this.nameBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.nameBOX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameBOX.ForeColor = System.Drawing.Color.White;
            this.nameBOX.Location = new System.Drawing.Point(61, 72);
            this.nameBOX.Name = "nameBOX";
            this.nameBOX.Size = new System.Drawing.Size(236, 23);
            this.nameBOX.TabIndex = 0;
            this.nameBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameBOX.TextChanged += new System.EventHandler(this.nameBOX_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(61, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 11;
            // 
            // passwordBOX
            // 
            this.passwordBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.passwordBOX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordBOX.ForeColor = System.Drawing.Color.White;
            this.passwordBOX.Location = new System.Drawing.Point(61, 150);
            this.passwordBOX.Name = "passwordBOX";
            this.passwordBOX.PasswordChar = '*';
            this.passwordBOX.Size = new System.Drawing.Size(236, 23);
            this.passwordBOX.TabIndex = 1;
            this.passwordBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(750, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.passwordBOX);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nameBOX);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.charPictureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.charHelpBTN);
            this.Controls.Add(this.charBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guildBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backToMenuBTN);
            this.Controls.Add(this.createPlayerBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "CreateNewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateNewGame_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.charPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToMenuBTN;
        private System.Windows.Forms.Button createPlayerBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox guildBox;
        private System.Windows.Forms.ComboBox charBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button charHelpBTN;
        private Bunifu.Framework.UI.BunifuCheckbox checkBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox charPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameBOX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passwordBOX;
    }
}