namespace MySFGameWindow
{
    partial class Evolve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evolve));
            this.backBTN = new System.Windows.Forms.Button();
            this.EvolveBTN = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.Bisque;
            this.backBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.backBTN.Location = new System.Drawing.Point(12, 576);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(386, 66);
            this.backBTN.TabIndex = 1;
            this.backBTN.Text = "Zpět";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // EvolveBTN
            // 
            this.EvolveBTN.BackColor = System.Drawing.Color.Crimson;
            this.EvolveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EvolveBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.EvolveBTN.Location = new System.Drawing.Point(62, 248);
            this.EvolveBTN.Name = "EvolveBTN";
            this.EvolveBTN.Size = new System.Drawing.Size(281, 116);
            this.EvolveBTN.TabIndex = 0;
            this.EvolveBTN.Text = "EVOLVE";
            this.EvolveBTN.UseVisualStyleBackColor = false;
            this.EvolveBTN.Click += new System.EventHandler(this.EvolveBTN_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 1000;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Evolve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(410, 690);
            this.ControlBox = false;
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.EvolveBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(410, 690);
            this.MinimumSize = new System.Drawing.Size(410, 690);
            this.Name = "Evolve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evolve";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Evolve_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Button EvolveBTN;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}