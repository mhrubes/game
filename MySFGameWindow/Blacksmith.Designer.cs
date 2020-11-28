namespace MySFGameWindow
{
    partial class Blacksmith
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blacksmith));
            this.backBTN = new System.Windows.Forms.Button();
            this.weaponBOX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.urovenLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.buyBTN = new System.Windows.Forms.Button();
            this.moneyBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plusAttackLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.SystemColors.Info;
            this.backBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.backBTN.Location = new System.Drawing.Point(372, 480);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(216, 58);
            this.backBTN.TabIndex = 0;
            this.backBTN.Text = "Zpět";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // weaponBOX
            // 
            this.weaponBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weaponBOX.FormattingEnabled = true;
            this.weaponBOX.Location = new System.Drawing.Point(166, 168);
            this.weaponBOX.Name = "weaponBOX";
            this.weaponBOX.Size = new System.Drawing.Size(232, 37);
            this.weaponBOX.TabIndex = 1;
            this.weaponBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weaponBOX_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(172, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "úroveň:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(172, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "cena:";
            // 
            // urovenLabel
            // 
            this.urovenLabel.AutoSize = true;
            this.urovenLabel.BackColor = System.Drawing.Color.Transparent;
            this.urovenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.urovenLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.urovenLabel.Location = new System.Drawing.Point(300, 220);
            this.urovenLabel.Name = "urovenLabel";
            this.urovenLabel.Size = new System.Drawing.Size(124, 25);
            this.urovenLabel.TabIndex = 6;
            this.urovenLabel.Text = "úroveň: label";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceLabel.Location = new System.Drawing.Point(300, 280);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(107, 25);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "cena: label";
            // 
            // buyBTN
            // 
            this.buyBTN.BackColor = System.Drawing.Color.Crimson;
            this.buyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.buyBTN.Location = new System.Drawing.Point(177, 396);
            this.buyBTN.Name = "buyBTN";
            this.buyBTN.Size = new System.Drawing.Size(197, 58);
            this.buyBTN.TabIndex = 2;
            this.buyBTN.Text = "Koupit";
            this.buyBTN.UseVisualStyleBackColor = false;
            this.buyBTN.Click += new System.EventHandler(this.buyBTN_Click);
            // 
            // moneyBox
            // 
            this.moneyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moneyBox.Location = new System.Drawing.Point(246, 8);
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.ReadOnly = true;
            this.moneyBox.Size = new System.Drawing.Size(152, 26);
            this.moneyBox.TabIndex = 4;
            this.moneyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Aktuální počet peněz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(172, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "plus k útoku:";
            // 
            // plusAttackLabel
            // 
            this.plusAttackLabel.AutoSize = true;
            this.plusAttackLabel.BackColor = System.Drawing.Color.Transparent;
            this.plusAttackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusAttackLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plusAttackLabel.Location = new System.Drawing.Point(310, 340);
            this.plusAttackLabel.Name = "plusAttackLabel";
            this.plusAttackLabel.Size = new System.Drawing.Size(168, 25);
            this.plusAttackLabel.TabIndex = 10;
            this.plusAttackLabel.Text = "plus k útoku: label";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.BackColor = System.Drawing.Color.Transparent;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.type.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.type.Location = new System.Drawing.Point(404, 280);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(49, 25);
            this.type.TabIndex = 11;
            this.type.Text = "type";
            // 
            // Blacksmith
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.ControlBox = false;
            this.Controls.Add(this.type);
            this.Controls.Add(this.plusAttackLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.moneyBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buyBTN);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.urovenLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weaponBOX);
            this.Controls.Add(this.backBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(600, 550);
            this.MinimumSize = new System.Drawing.Size(600, 550);
            this.Name = "Blacksmith";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blacksmith";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Blacksmith_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.ComboBox weaponBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label urovenLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button buyBTN;
        private System.Windows.Forms.TextBox moneyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label plusAttackLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label type;
    }
}