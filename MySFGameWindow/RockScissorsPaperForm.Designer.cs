namespace MySFGameWindow
{
    partial class RockScissorsPaperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RockScissorsPaperForm));
            this.label1 = new System.Windows.Forms.Label();
            this.aiPictureBox = new System.Windows.Forms.PictureBox();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.paperBTN = new System.Windows.Forms.Button();
            this.scissorsBTN = new System.Windows.Forms.Button();
            this.rockBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.chipLabel = new System.Windows.Forms.Label();
            this.chipGetBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.checkBTN = new System.Windows.Forms.Button();
            this.playerBet = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.aiPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(475, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 58);
            this.label1.TabIndex = 11;
            this.label1.Text = "VS";
            // 
            // aiPictureBox
            // 
            this.aiPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.aiPictureBox.Location = new System.Drawing.Point(574, 293);
            this.aiPictureBox.Name = "aiPictureBox";
            this.aiPictureBox.Size = new System.Drawing.Size(170, 205);
            this.aiPictureBox.TabIndex = 10;
            this.aiPictureBox.TabStop = false;
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.playerPictureBox.Location = new System.Drawing.Point(299, 293);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(170, 205);
            this.playerPictureBox.TabIndex = 9;
            this.playerPictureBox.TabStop = false;
            // 
            // paperBTN
            // 
            this.paperBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.paperBTN.Location = new System.Drawing.Point(40, 442);
            this.paperBTN.Name = "paperBTN";
            this.paperBTN.Size = new System.Drawing.Size(212, 91);
            this.paperBTN.TabIndex = 8;
            this.paperBTN.Text = "Papír";
            this.paperBTN.UseVisualStyleBackColor = true;
            this.paperBTN.Click += new System.EventHandler(this.paperBTN_Click);
            // 
            // scissorsBTN
            // 
            this.scissorsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scissorsBTN.Location = new System.Drawing.Point(40, 345);
            this.scissorsBTN.Name = "scissorsBTN";
            this.scissorsBTN.Size = new System.Drawing.Size(212, 91);
            this.scissorsBTN.TabIndex = 7;
            this.scissorsBTN.Text = "Nůžky";
            this.scissorsBTN.UseVisualStyleBackColor = true;
            this.scissorsBTN.Click += new System.EventHandler(this.scissorsBTN_Click);
            // 
            // rockBTN
            // 
            this.rockBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rockBTN.Location = new System.Drawing.Point(40, 248);
            this.rockBTN.Name = "rockBTN";
            this.rockBTN.Size = new System.Drawing.Size(212, 91);
            this.rockBTN.TabIndex = 6;
            this.rockBTN.Text = "Kámen";
            this.rockBTN.UseVisualStyleBackColor = true;
            this.rockBTN.Click += new System.EventHandler(this.rockBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.Bisque;
            this.backBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.backBTN.Location = new System.Drawing.Point(624, 594);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(166, 47);
            this.backBTN.TabIndex = 12;
            this.backBTN.Text = "Zpět";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // chipLabel
            // 
            this.chipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chipLabel.AutoSize = true;
            this.chipLabel.BackColor = System.Drawing.Color.Transparent;
            this.chipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chipLabel.ForeColor = System.Drawing.Color.White;
            this.chipLabel.Location = new System.Drawing.Point(12, 9);
            this.chipLabel.Name = "chipLabel";
            this.chipLabel.Size = new System.Drawing.Size(114, 39);
            this.chipLabel.TabIndex = 17;
            this.chipLabel.Text = "Chips:";
            // 
            // chipGetBox
            // 
            this.chipGetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chipGetBox.Location = new System.Drawing.Point(436, 51);
            this.chipGetBox.Name = "chipGetBox";
            this.chipGetBox.Size = new System.Drawing.Size(180, 30);
            this.chipGetBox.TabIndex = 18;
            this.chipGetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chipGetBox.TextChanged += new System.EventHandler(this.chipGetBox_TextChanged);
            this.chipGetBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chipGetBox_KeyPress);
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.ForeColor = System.Drawing.Color.White;
            this.resultLabel.Location = new System.Drawing.Point(33, 594);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(100, 39);
            this.resultLabel.TabIndex = 20;
            this.resultLabel.Text = "result";
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
            // checkBTN
            // 
            this.checkBTN.BackColor = System.Drawing.Color.Crimson;
            this.checkBTN.FlatAppearance.BorderSize = 0;
            this.checkBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBTN.Location = new System.Drawing.Point(410, 87);
            this.checkBTN.Name = "checkBTN";
            this.checkBTN.Size = new System.Drawing.Size(248, 68);
            this.checkBTN.TabIndex = 21;
            this.checkBTN.Text = "Zadejte sázku";
            this.checkBTN.UseVisualStyleBackColor = false;
            this.checkBTN.Click += new System.EventHandler(this.checkBTN_Click);
            // 
            // playerBet
            // 
            this.playerBet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerBet.AutoSize = true;
            this.playerBet.BackColor = System.Drawing.Color.Transparent;
            this.playerBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerBet.ForeColor = System.Drawing.Color.White;
            this.playerBet.Location = new System.Drawing.Point(12, 66);
            this.playerBet.Name = "playerBet";
            this.playerBet.Size = new System.Drawing.Size(114, 39);
            this.playerBet.TabIndex = 22;
            this.playerBet.Text = "Chips:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // RockScissorsPaperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 653);
            this.ControlBox = false;
            this.Controls.Add(this.playerBet);
            this.Controls.Add(this.checkBTN);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.chipGetBox);
            this.Controls.Add(this.chipLabel);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aiPictureBox);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.paperBTN);
            this.Controls.Add(this.scissorsBTN);
            this.Controls.Add(this.rockBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RockScissorsPaperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RockScissorsPaperForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RockScissorsPaperForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.aiPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox aiPictureBox;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.Button paperBTN;
        private System.Windows.Forms.Button scissorsBTN;
        private System.Windows.Forms.Button rockBTN;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Label chipLabel;
        private System.Windows.Forms.TextBox chipGetBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button checkBTN;
        private System.Windows.Forms.Label playerBet;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer3;
    }
}