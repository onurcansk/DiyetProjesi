namespace ArayüzÇalışma
{
    partial class frmMainPage
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
            this.pnlMainPage = new System.Windows.Forms.Panel();
            this.llbWebPage = new System.Windows.Forms.LinkLabel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lswLastFoods = new System.Windows.Forms.ListView();
            this.clmFood = new System.Windows.Forms.ColumnHeader();
            this.clmFoodName = new System.Windows.Forms.ColumnHeader();
            this.clmPortion = new System.Windows.Forms.ColumnHeader();
            this.clmCalorie = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlMainPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainPage
            // 
            this.pnlMainPage.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainPage.BackgroundImage = global::ArayüzÇalışma.Properties.Resources.background;
            this.pnlMainPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMainPage.Controls.Add(this.llbWebPage);
            this.pnlMainPage.Controls.Add(this.lblHeader);
            this.pnlMainPage.Controls.Add(this.panel3);
            this.pnlMainPage.Controls.Add(this.panel2);
            this.pnlMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPage.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlMainPage.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPage.Name = "pnlMainPage";
            this.pnlMainPage.Size = new System.Drawing.Size(675, 450);
            this.pnlMainPage.TabIndex = 0;
            // 
            // llbWebPage
            // 
            this.llbWebPage.AutoSize = true;
            this.llbWebPage.BackColor = System.Drawing.Color.Transparent;
            this.llbWebPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llbWebPage.Font = new System.Drawing.Font("ISOCPEUR", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llbWebPage.Location = new System.Drawing.Point(124, 68);
            this.llbWebPage.Name = "llbWebPage";
            this.llbWebPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.llbWebPage.Size = new System.Drawing.Size(426, 48);
            this.llbWebPage.TabIndex = 1;
            this.llbWebPage.TabStop = true;
            this.llbWebPage.Text = "UYGULAMA HAKKINDA DETAYLI BİLGİ ALMAK İÇİN\r\nWEB SAYFAMIZI ZİYARET EDİNİZ";
            this.llbWebPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("ISOCPEUR", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(102, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(471, 31);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "KALORİ TAKİP UYGULAMASINA HOŞ GELDİNİZ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lswLastFoods);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(12, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 311);
            this.panel3.TabIndex = 3;
            // 
            // lswLastFoods
            // 
            this.lswLastFoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lswLastFoods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lswLastFoods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFood,
            this.clmFoodName,
            this.clmPortion,
            this.clmCalorie});
            this.lswLastFoods.ForeColor = System.Drawing.Color.White;
            this.lswLastFoods.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lswLastFoods.Location = new System.Drawing.Point(0, 157);
            this.lswLastFoods.Name = "lswLastFoods";
            this.lswLastFoods.Size = new System.Drawing.Size(324, 154);
            this.lswLastFoods.TabIndex = 3;
            this.lswLastFoods.UseCompatibleStateImageBehavior = false;
            this.lswLastFoods.View = System.Windows.Forms.View.Details;
            // 
            // clmFood
            // 
            this.clmFood.Text = "Kategori";
            this.clmFood.Width = 70;
            // 
            // clmFoodName
            // 
            this.clmFoodName.Text = "Yemek";
            this.clmFoodName.Width = 120;
            // 
            // clmPortion
            // 
            this.clmPortion.Text = "Porsiyon";
            this.clmPortion.Width = 65;
            // 
            // clmCalorie
            // 
            this.clmCalorie.Text = "Kalori";
            this.clmCalorie.Width = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(156, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "SON EKLENEN ÖĞÜN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "TARİH :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "ÖĞÜN :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(345, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 311);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(126, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "GÜNLÜK RAPOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOPLAM KALORİ :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(12, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "YEMEK SAYISI :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "GÜN :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(12, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "ÖĞÜN SAYISI :";
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.pnlMainPage);
            this.Font = new System.Drawing.Font("ISOCTEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMainPage";
            this.Text = "frmMainPage";
            this.pnlMainPage.ResumeLayout(false);
            this.pnlMainPage.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMainPage;
        private Label lblHeader;
        private LinkLabel llbWebPage;
        private Label label11;
        private Label label5;
        private Label label9;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private ListView lswLastFoods;
        private ColumnHeader clmFood;
        private ColumnHeader clmFoodName;
        private ColumnHeader clmPortion;
        private ColumnHeader clmCalorie;
        private Label label12;
    }
}