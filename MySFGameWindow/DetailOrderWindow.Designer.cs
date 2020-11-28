namespace MySFGameWindow
{
    partial class DetailOrderWindow
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
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.workBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.countBox = new System.Windows.Forms.TextBox();
            this.countTrack = new System.Windows.Forms.TrackBar();
            this.countLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minus = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Label();
            this.fullPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeBox
            // 
            this.TypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TypeBox.Location = new System.Drawing.Point(153, 60);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.ReadOnly = true;
            this.TypeBox.Size = new System.Drawing.Size(226, 26);
            this.TypeBox.TabIndex = 5;
            this.TypeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(245, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Typ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(371, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Počet";
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceBox.Location = new System.Drawing.Point(436, 60);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(226, 26);
            this.priceBox.TabIndex = 9;
            this.priceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(458, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cena za jeden kus";
            // 
            // workBTN
            // 
            this.workBTN.BackColor = System.Drawing.Color.Tomato;
            this.workBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.workBTN.Location = new System.Drawing.Point(262, 352);
            this.workBTN.Name = "workBTN";
            this.workBTN.Size = new System.Drawing.Size(290, 86);
            this.workBTN.TabIndex = 12;
            this.workBTN.UseVisualStyleBackColor = false;
            this.workBTN.Click += new System.EventHandler(this.workBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.Bisque;
            this.backBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.backBTN.Location = new System.Drawing.Point(622, 391);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(166, 47);
            this.backBTN.TabIndex = 13;
            this.backBTN.Text = "Zpět";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // countBox
            // 
            this.countBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countBox.Location = new System.Drawing.Point(290, 155);
            this.countBox.Name = "countBox";
            this.countBox.ReadOnly = true;
            this.countBox.Size = new System.Drawing.Size(226, 26);
            this.countBox.TabIndex = 7;
            this.countBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countTrack
            // 
            this.countTrack.Location = new System.Drawing.Point(46, 155);
            this.countTrack.Name = "countTrack";
            this.countTrack.Size = new System.Drawing.Size(708, 56);
            this.countTrack.TabIndex = 15;
            this.countTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countLabel.Location = new System.Drawing.Point(661, 186);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(62, 25);
            this.countLabel.TabIndex = 16;
            this.countLabel.Text = "Počet";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minus.Location = new System.Drawing.Point(12, 143);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(30, 42);
            this.minus.TabIndex = 17;
            this.minus.Text = "-";
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plus.Location = new System.Drawing.Point(760, 143);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(37, 39);
            this.plus.TabIndex = 18;
            this.plus.Text = "+";
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // fullPrice
            // 
            this.fullPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fullPrice.Location = new System.Drawing.Point(295, 287);
            this.fullPrice.Name = "fullPrice";
            this.fullPrice.ReadOnly = true;
            this.fullPrice.Size = new System.Drawing.Size(226, 26);
            this.fullPrice.TabIndex = 20;
            this.fullPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(345, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Celková cena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(458, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Aktuální počet kusů:";
            // 
            // DetailOrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fullPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.countTrack);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.workBTN);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "DetailOrderWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailOrderWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetailOrderWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.countTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button workBTN;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.TrackBar countTrack;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label minus;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.TextBox fullPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}