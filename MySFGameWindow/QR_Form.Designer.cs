namespace MySFGameWindow
{
    partial class QR_Form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadQRCodeBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.logBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(175, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 217);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // loadQRCodeBTN
            // 
            this.loadQRCodeBTN.BackColor = System.Drawing.SystemColors.Control;
            this.loadQRCodeBTN.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.loadQRCodeBTN.Location = new System.Drawing.Point(197, 280);
            this.loadQRCodeBTN.Name = "loadQRCodeBTN";
            this.loadQRCodeBTN.Size = new System.Drawing.Size(202, 56);
            this.loadQRCodeBTN.TabIndex = 0;
            this.loadQRCodeBTN.Text = "Vložit QR kód";
            this.loadQRCodeBTN.UseVisualStyleBackColor = false;
            this.loadQRCodeBTN.Click += new System.EventHandler(this.loadQRCodeBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.SystemColors.Control;
            this.backBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.backBTN.Location = new System.Drawing.Point(414, 431);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(174, 57);
            this.backBTN.TabIndex = 2;
            this.backBTN.Text = "Zpět";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // logBTN
            // 
            this.logBTN.BackColor = System.Drawing.SystemColors.Control;
            this.logBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.logBTN.Location = new System.Drawing.Point(175, 342);
            this.logBTN.Name = "logBTN";
            this.logBTN.Size = new System.Drawing.Size(249, 67);
            this.logBTN.TabIndex = 1;
            this.logBTN.Text = "Pokračovat";
            this.logBTN.UseVisualStyleBackColor = false;
            this.logBTN.Click += new System.EventHandler(this.logBTN_Click);
            // 
            // QR_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.ControlBox = false;
            this.Controls.Add(this.logBTN);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.loadQRCodeBTN);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "QR_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QR_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loadQRCodeBTN;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Button logBTN;
    }
}