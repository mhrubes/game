namespace MySFGameWindow
{
    partial class Glory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glory));
            this.backToMenuBTN = new System.Windows.Forms.Button();
            this.levelBTN = new System.Windows.Forms.Button();
            this.floorBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backToMenuBTN
            // 
            this.backToMenuBTN.BackColor = System.Drawing.Color.Bisque;
            this.backToMenuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMenuBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.backToMenuBTN.Location = new System.Drawing.Point(111, 529);
            this.backToMenuBTN.Name = "backToMenuBTN";
            this.backToMenuBTN.Size = new System.Drawing.Size(360, 59);
            this.backToMenuBTN.TabIndex = 0;
            this.backToMenuBTN.Text = "Zpět";
            this.backToMenuBTN.UseVisualStyleBackColor = false;
            this.backToMenuBTN.Click += new System.EventHandler(this.backToMenuBTN_Click);
            // 
            // levelBTN
            // 
            this.levelBTN.BackColor = System.Drawing.Color.Peru;
            this.levelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.levelBTN.Location = new System.Drawing.Point(111, 119);
            this.levelBTN.Name = "levelBTN";
            this.levelBTN.Size = new System.Drawing.Size(360, 89);
            this.levelBTN.TabIndex = 1;
            this.levelBTN.Text = "Levely";
            this.levelBTN.UseVisualStyleBackColor = false;
            this.levelBTN.Click += new System.EventHandler(this.levelBTN_Click);
            // 
            // floorBTN
            // 
            this.floorBTN.BackColor = System.Drawing.Color.Gold;
            this.floorBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.floorBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.floorBTN.Location = new System.Drawing.Point(111, 259);
            this.floorBTN.Name = "floorBTN";
            this.floorBTN.Size = new System.Drawing.Size(360, 89);
            this.floorBTN.TabIndex = 2;
            this.floorBTN.Text = "Poschodí";
            this.floorBTN.UseVisualStyleBackColor = false;
            this.floorBTN.Click += new System.EventHandler(this.floorBTN_Click);
            // 
            // Glory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.ControlBox = false;
            this.Controls.Add(this.floorBTN);
            this.Controls.Add(this.levelBTN);
            this.Controls.Add(this.backToMenuBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Glory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Glory_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToMenuBTN;
        private System.Windows.Forms.Button levelBTN;
        private System.Windows.Forms.Button floorBTN;
    }
}