namespace MySFGameWindow
{
    partial class Jackpot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jackpot));
            this.coinBox = new System.Windows.Forms.TextBox();
            this.startBTN = new System.Windows.Forms.Button();
            this.userNumberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.randomNumberBox = new System.Windows.Forms.TextBox();
            this.shopBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.acceptBTN = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // coinBox
            // 
            this.coinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coinBox.Location = new System.Drawing.Point(68, 26);
            this.coinBox.Name = "coinBox";
            this.coinBox.ReadOnly = true;
            this.coinBox.Size = new System.Drawing.Size(152, 26);
            this.coinBox.TabIndex = 3;
            this.coinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.Color.DarkBlue;
            this.startBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.startBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startBTN.Location = new System.Drawing.Point(12, 212);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(558, 82);
            this.startBTN.TabIndex = 7;
            this.startBTN.Text = "Začít hru";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // userNumberBox
            // 
            this.userNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userNumberBox.Location = new System.Drawing.Point(218, 170);
            this.userNumberBox.Name = "userNumberBox";
            this.userNumberBox.Size = new System.Drawing.Size(152, 36);
            this.userNumberBox.TabIndex = 5;
            this.userNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNumberBox.TextChanged += new System.EventHandler(this.userNumberBox_TextChanged);
            this.userNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNumberBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(182, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zadejte číslo od 1 do 10";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // randomNumberBox
            // 
            this.randomNumberBox.BackColor = System.Drawing.Color.DarkRed;
            this.randomNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.randomNumberBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.randomNumberBox.Location = new System.Drawing.Point(218, 336);
            this.randomNumberBox.Name = "randomNumberBox";
            this.randomNumberBox.ReadOnly = true;
            this.randomNumberBox.Size = new System.Drawing.Size(152, 36);
            this.randomNumberBox.TabIndex = 6;
            this.randomNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shopBTN
            // 
            this.shopBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.shopBTN.Location = new System.Drawing.Point(12, 512);
            this.shopBTN.Name = "shopBTN";
            this.shopBTN.Size = new System.Drawing.Size(236, 66);
            this.shopBTN.TabIndex = 1;
            this.shopBTN.Text = "Obchod";
            this.shopBTN.UseVisualStyleBackColor = true;
            this.shopBTN.Click += new System.EventHandler(this.shopBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.Bisque;
            this.backBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.backBTN.Location = new System.Drawing.Point(423, 527);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(166, 51);
            this.backBTN.TabIndex = 2;
            this.backBTN.Text = "Zpět";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // acceptBTN
            // 
            this.acceptBTN.BackColor = System.Drawing.Color.DarkBlue;
            this.acceptBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.acceptBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.acceptBTN.Location = new System.Drawing.Point(12, 212);
            this.acceptBTN.Name = "acceptBTN";
            this.acceptBTN.Size = new System.Drawing.Size(577, 82);
            this.acceptBTN.TabIndex = 0;
            this.acceptBTN.Text = "Potvrdit číslo";
            this.acceptBTN.UseVisualStyleBackColor = false;
            this.acceptBTN.Click += new System.EventHandler(this.acceptBTN_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 55);
            this.pictureBox3.TabIndex = 66;
            this.pictureBox3.TabStop = false;
            // 
            // Jackpot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.acceptBTN);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.shopBTN);
            this.Controls.Add(this.randomNumberBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNumberBox);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.coinBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Jackpot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jackpot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Jackpot_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox coinBox;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.TextBox userNumberBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox randomNumberBox;
        private System.Windows.Forms.Button shopBTN;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Button acceptBTN;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}