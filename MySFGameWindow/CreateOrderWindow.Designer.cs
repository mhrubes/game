namespace MySFGameWindow
{
    partial class CreateOrderWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createOrderBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(309, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vyberte typ suroviny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(337, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zadejte počet";
            // 
            // countBox
            // 
            this.countBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countBox.Location = new System.Drawing.Point(298, 178);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(211, 26);
            this.countBox.TabIndex = 3;
            this.countBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countBox.TextChanged += new System.EventHandler(this.countBox_TextChanged);
            this.countBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countBox_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(293, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dostupné množství:";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countLabel.Location = new System.Drawing.Point(473, 207);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(0, 24);
            this.countLabel.TabIndex = 5;
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceBox.Location = new System.Drawing.Point(298, 303);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(211, 26);
            this.priceBox.TabIndex = 7;
            this.priceBox.TextChanged += new System.EventHandler(this.priceBox_TextChanged);
            this.priceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(311, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Zadejte cenu za kus";
            // 
            // createOrderBTN
            // 
            this.createOrderBTN.BackColor = System.Drawing.Color.Tomato;
            this.createOrderBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createOrderBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.createOrderBTN.Location = new System.Drawing.Point(258, 352);
            this.createOrderBTN.Name = "createOrderBTN";
            this.createOrderBTN.Size = new System.Drawing.Size(290, 86);
            this.createOrderBTN.TabIndex = 11;
            this.createOrderBTN.Text = "Vytvořit nabídku";
            this.createOrderBTN.UseVisualStyleBackColor = false;
            this.createOrderBTN.Click += new System.EventHandler(this.createOrderBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.Bisque;
            this.backBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.backBTN.Location = new System.Drawing.Point(622, 391);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(166, 47);
            this.backBTN.TabIndex = 12;
            this.backBTN.Text = "Zpět";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TypeBox
            // 
            this.TypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(298, 71);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(211, 28);
            this.TypeBox.TabIndex = 1;
            this.TypeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeBox_KeyPress);
            // 
            // CreateOrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.createOrderBTN);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "CreateOrderWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateOrderWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateOrderWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createOrderBTN;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox TypeBox;
    }
}