namespace MySFGameWindow
{
    partial class LoginTrue
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginTrue));
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.bar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
      this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // bar
      // 
      this.bar.animated = true;
      this.bar.animationIterval = 10;
      this.bar.animationSpeed = 1;
      this.bar.BackColor = System.Drawing.Color.Transparent;
      this.bar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bar.BackgroundImage")));
      this.bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
      this.bar.ForeColor = System.Drawing.Color.Cyan;
      this.bar.LabelVisible = false;
      this.bar.LineProgressThickness = 8;
      this.bar.LineThickness = 8;
      this.bar.Location = new System.Drawing.Point(515, 588);
      this.bar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
      this.bar.MaxValue = 100;
      this.bar.Name = "bar";
      this.bar.ProgressBackColor = System.Drawing.Color.Gainsboro;
      this.bar.ProgressColor = System.Drawing.Color.SeaGreen;
      this.bar.Size = new System.Drawing.Size(169, 169);
      this.bar.TabIndex = 0;
      this.bar.Value = 0;
      // 
      // bunifuElipse1
      // 
      this.bunifuElipse1.ElipseRadius = 150;
      this.bunifuElipse1.TargetControl = this;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.label1.Location = new System.Drawing.Point(515, 766);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(169, 21);
      this.label1.TabIndex = 1;
      this.label1.Text = "Probíhá přihlášení...";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      this.label2.ForeColor = System.Drawing.Color.Crimson;
      this.label2.Location = new System.Drawing.Point(419, 377);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(351, 92);
      this.label2.TabIndex = 2;
      this.label2.Text = "Hard Fight";
      // 
      // LoginTrue
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1200, 800);
      this.ControlBox = false;
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.bar);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximumSize = new System.Drawing.Size(1200, 800);
      this.MinimumSize = new System.Drawing.Size(1200, 800);
      this.Name = "LoginTrue";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "LoginTrue";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginTrue_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}