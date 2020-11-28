namespace MySFGameWindow
{
    partial class Market
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
            this.backBTN = new System.Windows.Forms.Button();
            this.createOrderBTN = new System.Windows.Forms.Button();
            this.ProductList = new System.Windows.Forms.ListView();
            this.check = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stopBTN = new System.Windows.Forms.Button();
            this.pictureBoxIsActive = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.myCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIsActive)).BeginInit();
            this.SuspendLayout();
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.Bisque;
            this.backBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.backBTN.Location = new System.Drawing.Point(622, 591);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(166, 47);
            this.backBTN.TabIndex = 9;
            this.backBTN.Text = "Zpět";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // createOrderBTN
            // 
            this.createOrderBTN.BackColor = System.Drawing.Color.Tomato;
            this.createOrderBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createOrderBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.createOrderBTN.Location = new System.Drawing.Point(12, 552);
            this.createOrderBTN.Name = "createOrderBTN";
            this.createOrderBTN.Size = new System.Drawing.Size(290, 86);
            this.createOrderBTN.TabIndex = 10;
            this.createOrderBTN.Text = "Vytvořit nabídku";
            this.createOrderBTN.UseVisualStyleBackColor = false;
            this.createOrderBTN.Click += new System.EventHandler(this.createOrderBTN_Click);
            // 
            // ProductList
            // 
            this.ProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProductList.FullRowSelect = true;
            this.ProductList.GridLines = true;
            this.ProductList.Location = new System.Drawing.Point(12, 91);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(776, 442);
            this.ProductList.TabIndex = 11;
            this.ProductList.UseCompatibleStateImageBehavior = false;
            this.ProductList.View = System.Windows.Forms.View.Details;
            this.ProductList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductList_MouseClick);
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.check.Location = new System.Drawing.Point(746, 25);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(18, 17);
            this.check.TabIndex = 12;
            this.check.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(528, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Zobrazit cizí nabídky";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stopBTN
            // 
            this.stopBTN.BackColor = System.Drawing.Color.Beige;
            this.stopBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBTN.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.stopBTN.Location = new System.Drawing.Point(308, 582);
            this.stopBTN.Name = "stopBTN";
            this.stopBTN.Size = new System.Drawing.Size(259, 56);
            this.stopBTN.TabIndex = 14;
            this.stopBTN.Text = "Refresh";
            this.stopBTN.UseVisualStyleBackColor = false;
            this.stopBTN.Click += new System.EventHandler(this.stopBTN_Click);
            // 
            // pictureBoxIsActive
            // 
            this.pictureBoxIsActive.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBoxIsActive.Location = new System.Drawing.Point(12, 62);
            this.pictureBoxIsActive.Name = "pictureBoxIsActive";
            this.pictureBoxIsActive.Size = new System.Drawing.Size(22, 23);
            this.pictureBoxIsActive.TabIndex = 15;
            this.pictureBoxIsActive.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(106, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Vyhledat";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(196, 60);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(166, 22);
            this.searchBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(528, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Zobrazit vlastní nabídky";
            // 
            // myCheck
            // 
            this.myCheck.AutoSize = true;
            this.myCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.myCheck.Location = new System.Drawing.Point(746, 63);
            this.myCheck.Name = "myCheck";
            this.myCheck.Size = new System.Drawing.Size(18, 17);
            this.myCheck.TabIndex = 18;
            this.myCheck.UseVisualStyleBackColor = true;
            // 
            // Market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.myCheck);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxIsActive);
            this.Controls.Add(this.stopBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.createOrderBTN);
            this.Controls.Add(this.backBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 650);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "Market";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Market_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIsActive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Button createOrderBTN;
        private System.Windows.Forms.ListView ProductList;
        private System.Windows.Forms.CheckBox check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stopBTN;
        private System.Windows.Forms.PictureBox pictureBoxIsActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox myCheck;
    }
}