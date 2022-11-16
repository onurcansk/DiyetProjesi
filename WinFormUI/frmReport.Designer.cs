namespace ArayüzÇalışma
{
    partial class frmReport
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
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.dgvMealView = new System.Windows.Forms.DataGridView();
            this.lblDailyCalorie = new System.Windows.Forms.Label();
            this.lblCalorieValue = new System.Windows.Forms.Label();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstMealType = new System.Windows.Forms.ListBox();
            this.clmCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmPiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCalorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDay
            // 
            this.dtpDay.CalendarForeColor = System.Drawing.SystemColors.Window;
            this.dtpDay.CalendarTitleBackColor = System.Drawing.SystemColors.Window;
            this.dtpDay.CalendarTitleForeColor = System.Drawing.SystemColors.Window;
            this.dtpDay.CalendarTrailingForeColor = System.Drawing.SystemColors.Window;
            this.dtpDay.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDay.Location = new System.Drawing.Point(35, 29);
            this.dtpDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(210, 27);
            this.dtpDay.TabIndex = 1;
            // 
            // dgvMealView
            // 
            this.dgvMealView.AllowUserToDeleteRows = false;
            this.dgvMealView.AllowUserToOrderColumns = true;
            this.dgvMealView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMealView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvMealView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMealView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCategory,
            this.clmFood,
            this.clmImg,
            this.clmPiece,
            this.clmCalorie});
            this.dgvMealView.Location = new System.Drawing.Point(193, 80);
            this.dgvMealView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMealView.Name = "dgvMealView";
            this.dgvMealView.ReadOnly = true;
            this.dgvMealView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N1";
            dataGridViewCellStyle1.NullValue = "1";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMealView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMealView.RowHeadersWidth = 40;
            this.dgvMealView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMealView.RowTemplate.Height = 25;
            this.dgvMealView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMealView.Size = new System.Drawing.Size(422, 294);
            this.dgvMealView.TabIndex = 3;
            // 
            // lblDailyCalorie
            // 
            this.lblDailyCalorie.AutoSize = true;
            this.lblDailyCalorie.BackColor = System.Drawing.Color.Transparent;
            this.lblDailyCalorie.Font = new System.Drawing.Font("ISOCPEUR", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDailyCalorie.Location = new System.Drawing.Point(35, 411);
            this.lblDailyCalorie.Name = "lblDailyCalorie";
            this.lblDailyCalorie.Size = new System.Drawing.Size(181, 24);
            this.lblDailyCalorie.TabIndex = 2;
            this.lblDailyCalorie.Text = "Günlük Toplam Kalori :";
            // 
            // lblCalorieValue
            // 
            this.lblCalorieValue.AutoSize = true;
            this.lblCalorieValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCalorieValue.Font = new System.Drawing.Font("ISOCPEUR", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalorieValue.Location = new System.Drawing.Point(222, 411);
            this.lblCalorieValue.Name = "lblCalorieValue";
            this.lblCalorieValue.Size = new System.Drawing.Size(54, 24);
            this.lblCalorieValue.TabIndex = 2;
            this.lblCalorieValue.Text = "Değer";
            // 
            // btnGetReport
            // 
            this.btnGetReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGetReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGetReport.FlatAppearance.BorderSize = 0;
            this.btnGetReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGetReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnGetReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetReport.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetReport.ForeColor = System.Drawing.Color.White;
            this.btnGetReport.Location = new System.Drawing.Point(279, 29);
            this.btnGetReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(83, 27);
            this.btnGetReport.TabIndex = 2;
            this.btnGetReport.Text = "Raporla";
            this.btnGetReport.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(478, 397);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Düzenle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("ISOCPEUR", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(580, 397);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(35, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lstMealType
            // 
            this.lstMealType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lstMealType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMealType.ForeColor = System.Drawing.Color.White;
            this.lstMealType.FormattingEnabled = true;
            this.lstMealType.ItemHeight = 21;
            this.lstMealType.Location = new System.Drawing.Point(35, 80);
            this.lstMealType.Name = "lstMealType";
            this.lstMealType.Size = new System.Drawing.Size(139, 294);
            this.lstMealType.TabIndex = 6;
            // 
            // clmCategory
            // 
            this.clmCategory.HeaderText = "Kategori";
            this.clmCategory.Name = "clmCategory";
            this.clmCategory.ReadOnly = true;
            this.clmCategory.Width = 90;
            // 
            // clmFood
            // 
            this.clmFood.HeaderText = "Yemek";
            this.clmFood.Name = "clmFood";
            this.clmFood.ReadOnly = true;
            this.clmFood.Width = 130;
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
            this.clmPiece.Width = 55;
            // 
            // clmCalorie
            // 
            this.clmCalorie.HeaderText = "Kalori";
            this.clmCalorie.Name = "clmCalorie";
            this.clmCalorie.ReadOnly = true;
            this.clmCalorie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCalorie.Width = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("ISOCPEUR", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğün Toplam Kalori :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("ISOCPEUR", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(222, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Değer";
            // 
            // frmReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::ArayüzÇalışma.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.lstMealType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCalorieValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDailyCalorie);
            this.Controls.Add(this.dgvMealView);
            this.Controls.Add(this.dtpDay);
            this.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReport";
            this.Text = "frmReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpDay;
        private DataGridView dgvMealView;
        private Label lblDailyCalorie;
        private Label lblCalorieValue;
        private Button btnGetReport;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridViewTextBoxColumn clmCategory;
        private DataGridViewTextBoxColumn clmFood;
        private DataGridViewImageColumn clmImg;
        private DataGridViewTextBoxColumn clmPiece;
        private DataGridViewTextBoxColumn clmCalorie;
        private ListBox lstMealType;
        private Label label1;
        private Label label2;
    }
}