namespace MySFGameWindow
{
    partial class BlackJackGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJackGameForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.doubleBTN = new System.Windows.Forms.Button();
            this.giveUpBTN = new System.Windows.Forms.Button();
            this.closeAppBTN = new System.Windows.Forms.Button();
            this.totalDealerLabel = new System.Windows.Forms.Label();
            this.dealerListBox = new System.Windows.Forms.ListBox();
            this.betLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.standBTN = new System.Windows.Forms.Button();
            this.hitBTN = new System.Windows.Forms.Button();
            this.checkBTN = new System.Windows.Forms.Button();
            this.chipGetBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.cardInDeckLabel = new System.Windows.Forms.Label();
            this.chipLabel = new System.Windows.Forms.Label();
            this.startBTN = new System.Windows.Forms.Button();
            this.closeBTN = new System.Windows.Forms.Button();
            this.newGameBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // doubleBTN
            // 
            this.doubleBTN.BackColor = System.Drawing.Color.Gold;
            this.doubleBTN.FlatAppearance.BorderSize = 0;
            this.doubleBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doubleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.doubleBTN.ForeColor = System.Drawing.Color.Black;
            this.doubleBTN.Location = new System.Drawing.Point(330, 217);
            this.doubleBTN.Name = "doubleBTN";
            this.doubleBTN.Size = new System.Drawing.Size(169, 54);
            this.doubleBTN.TabIndex = 4;
            this.doubleBTN.Text = "Double";
            this.doubleBTN.UseVisualStyleBackColor = false;
            this.doubleBTN.Click += new System.EventHandler(this.doubleBTN_Click);
            // 
            // giveUpBTN
            // 
            this.giveUpBTN.BackColor = System.Drawing.Color.Orange;
            this.giveUpBTN.FlatAppearance.BorderSize = 0;
            this.giveUpBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.giveUpBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.giveUpBTN.ForeColor = System.Drawing.Color.Black;
            this.giveUpBTN.Location = new System.Drawing.Point(287, 431);
            this.giveUpBTN.Name = "giveUpBTN";
            this.giveUpBTN.Size = new System.Drawing.Size(248, 68);
            this.giveUpBTN.TabIndex = 3;
            this.giveUpBTN.Text = "Vzdát";
            this.giveUpBTN.UseVisualStyleBackColor = false;
            this.giveUpBTN.Click += new System.EventHandler(this.giveUpBTN_Click);
            // 
            // closeAppBTN
            // 
            this.closeAppBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.closeAppBTN.FlatAppearance.BorderSize = 0;
            this.closeAppBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeAppBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeAppBTN.ForeColor = System.Drawing.Color.Black;
            this.closeAppBTN.Location = new System.Drawing.Point(287, 524);
            this.closeAppBTN.Name = "closeAppBTN";
            this.closeAppBTN.Size = new System.Drawing.Size(248, 68);
            this.closeAppBTN.TabIndex = 6;
            this.closeAppBTN.Text = "Konec hry";
            this.closeAppBTN.UseVisualStyleBackColor = false;
            this.closeAppBTN.Click += new System.EventHandler(this.closeAppBTN_Click);
            // 
            // totalDealerLabel
            // 
            this.totalDealerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalDealerLabel.AutoSize = true;
            this.totalDealerLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalDealerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalDealerLabel.ForeColor = System.Drawing.Color.White;
            this.totalDealerLabel.Location = new System.Drawing.Point(661, 372);
            this.totalDealerLabel.Name = "totalDealerLabel";
            this.totalDealerLabel.Size = new System.Drawing.Size(102, 39);
            this.totalDealerLabel.TabIndex = 9;
            this.totalDealerLabel.Text = "Total:";
            // 
            // dealerListBox
            // 
            this.dealerListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dealerListBox.FormattingEnabled = true;
            this.dealerListBox.ItemHeight = 20;
            this.dealerListBox.Location = new System.Drawing.Point(693, 167);
            this.dealerListBox.Name = "dealerListBox";
            this.dealerListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dealerListBox.Size = new System.Drawing.Size(145, 184);
            this.dealerListBox.TabIndex = 10;
            // 
            // betLabel
            // 
            this.betLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.betLabel.AutoSize = true;
            this.betLabel.BackColor = System.Drawing.Color.Transparent;
            this.betLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.betLabel.ForeColor = System.Drawing.Color.White;
            this.betLabel.Location = new System.Drawing.Point(502, 11);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(153, 39);
            this.betLabel.TabIndex = 15;
            this.betLabel.Text = "Your bet:";
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.ForeColor = System.Drawing.Color.White;
            this.resultLabel.Location = new System.Drawing.Point(280, 482);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(100, 39);
            this.resultLabel.TabIndex = 14;
            this.resultLabel.Text = "result";
            // 
            // standBTN
            // 
            this.standBTN.BackColor = System.Drawing.Color.Brown;
            this.standBTN.FlatAppearance.BorderSize = 0;
            this.standBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.standBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.standBTN.ForeColor = System.Drawing.Color.White;
            this.standBTN.Location = new System.Drawing.Point(287, 357);
            this.standBTN.Name = "standBTN";
            this.standBTN.Size = new System.Drawing.Size(248, 68);
            this.standBTN.TabIndex = 2;
            this.standBTN.Text = "Počkat";
            this.standBTN.UseVisualStyleBackColor = false;
            this.standBTN.Click += new System.EventHandler(this.standBTN_Click);
            // 
            // hitBTN
            // 
            this.hitBTN.BackColor = System.Drawing.Color.ForestGreen;
            this.hitBTN.FlatAppearance.BorderSize = 0;
            this.hitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hitBTN.ForeColor = System.Drawing.Color.White;
            this.hitBTN.Location = new System.Drawing.Point(287, 283);
            this.hitBTN.Name = "hitBTN";
            this.hitBTN.Size = new System.Drawing.Size(248, 68);
            this.hitBTN.TabIndex = 1;
            this.hitBTN.Text = "Další karta";
            this.hitBTN.UseVisualStyleBackColor = false;
            this.hitBTN.Click += new System.EventHandler(this.hitBTN_Click);
            // 
            // checkBTN
            // 
            this.checkBTN.BackColor = System.Drawing.Color.Crimson;
            this.checkBTN.FlatAppearance.BorderSize = 0;
            this.checkBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBTN.Location = new System.Drawing.Point(287, 203);
            this.checkBTN.Name = "checkBTN";
            this.checkBTN.Size = new System.Drawing.Size(248, 68);
            this.checkBTN.TabIndex = 0;
            this.checkBTN.Text = "Zadejte sázku";
            this.checkBTN.UseVisualStyleBackColor = false;
            this.checkBTN.Click += new System.EventHandler(this.checkBTN_Click);
            // 
            // chipGetBox
            // 
            this.chipGetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chipGetBox.Location = new System.Drawing.Point(319, 167);
            this.chipGetBox.Name = "chipGetBox";
            this.chipGetBox.Size = new System.Drawing.Size(180, 30);
            this.chipGetBox.TabIndex = 13;
            this.chipGetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chipGetBox.TextChanged += new System.EventHandler(this.chipGetBox_TextChanged);
            this.chipGetBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chipGetBox_KeyPress);
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(12, 366);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(102, 39);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "Total:";
            // 
            // userListBox
            // 
            this.userListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 20;
            this.userListBox.Location = new System.Drawing.Point(19, 167);
            this.userListBox.Name = "userListBox";
            this.userListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userListBox.Size = new System.Drawing.Size(145, 184);
            this.userListBox.TabIndex = 11;
            // 
            // cardInDeckLabel
            // 
            this.cardInDeckLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardInDeckLabel.AutoSize = true;
            this.cardInDeckLabel.BackColor = System.Drawing.Color.Transparent;
            this.cardInDeckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cardInDeckLabel.ForeColor = System.Drawing.Color.White;
            this.cardInDeckLabel.Location = new System.Drawing.Point(12, 60);
            this.cardInDeckLabel.Name = "cardInDeckLabel";
            this.cardInDeckLabel.Size = new System.Drawing.Size(217, 39);
            this.cardInDeckLabel.TabIndex = 17;
            this.cardInDeckLabel.Text = "Card in deck:";
            // 
            // chipLabel
            // 
            this.chipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chipLabel.AutoSize = true;
            this.chipLabel.BackColor = System.Drawing.Color.Transparent;
            this.chipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chipLabel.ForeColor = System.Drawing.Color.White;
            this.chipLabel.Location = new System.Drawing.Point(12, 11);
            this.chipLabel.Name = "chipLabel";
            this.chipLabel.Size = new System.Drawing.Size(114, 39);
            this.chipLabel.TabIndex = 16;
            this.chipLabel.Text = "Chips:";
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.Color.Crimson;
            this.startBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startBTN.FlatAppearance.BorderSize = 0;
            this.startBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startBTN.Location = new System.Drawing.Point(0, 596);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(850, 104);
            this.startBTN.TabIndex = 7;
            this.startBTN.Text = "Stiskněte pro začátek";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // closeBTN
            // 
            this.closeBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.closeBTN.FlatAppearance.BorderSize = 0;
            this.closeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeBTN.ForeColor = System.Drawing.Color.Black;
            this.closeBTN.Location = new System.Drawing.Point(619, 633);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(219, 55);
            this.closeBTN.TabIndex = 8;
            this.closeBTN.Text = "Zpět";
            this.closeBTN.UseVisualStyleBackColor = false;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // newGameBTN
            // 
            this.newGameBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.newGameBTN.FlatAppearance.BorderSize = 0;
            this.newGameBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newGameBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newGameBTN.ForeColor = System.Drawing.Color.Black;
            this.newGameBTN.Location = new System.Drawing.Point(287, 524);
            this.newGameBTN.Name = "newGameBTN";
            this.newGameBTN.Size = new System.Drawing.Size(248, 68);
            this.newGameBTN.TabIndex = 5;
            this.newGameBTN.Text = "Nová hra";
            this.newGameBTN.UseVisualStyleBackColor = false;
            this.newGameBTN.Click += new System.EventHandler(this.newGameBTN_Click);
            // 
            // BlackJackGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 700);
            this.ControlBox = false;
            this.Controls.Add(this.newGameBTN);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.doubleBTN);
            this.Controls.Add(this.giveUpBTN);
            this.Controls.Add(this.closeAppBTN);
            this.Controls.Add(this.totalDealerLabel);
            this.Controls.Add(this.dealerListBox);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.standBTN);
            this.Controls.Add(this.hitBTN);
            this.Controls.Add(this.checkBTN);
            this.Controls.Add(this.chipGetBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.cardInDeckLabel);
            this.Controls.Add(this.chipLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 700);
            this.Name = "BlackJackGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackJackGameForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BlackJackGameForm_FormClosing);
            this.Shown += new System.EventHandler(this.BlackJackGameForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Button doubleBTN;
        private System.Windows.Forms.Button giveUpBTN;
        private System.Windows.Forms.Button closeAppBTN;
        private System.Windows.Forms.Label totalDealerLabel;
        private System.Windows.Forms.ListBox dealerListBox;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button standBTN;
        private System.Windows.Forms.Button hitBTN;
        private System.Windows.Forms.Button checkBTN;
        private System.Windows.Forms.TextBox chipGetBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label cardInDeckLabel;
        private System.Windows.Forms.Label chipLabel;
        private System.Windows.Forms.Button newGameBTN;
    }
}