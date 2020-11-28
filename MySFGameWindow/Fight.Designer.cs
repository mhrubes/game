namespace MySFGameWindow
{
    partial class Fight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fight));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeBox = new System.Windows.Forms.TextBox();
            this.attackBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lootLabel = new System.Windows.Forms.Label();
            this.liveBox = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeBox
            // 
            this.timeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeBox.Location = new System.Drawing.Point(227, 12);
            this.timeBox.Name = "timeBox";
            this.timeBox.ReadOnly = true;
            this.timeBox.Size = new System.Drawing.Size(152, 36);
            this.timeBox.TabIndex = 2;
            this.timeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // attackBTN
            // 
            this.attackBTN.BackColor = System.Drawing.Color.Crimson;
            this.attackBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attackBTN.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.attackBTN.ForeColor = System.Drawing.Color.Black;
            this.attackBTN.Location = new System.Drawing.Point(12, 218);
            this.attackBTN.Name = "attackBTN";
            this.attackBTN.Size = new System.Drawing.Size(576, 82);
            this.attackBTN.TabIndex = 0;
            this.attackBTN.Text = "Útočit";
            this.attackBTN.UseVisualStyleBackColor = false;
            this.attackBTN.Click += new System.EventHandler(this.attackBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.SystemColors.Info;
            this.backBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.backBTN.Location = new System.Drawing.Point(372, 534);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(216, 54);
            this.backBTN.TabIndex = 1;
            this.backBTN.Text = "Zpět";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Indigo;
            this.progressBar1.Location = new System.Drawing.Point(12, 131);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(576, 67);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Životy";
            // 
            // lootLabel
            // 
            this.lootLabel.AutoSize = true;
            this.lootLabel.BackColor = System.Drawing.Color.Transparent;
            this.lootLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lootLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lootLabel.Location = new System.Drawing.Point(7, 563);
            this.lootLabel.Name = "lootLabel";
            this.lootLabel.Size = new System.Drawing.Size(43, 25);
            this.lootLabel.TabIndex = 6;
            this.lootLabel.Text = "loot";
            // 
            // liveBox
            // 
            this.liveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.liveBox.Location = new System.Drawing.Point(82, 98);
            this.liveBox.Name = "liveBox";
            this.liveBox.ReadOnly = true;
            this.liveBox.Size = new System.Drawing.Size(152, 30);
            this.liveBox.TabIndex = 3;
            this.liveBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.ControlBox = false;
            this.Controls.Add(this.liveBox);
            this.Controls.Add(this.lootLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.attackBTN);
            this.Controls.Add(this.timeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Fight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fight_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Button attackBTN;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lootLabel;
        private System.Windows.Forms.TextBox liveBox;
        private System.Windows.Forms.Timer timer2;
    }
}