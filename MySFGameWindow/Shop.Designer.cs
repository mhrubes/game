namespace MySFGameWindow
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.label1 = new System.Windows.Forms.Label();
            this.moneyBox = new System.Windows.Forms.TextBox();
            this.coinBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.coinBuyBTN = new System.Windows.Forms.Button();
            this.powerBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.coinSellBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.powerBTN = new System.Windows.Forms.Button();
            this.powerLabel = new System.Windows.Forms.Label();
            this.backBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aktuální počet peněz:";
            // 
            // moneyBox
            // 
            this.moneyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moneyBox.Location = new System.Drawing.Point(246, 12);
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.ReadOnly = true;
            this.moneyBox.Size = new System.Drawing.Size(152, 26);
            this.moneyBox.TabIndex = 5;
            this.moneyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coinBox
            // 
            this.coinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coinBox.Location = new System.Drawing.Point(246, 63);
            this.coinBox.Name = "coinBox";
            this.coinBox.ReadOnly = true;
            this.coinBox.Size = new System.Drawing.Size(152, 26);
            this.coinBox.TabIndex = 7;
            this.coinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aktuální počet žetonů:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Koupit 1 žeton za 10 peněz";
            // 
            // coinBuyBTN
            // 
            this.coinBuyBTN.BackColor = System.Drawing.Color.DarkOrange;
            this.coinBuyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coinBuyBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.coinBuyBTN.Location = new System.Drawing.Point(17, 294);
            this.coinBuyBTN.Name = "coinBuyBTN";
            this.coinBuyBTN.Size = new System.Drawing.Size(244, 55);
            this.coinBuyBTN.TabIndex = 1;
            this.coinBuyBTN.Text = "Koupit žeton";
            this.coinBuyBTN.UseVisualStyleBackColor = false;
            this.coinBuyBTN.Click += new System.EventHandler(this.coinBuyBTN_Click);
            // 
            // powerBox
            // 
            this.powerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.powerBox.Location = new System.Drawing.Point(246, 105);
            this.powerBox.Name = "powerBox";
            this.powerBox.ReadOnly = true;
            this.powerBox.Size = new System.Drawing.Size(152, 26);
            this.powerBox.TabIndex = 9;
            this.powerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Aktuální síla útoku:";
            // 
            // coinSellBTN
            // 
            this.coinSellBTN.BackColor = System.Drawing.Color.Crimson;
            this.coinSellBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coinSellBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.coinSellBTN.Location = new System.Drawing.Point(343, 294);
            this.coinSellBTN.Name = "coinSellBTN";
            this.coinSellBTN.Size = new System.Drawing.Size(244, 55);
            this.coinSellBTN.TabIndex = 2;
            this.coinSellBTN.Text = "Prodat žeton";
            this.coinSellBTN.UseVisualStyleBackColor = false;
            this.coinSellBTN.Click += new System.EventHandler(this.coinSellBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(338, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prodat 1 žeton za 5 peněz";
            // 
            // powerBTN
            // 
            this.powerBTN.BackColor = System.Drawing.Color.Gold;
            this.powerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.powerBTN.Location = new System.Drawing.Point(169, 392);
            this.powerBTN.Name = "powerBTN";
            this.powerBTN.Size = new System.Drawing.Size(244, 55);
            this.powerBTN.TabIndex = 3;
            this.powerBTN.Text = "Vylepšit útok";
            this.powerBTN.UseVisualStyleBackColor = false;
            this.powerBTN.Click += new System.EventHandler(this.powerBTN_Click);
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.BackColor = System.Drawing.Color.Transparent;
            this.powerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.powerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.powerLabel.Location = new System.Drawing.Point(145, 364);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(290, 25);
            this.powerLabel.TabIndex = 12;
            this.powerLabel.Text = "Vylepšit útok o +1 za 300 peněz";
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.Bisque;
            this.backBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.backBTN.Location = new System.Drawing.Point(421, 525);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(166, 52);
            this.backBTN.TabIndex = 0;
            this.backBTN.Text = "Zpět";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.ControlBox = false;
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.powerBTN);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.coinSellBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.powerBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.coinBuyBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.coinBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moneyBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shop_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox moneyBox;
        private System.Windows.Forms.TextBox coinBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button coinBuyBTN;
        private System.Windows.Forms.TextBox powerBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button coinSellBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button powerBTN;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Button backBTN;
    }
}