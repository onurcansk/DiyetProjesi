namespace WinFormUI
{
    partial class frmAddMeal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cmbMealType = new System.Windows.Forms.ComboBox();
            this.cmbMealCategory = new System.Windows.Forms.ComboBox();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.lblDataGridView = new System.Windows.Forms.Label();
            this.dgvDailyReport = new System.Windows.Forms.DataGridView();
            this.clmCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmPiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCalorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstMeal = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.btnAddMealType = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.nmdPortion = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdPortion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("ISOCPEUR", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(276, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(125, 31);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "ÖĞÜN EKLE";
            // 
            // cmbMealType
            // 
            this.cmbMealType.FormattingEnabled = true;
            this.cmbMealType.Location = new System.Drawing.Point(12, 59);
            this.cmbMealType.Name = "cmbMealType";
            this.cmbMealType.Size = new System.Drawing.Size(192, 29);
            this.cmbMealType.TabIndex = 1;
            this.cmbMealType.Text = "ÖĞÜN SEÇ";
            // 
            // cmbMealCategory
            // 
            this.cmbMealCategory.FormattingEnabled = true;
            this.cmbMealCategory.Location = new System.Drawing.Point(12, 129);
            this.cmbMealCategory.Name = "cmbMealCategory";
            this.cmbMealCategory.Size = new System.Drawing.Size(192, 29);
            this.cmbMealCategory.TabIndex = 1;
            this.cmbMealCategory.Text = "YEMEK KATEGORİSİ";
            // 
            // cmbFood
            // 
            this.cmbFood.FormattingEnabled = true;
            this.cmbFood.Location = new System.Drawing.Point(210, 129);
            this.cmbFood.Name = "cmbFood";
            this.cmbFood.Size = new System.Drawing.Size(194, 29);
            this.cmbFood.TabIndex = 1;
            this.cmbFood.Text = "YEMEK";
            this.cmbFood.SelectedIndexChanged += new System.EventHandler(this.cmbFood_SelectedIndexChanged);
            // 
            // lblDataGridView
            // 
            this.lblDataGridView.AutoSize = true;
            this.lblDataGridView.BackColor = System.Drawing.Color.Transparent;
            this.lblDataGridView.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataGridView.ForeColor = System.Drawing.Color.Black;
            this.lblDataGridView.Location = new System.Drawing.Point(261, 170);
            this.lblDataGridView.Name = "lblDataGridView";
            this.lblDataGridView.Size = new System.Drawing.Size(131, 21);
            this.lblDataGridView.TabIndex = 0;
            this.lblDataGridView.Text = "GÜNLÜK ÖĞÜNLER";
            // 
            // dgvDailyReport
            // 
            this.dgvDailyReport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Format = "N1";
            dataGridViewCellStyle1.NullValue = "1";
            this.dgvDailyReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDailyReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvDailyReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCategory,
            this.clmFood,
            this.clmImg,
            this.clmPiece,
            this.clmCalorie,
            this.clmId});
            this.dgvDailyReport.Location = new System.Drawing.Point(143, 203);
            this.dgvDailyReport.Name = "dgvDailyReport";
            this.dgvDailyReport.ReadOnly = true;
            this.dgvDailyReport.RowTemplate.Height = 25;
            this.dgvDailyReport.Size = new System.Drawing.Size(491, 231);
            this.dgvDailyReport.TabIndex = 3;
            this.dgvDailyReport.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDailyReport_DataError);
            // 
            // clmCategory
            // 
            this.clmCategory.HeaderText = "Kategori";
            this.clmCategory.Name = "clmCategory";
            this.clmCategory.ReadOnly = true;
            this.clmCategory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCategory.Width = 120;
            // 
            // clmFood
            // 
            this.clmFood.HeaderText = "Yemek";
            this.clmFood.Name = "clmFood";
            this.clmFood.ReadOnly = true;
            this.clmFood.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmFood.Width = 150;
            // 
            // clmImg
            // 
            this.clmImg.HeaderText = "Resim";
            this.clmImg.Name = "clmImg";
            this.clmImg.ReadOnly = true;
            this.clmImg.Width = 50;
            // 
            // clmPiece
            // 
            this.clmPiece.HeaderText = "Porsiyon";
            this.clmPiece.Name = "clmPiece";
            this.clmPiece.ReadOnly = true;
            this.clmPiece.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmPiece.Width = 65;
            // 
            // clmCalorie
            // 
            this.clmCalorie.HeaderText = "Kalori";
            this.clmCalorie.Name = "clmCalorie";
            this.clmCalorie.ReadOnly = true;
            this.clmCalorie.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCalorie.Width = 65;
            // 
            // clmId
            // 
            this.clmId.HeaderText = "ID";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            // 
            // lstMeal
            // 
            this.lstMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lstMeal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMeal.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstMeal.ForeColor = System.Drawing.Color.White;
            this.lstMeal.FormattingEnabled = true;
            this.lstMeal.ItemHeight = 21;
            this.lstMeal.Location = new System.Drawing.Point(12, 203);
            this.lstMeal.Name = "lstMeal";
            this.lstMeal.Size = new System.Drawing.Size(116, 231);
            this.lstMeal.TabIndex = 4;
            this.lstMeal.SelectedIndexChanged += new System.EventHandler(this.lstMeal_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(546, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pbProduct
            // 
            this.pbProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pbProduct.Location = new System.Drawing.Point(552, 24);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(82, 82);
            this.pbProduct.TabIndex = 5;
            this.pbProduct.TabStop = false;
            // 
            // btnAddMealType
            // 
            this.btnAddMealType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddMealType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMealType.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddMealType.FlatAppearance.BorderSize = 0;
            this.btnAddMealType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAddMealType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAddMealType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMealType.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMealType.ForeColor = System.Drawing.Color.White;
            this.btnAddMealType.Location = new System.Drawing.Point(217, 59);
            this.btnAddMealType.Name = "btnAddMealType";
            this.btnAddMealType.Size = new System.Drawing.Size(72, 29);
            this.btnAddMealType.TabIndex = 2;
            this.btnAddMealType.Text = "EKLE";
            this.btnAddMealType.UseVisualStyleBackColor = false;
            this.btnAddMealType.Click += new System.EventHandler(this.btnAddMealType_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(596, 130);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(38, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "-";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // nmdPortion
            // 
            this.nmdPortion.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmdPortion.Location = new System.Drawing.Point(410, 130);
            this.nmdPortion.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmdPortion.Name = "nmdPortion";
            this.nmdPortion.Size = new System.Drawing.Size(120, 27);
            this.nmdPortion.TabIndex = 6;
            this.nmdPortion.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // frmAddMeal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.nmdPortion);
            this.Controls.Add(this.pbProduct);
            this.Controls.Add(this.lstMeal);
            this.Controls.Add(this.dgvDailyReport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddMealType);
            this.Controls.Add(this.cmbFood);
            this.Controls.Add(this.cmbMealCategory);
            this.Controls.Add(this.cmbMealType);
            this.Controls.Add(this.lblDataGridView);
            this.Controls.Add(this.lblHeader);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddMeal";
            this.Text = "ÖĞÜN EKLE";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdPortion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHeader;
        private ComboBox cmbMealType;
        private ComboBox cmbMealCategory;
        private ComboBox cmbFood;
        private Label lblDataGridView;
        private DataGridView dgvDailyReport;
        private ListBox lstMeal;
        private Button btnAdd;
        private PictureBox pbProduct;
        private Button btnAddMealType;
        private Button btnDelete;
        private NumericUpDown nmdPortion;
        private DataGridViewTextBoxColumn clmCategory;
        private DataGridViewTextBoxColumn clmFood;
        private DataGridViewImageColumn clmImg;
        private DataGridViewTextBoxColumn clmPiece;
        private DataGridViewTextBoxColumn clmCalorie;
        private DataGridViewTextBoxColumn clmId;
    }
}