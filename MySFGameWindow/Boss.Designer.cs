namespace MySFGameWindow
{
    partial class Boss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boss));
            this.floorBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enemyHPBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // floorBox
            // 
            this.floorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.floorBox.Location = new System.Drawing.Point(289, 35);
            this.floorBox.Name = "floorBox";
            this.floorBox.ReadOnly = true;
            this.floorBox.Size = new System.Drawing.Size(152, 26);
            this.floorBox.TabIndex = 3;
            this.floorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(55, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aktuální poschodí:";
            // 
            // enemyHPBox
            // 
            this.enemyHPBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enemyHPBox.Location = new System.Drawing.Point(289, 114);
            this.enemyHPBox.Name = "enemyHPBox";
            this.enemyHPBox.ReadOnly = true;
            this.enemyHPBox.Size = new System.Drawing.Size(152, 26);
            this.enemyHPBox.TabIndex = 5;
            this.enemyHPBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(55, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Život nepřítele:";
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.Color.DarkBlue;
            this.startBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.startBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startBTN.Location = new System.Drawing.Point(12, 292);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(576, 82);
            this.startBTN.TabIndex = 1;
            this.startBTN.Text = "Začít souboj";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.Bisque;
            this.backBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.backBTN.Location = new System.Drawing.Point(422, 516);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(166, 52);
            this.backBTN.TabIndex = 0;
            this.backBTN.Text = "Zpět";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // Boss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 580);
            this.ControlBox = false;
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.enemyHPBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.floorBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 580);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 580);
            this.Name = "Boss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Boss_FormClosing);
            this.Load += new System.EventHandler(this.Boos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox floorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enemyHPBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Button backBTN;
    }
}