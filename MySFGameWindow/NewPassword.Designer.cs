namespace MySFGameWindow
{
    partial class NewPassword
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
            this.newPasswordBOX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.setNewPasswordBTN = new System.Windows.Forms.Button();
            this.oldPasswordBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newPasswordBOX
            // 
            this.newPasswordBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newPasswordBOX.Location = new System.Drawing.Point(195, 305);
            this.newPasswordBOX.Name = "newPasswordBOX";
            this.newPasswordBOX.Size = new System.Drawing.Size(196, 26);
            this.newPasswordBOX.TabIndex = 1;
            this.newPasswordBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPasswordBOX.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(201, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zadejte nové heslo";
            // 
            // setNewPasswordBTN
            // 
            this.setNewPasswordBTN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.setNewPasswordBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.setNewPasswordBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.setNewPasswordBTN.Location = new System.Drawing.Point(170, 423);
            this.setNewPasswordBTN.Name = "setNewPasswordBTN";
            this.setNewPasswordBTN.Size = new System.Drawing.Size(242, 56);
            this.setNewPasswordBTN.TabIndex = 2;
            this.setNewPasswordBTN.Text = "Změnit heslo";
            this.setNewPasswordBTN.UseVisualStyleBackColor = false;
            this.setNewPasswordBTN.Click += new System.EventHandler(this.setNewPasswordBTN_Click);
            // 
            // oldPasswordBOX
            // 
            this.oldPasswordBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oldPasswordBOX.Location = new System.Drawing.Point(195, 148);
            this.oldPasswordBOX.Name = "oldPasswordBOX";
            this.oldPasswordBOX.Size = new System.Drawing.Size(196, 26);
            this.oldPasswordBOX.TabIndex = 0;
            this.oldPasswordBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oldPasswordBOX.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(190, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zadejte aktuální heslo";
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.backBTN.Location = new System.Drawing.Point(170, 485);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(242, 56);
            this.backBTN.TabIndex = 3;
            this.backBTN.Text = "Zpět";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.ControlBox = false;
            this.Controls.Add(this.newPasswordBOX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setNewPasswordBTN);
            this.Controls.Add(this.oldPasswordBOX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "NewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPasswod";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewPassword_FormClosing);
            this.Load += new System.EventHandler(this.NewPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newPasswordBOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button setNewPasswordBTN;
        private System.Windows.Forms.TextBox oldPasswordBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBTN;
    }
}