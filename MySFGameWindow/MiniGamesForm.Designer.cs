namespace MySFGameWindow
{
    partial class MiniGamesForm
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
            this.blackJackBTN = new System.Windows.Forms.Button();
            this.jackpotBTN = new System.Windows.Forms.Button();
            this.rockBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // blackJackBTN
            // 
            this.blackJackBTN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.blackJackBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blackJackBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.blackJackBTN.Location = new System.Drawing.Point(49, 111);
            this.blackJackBTN.Name = "blackJackBTN";
            this.blackJackBTN.Size = new System.Drawing.Size(236, 68);
            this.blackJackBTN.TabIndex = 6;
            this.blackJackBTN.Text = "BlackJack";
            this.blackJackBTN.UseVisualStyleBackColor = false;
            this.blackJackBTN.Click += new System.EventHandler(this.blackJackBTN_Click);
            // 
            // jackpotBTN
            // 
            this.jackpotBTN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jackpotBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jackpotBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.jackpotBTN.Location = new System.Drawing.Point(24, 37);
            this.jackpotBTN.Name = "jackpotBTN";
            this.jackpotBTN.Size = new System.Drawing.Size(236, 68);
            this.jackpotBTN.TabIndex = 5;
            this.jackpotBTN.Text = "Jackpot";
            this.jackpotBTN.UseVisualStyleBackColor = false;
            this.jackpotBTN.Click += new System.EventHandler(this.jackpotBTN_Click);
            // 
            // rockBTN
            // 
            this.rockBTN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rockBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rockBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.rockBTN.Location = new System.Drawing.Point(64, 185);
            this.rockBTN.Name = "rockBTN";
            this.rockBTN.Size = new System.Drawing.Size(324, 68);
            this.rockBTN.TabIndex = 7;
            this.rockBTN.Text = "Kámen Nůžky Papír";
            this.rockBTN.UseVisualStyleBackColor = false;
            this.rockBTN.Click += new System.EventHandler(this.rockBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.Bisque;
            this.backBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.backBTN.Location = new System.Drawing.Point(222, 341);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(166, 47);
            this.backBTN.TabIndex = 10;
            this.backBTN.Text = "Zpět";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // MiniGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.ControlBox = false;
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.rockBTN);
            this.Controls.Add(this.blackJackBTN);
            this.Controls.Add(this.jackpotBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MiniGamesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniGamesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MiniGamesForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button blackJackBTN;
        private System.Windows.Forms.Button jackpotBTN;
        private System.Windows.Forms.Button rockBTN;
        private System.Windows.Forms.Button backBTN;
    }
}