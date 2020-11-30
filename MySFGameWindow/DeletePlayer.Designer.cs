namespace MySFGameWindow
{
    partial class DeletePlayer
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
      this.backToMenuBTN = new System.Windows.Forms.Button();
      this.deleteBTN = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.passwordBOX = new System.Windows.Forms.TextBox();
      this.nameBOX = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // backToMenuBTN
      // 
      this.backToMenuBTN.BackColor = System.Drawing.Color.White;
      this.backToMenuBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
      this.backToMenuBTN.Location = new System.Drawing.Point(192, 482);
      this.backToMenuBTN.Name = "backToMenuBTN";
      this.backToMenuBTN.Size = new System.Drawing.Size(202, 59);
      this.backToMenuBTN.TabIndex = 3;
      this.backToMenuBTN.Text = "Zpět";
      this.backToMenuBTN.UseVisualStyleBackColor = false;
      this.backToMenuBTN.Click += new System.EventHandler(this.backToMenuBTN_Click);
      // 
      // deleteBTN
      // 
      this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.deleteBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
      this.deleteBTN.ForeColor = System.Drawing.Color.Crimson;
      this.deleteBTN.Location = new System.Drawing.Point(175, 417);
      this.deleteBTN.Name = "deleteBTN";
      this.deleteBTN.Size = new System.Drawing.Size(236, 59);
      this.deleteBTN.TabIndex = 2;
      this.deleteBTN.Text = "Smazat hráče";
      this.deleteBTN.UseVisualStyleBackColor = true;
      this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.White;
      this.panel2.Location = new System.Drawing.Point(152, 261);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(295, 1);
      this.panel2.TabIndex = 7;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Location = new System.Drawing.Point(152, 134);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(295, 1);
      this.panel1.TabIndex = 5;
      // 
      // passwordBOX
      // 
      this.passwordBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
      this.passwordBOX.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.passwordBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.passwordBOX.ForeColor = System.Drawing.Color.White;
      this.passwordBOX.Location = new System.Drawing.Point(152, 232);
      this.passwordBOX.Name = "passwordBOX";
      this.passwordBOX.PasswordChar = '*';
      this.passwordBOX.Size = new System.Drawing.Size(295, 23);
      this.passwordBOX.TabIndex = 1;
      this.passwordBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // nameBOX
      // 
      this.nameBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
      this.nameBOX.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.nameBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.nameBOX.ForeColor = System.Drawing.Color.White;
      this.nameBOX.Location = new System.Drawing.Point(152, 105);
      this.nameBOX.Name = "nameBOX";
      this.nameBOX.PasswordChar = '*';
      this.nameBOX.Size = new System.Drawing.Size(295, 23);
      this.nameBOX.TabIndex = 0;
      this.nameBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.label2.Location = new System.Drawing.Point(148, 193);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(155, 20);
      this.label2.TabIndex = 6;
      this.label2.Text = "Zadejte heslo hráče";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.label1.Location = new System.Drawing.Point(148, 65);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(160, 20);
      this.label1.TabIndex = 4;
      this.label1.Text = "Zadejte jméno hráče";
      // 
      // DeletePlayer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
      this.ClientSize = new System.Drawing.Size(600, 600);
      this.ControlBox = false;
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.passwordBOX);
      this.Controls.Add(this.nameBOX);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.backToMenuBTN);
      this.Controls.Add(this.deleteBTN);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(600, 600);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(600, 600);
      this.Name = "DeletePlayer";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "DeletePlayer";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeletePlayer_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToMenuBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordBOX;
        private System.Windows.Forms.TextBox nameBOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}