namespace WinFormUI
{
    partial class frmAdminUpdateFood
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtUnitCalorie = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(90, 175);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 40);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(28, 30);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(240, 29);
            this.cmbCategory.TabIndex = 5;
            this.cmbCategory.Text = "Kategori";
            // 
            // txtUnitCalorie
            // 
            this.txtUnitCalorie.Location = new System.Drawing.Point(28, 126);
            this.txtUnitCalorie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnitCalorie.Name = "txtUnitCalorie";
            this.txtUnitCalorie.PlaceholderText = "Birim Kalori";
            this.txtUnitCalorie.Size = new System.Drawing.Size(240, 27);
            this.txtUnitCalorie.TabIndex = 3;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(28, 79);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.PlaceholderText = "Yemek Adı";
            this.txtFoodName.Size = new System.Drawing.Size(240, 27);
            this.txtFoodName.TabIndex = 4;
            // 
            // frmAdminUpdateFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(295, 233);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtUnitCalorie);
            this.Controls.Add(this.txtFoodName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminUpdateFood";
            this.ShowIcon = false;
            this.Text = "Yemek Düzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdate;
        private ComboBox cmbCategory;
        private TextBox txtUnitCalorie;
        private TextBox txtFoodName;
    }
}