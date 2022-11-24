﻿namespace WinFormUI
{
    partial class frmAdminFood
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
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.mnsFood = new System.Windows.Forms.MenuStrip();
            this.tsmMealType = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMealView = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Aktif = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCalorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnsFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(16, 28);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(226, 28);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.Text = "Kategori";
            // 
            // mnsFood
            // 
            this.mnsFood.BackColor = System.Drawing.SystemColors.Window;
            this.mnsFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnsFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnsFood.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mnsFood.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMealType,
            this.tsmCategory});
            this.mnsFood.Location = new System.Drawing.Point(0, 0);
            this.mnsFood.Name = "mnsFood";
            this.mnsFood.Size = new System.Drawing.Size(813, 24);
            this.mnsFood.TabIndex = 3;
            this.mnsFood.Text = "menuStrip1";
            // 
            // tsmMealType
            // 
            this.tsmMealType.Name = "tsmMealType";
            this.tsmMealType.Size = new System.Drawing.Size(103, 20);
            this.tsmMealType.Text = "Öğün Düzenle";
            this.tsmMealType.Click += new System.EventHandler(this.tsmMealType_Click);
            // 
            // tsmCategory
            // 
            this.tsmCategory.Name = "tsmCategory";
            this.tsmCategory.Size = new System.Drawing.Size(121, 20);
            this.tsmCategory.Text = "Kategori Düzenle";
            this.tsmCategory.Click += new System.EventHandler(this.tsmCategory_Click);
            // 
            // dgvMealView
            // 
            this.dgvMealView.AllowUserToAddRows = false;
            this.dgvMealView.AllowUserToDeleteRows = false;
            this.dgvMealView.AllowUserToOrderColumns = true;
            this.dgvMealView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvMealView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMealView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aktif,
            this.clmCategory,
            this.clmFood,
            this.clmCalorie,
            this.clmImg,
            this.clmId});
            this.dgvMealView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMealView.Location = new System.Drawing.Point(0, 64);
            this.dgvMealView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMealView.MultiSelect = false;
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
            this.dgvMealView.RowHeadersVisible = false;
            this.dgvMealView.RowHeadersWidth = 40;
            this.dgvMealView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMealView.RowTemplate.Height = 100;
            this.dgvMealView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMealView.Size = new System.Drawing.Size(813, 366);
            this.dgvMealView.TabIndex = 5;
            this.dgvMealView.SelectionChanged += new System.EventHandler(this.dgvMealView_SelectionChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(248, 28);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(85, 29);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(339, 28);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 29);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(627, 28);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 29);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Seçimi Düzenle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(514, 28);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(107, 29);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "Yeni Ekle";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(756, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 29);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // Aktif
            // 
            this.Aktif.HeaderText = "Aktif";
            this.Aktif.Name = "Aktif";
            this.Aktif.ReadOnly = true;
            this.Aktif.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Aktif.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Aktif.Width = 50;
            // 
            // clmCategory
            // 
            this.clmCategory.HeaderText = "Kategori";
            this.clmCategory.Name = "clmCategory";
            this.clmCategory.ReadOnly = true;
            this.clmCategory.Width = 200;
            // 
            // clmFood
            // 
            this.clmFood.HeaderText = "Yemek";
            this.clmFood.Name = "clmFood";
            this.clmFood.ReadOnly = true;
            this.clmFood.Width = 250;
            // 
            // clmCalorie
            // 
            this.clmCalorie.HeaderText = "Birim Kalori";
            this.clmCalorie.Name = "clmCalorie";
            this.clmCalorie.ReadOnly = true;
            this.clmCalorie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCalorie.Width = 120;
            // 
            // clmImg
            // 
            this.clmImg.HeaderText = "Resim";
            this.clmImg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.clmImg.Name = "clmImg";
            this.clmImg.ReadOnly = true;
            this.clmImg.Width = 200;
            // 
            // clmId
            // 
            this.clmId.HeaderText = "ID";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            // 
            // frmAdminFood
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 430);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dgvMealView);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.mnsFood);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnsFood;
            this.Name = "frmAdminFood";
            this.Text = "frmAdminFood";
            this.mnsFood.ResumeLayout(false);
            this.mnsFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cmbCategory;
        private MenuStrip mnsFood;
        private ToolStripMenuItem tsmMealType;
        private DataGridView dgvMealView;
        private ToolStripMenuItem tsmCategory;
        private Button btnFilter;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnAddNew;
        private Button btnDelete;
        private DataGridViewCheckBoxColumn Aktif;
        private DataGridViewTextBoxColumn clmCategory;
        private DataGridViewTextBoxColumn clmFood;
        private DataGridViewTextBoxColumn clmCalorie;
        private DataGridViewImageColumn clmImg;
        private DataGridViewTextBoxColumn clmId;
    }
}