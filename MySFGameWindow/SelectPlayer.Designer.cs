namespace MySFGameWindow
{
    partial class SelectPlayer
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
      this.backBTN = new System.Windows.Forms.Button();
      this.delBTN = new System.Windows.Forms.Button();
      this.loginBTN = new System.Windows.Forms.Button();
      this.forgetPassword = new System.Windows.Forms.Button();
      this.passwordBOX = new System.Windows.Forms.TextBox();
      this.nameBOX = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
      this.SuspendLayout();
      // 
      // backBTN
      // 
      this.backBTN.BackColor = System.Drawing.Color.White;
      this.backBTN.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold);
      this.backBTN.Location = new System.Drawing.Point(156, 652);
      this.backBTN.Name = "backBTN";
      this.backBTN.Size = new System.Drawing.Size(281, 56);
      this.backBTN.TabIndex = 5;
      this.backBTN.Text = "Zpět";
      this.backBTN.UseVisualStyleBackColor = false;
      this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
      // 
      // delBTN
      // 
      this.delBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.delBTN.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold);
      this.delBTN.ForeColor = System.Drawing.Color.Crimson;
      this.delBTN.Location = new System.Drawing.Point(122, 548);
      this.delBTN.Name = "delBTN";
      this.delBTN.Size = new System.Drawing.Size(356, 62);
      this.delBTN.TabIndex = 4;
      this.delBTN.Text = "Vymazat hráče";
      this.delBTN.UseVisualStyleBackColor = true;
      this.delBTN.Click += new System.EventHandler(this.delBTN_Click);
      // 
      // loginBTN
      // 
      this.loginBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
      this.loginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.loginBTN.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold);
      this.loginBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
      this.loginBTN.Location = new System.Drawing.Point(122, 467);
      this.loginBTN.Name = "loginBTN";
      this.loginBTN.Size = new System.Drawing.Size(356, 75);
      this.loginBTN.TabIndex = 3;
      this.loginBTN.Text = "Přihlásit";
      this.loginBTN.UseVisualStyleBackColor = false;
      this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
      // 
      // forgetPassword
      // 
      this.forgetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.forgetPassword.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
      this.forgetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
      this.forgetPassword.Location = new System.Drawing.Point(156, 198);
      this.forgetPassword.Name = "forgetPassword";
      this.forgetPassword.Size = new System.Drawing.Size(186, 38);
      this.forgetPassword.TabIndex = 2;
      this.forgetPassword.Text = "Zapomenuté heslo";
      this.forgetPassword.UseVisualStyleBackColor = true;
      this.forgetPassword.Click += new System.EventHandler(this.forgetPassword_Click);
      // 
      // passwordBOX
      // 
      this.passwordBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
      this.passwordBOX.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.passwordBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.passwordBOX.ForeColor = System.Drawing.Color.White;
      this.passwordBOX.Location = new System.Drawing.Point(156, 162);
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
      this.nameBOX.Location = new System.Drawing.Point(156, 81);
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
      this.label2.Location = new System.Drawing.Point(152, 130);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(155, 20);
      this.label2.TabIndex = 8;
      this.label2.Text = "Zadejte heslo hráče";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.label1.Location = new System.Drawing.Point(152, 48);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(160, 20);
      this.label1.TabIndex = 6;
      this.label1.Text = "Zadejte jméno hráče";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Location = new System.Drawing.Point(156, 110);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(295, 1);
      this.panel1.TabIndex = 7;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.White;
      this.panel2.Location = new System.Drawing.Point(156, 191);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(295, 1);
      this.panel2.TabIndex = 9;
      // 
      // monthCalendar1
      // 
      this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
      this.monthCalendar1.Enabled = false;
      this.monthCalendar1.ForeColor = System.Drawing.Color.White;
      this.monthCalendar1.Location = new System.Drawing.Point(189, 248);
      this.monthCalendar1.MinDate = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
      this.monthCalendar1.Name = "monthCalendar1";
      this.monthCalendar1.ShowTodayCircle = false;
      this.monthCalendar1.TabIndex = 10;
      this.monthCalendar1.TrailingForeColor = System.Drawing.Color.Yellow;
      // 
      // SelectPlayer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
      this.ClientSize = new System.Drawing.Size(600, 720);
      this.Controls.Add(this.monthCalendar1);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.passwordBOX);
      this.Controls.Add(this.nameBOX);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.forgetPassword);
      this.Controls.Add(this.backBTN);
      this.Controls.Add(this.delBTN);
      this.Controls.Add(this.loginBTN);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximumSize = new System.Drawing.Size(600, 720);
      this.MinimumSize = new System.Drawing.Size(600, 720);
      this.Name = "SelectPlayer";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SelectPlayer";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectPlayer_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Button delBTN;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.Button forgetPassword;
        private System.Windows.Forms.TextBox passwordBOX;
        private System.Windows.Forms.TextBox nameBOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}