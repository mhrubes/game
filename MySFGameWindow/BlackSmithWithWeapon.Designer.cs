namespace MySFGameWindow
{
    partial class BlackSmithWithWeapon
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
            this.weaponNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.remainTimeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.plusWeaponDamage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.moreDamageBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.moreDaysBTN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sellWeaponBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weaponNameBox
            // 
            this.weaponNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weaponNameBox.Location = new System.Drawing.Point(182, 41);
            this.weaponNameBox.Name = "weaponNameBox";
            this.weaponNameBox.ReadOnly = true;
            this.weaponNameBox.Size = new System.Drawing.Size(218, 30);
            this.weaponNameBox.TabIndex = 5;
            this.weaponNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(207, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Název zbraně";
            // 
            // remainTimeBox
            // 
            this.remainTimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.remainTimeBox.Location = new System.Drawing.Point(263, 167);
            this.remainTimeBox.Name = "remainTimeBox";
            this.remainTimeBox.ReadOnly = true;
            this.remainTimeBox.Size = new System.Drawing.Size(137, 30);
            this.remainTimeBox.TabIndex = 9;
            this.remainTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zbývající dny zbraně";
            // 
            // plusWeaponDamage
            // 
            this.plusWeaponDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusWeaponDamage.Location = new System.Drawing.Point(263, 116);
            this.plusWeaponDamage.Name = "plusWeaponDamage";
            this.plusWeaponDamage.ReadOnly = true;
            this.plusWeaponDamage.Size = new System.Drawing.Size(137, 30);
            this.plusWeaponDamage.TabIndex = 8;
            this.plusWeaponDamage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Síla útoku zbraně";
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.SystemColors.Info;
            this.backBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.backBTN.Location = new System.Drawing.Point(395, 689);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(193, 49);
            this.backBTN.TabIndex = 0;
            this.backBTN.Text = "Zpět";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(131, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Zvýšit útok zbraně o +1 za";
            // 
            // moreDamageBTN
            // 
            this.moreDamageBTN.BackColor = System.Drawing.Color.Crimson;
            this.moreDamageBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreDamageBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.moreDamageBTN.Location = new System.Drawing.Point(182, 304);
            this.moreDamageBTN.Name = "moreDamageBTN";
            this.moreDamageBTN.Size = new System.Drawing.Size(218, 45);
            this.moreDamageBTN.TabIndex = 1;
            this.moreDamageBTN.UseVisualStyleBackColor = false;
            this.moreDamageBTN.Click += new System.EventHandler(this.moreDamageBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(95, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Zvýšit dobu zbraně o jeden den za";
            // 
            // moreDaysBTN
            // 
            this.moreDaysBTN.BackColor = System.Drawing.Color.Gold;
            this.moreDaysBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreDaysBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.moreDaysBTN.Location = new System.Drawing.Point(182, 419);
            this.moreDaysBTN.Name = "moreDaysBTN";
            this.moreDaysBTN.Size = new System.Drawing.Size(218, 45);
            this.moreDaysBTN.TabIndex = 2;
            this.moreDaysBTN.UseVisualStyleBackColor = false;
            this.moreDaysBTN.Click += new System.EventHandler(this.moreDaysBTN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(196, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Prodat zbraň za";
            // 
            // sellWeaponBTN
            // 
            this.sellWeaponBTN.BackColor = System.Drawing.Color.Orange;
            this.sellWeaponBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellWeaponBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.sellWeaponBTN.Location = new System.Drawing.Point(182, 539);
            this.sellWeaponBTN.Name = "sellWeaponBTN";
            this.sellWeaponBTN.Size = new System.Drawing.Size(218, 45);
            this.sellWeaponBTN.TabIndex = 3;
            this.sellWeaponBTN.UseVisualStyleBackColor = false;
            this.sellWeaponBTN.Click += new System.EventHandler(this.sellWeaponBTN_Click);
            // 
            // BlackSmithWithWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(600, 750);
            this.ControlBox = false;
            this.Controls.Add(this.sellWeaponBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.moreDaysBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moreDamageBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.remainTimeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plusWeaponDamage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.weaponNameBox);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(600, 750);
            this.MinimumSize = new System.Drawing.Size(600, 750);
            this.Name = "BlackSmithWithWeapon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackSmithWithWeapon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BlackSmithWithWeapon_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox weaponNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox remainTimeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox plusWeaponDamage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button moreDamageBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button moreDaysBTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sellWeaponBTN;
    }
}