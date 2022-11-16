﻿namespace WinFormUI
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnUpdateMeal = new System.Windows.Forms.Button();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.ssrMain = new System.Windows.Forms.StatusStrip();
            this.tssActiveUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssCurrentDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlNavItems = new System.Windows.Forms.Panel();
            this.pnlNavigation.SuspendLayout();
            this.ssrMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavigation.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.pnlNavigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNavigation.Controls.Add(this.btnClose);
            this.pnlNavigation.Controls.Add(this.btnAccount);
            this.pnlNavigation.Controls.Add(this.btnUpdateMeal);
            this.pnlNavigation.Controls.Add(this.btnAddMeal);
            this.pnlNavigation.Controls.Add(this.btnMainPage);
            this.pnlNavigation.Controls.Add(this.ssrMain);
            this.pnlNavigation.Controls.Add(this.lblAppName);
            this.pnlNavigation.Controls.Add(this.lblLogo);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(275, 450);
            this.pnlNavigation.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(187, 391);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Çıkış";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(48, 329);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(182, 45);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "Hesap";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnUpdateMeal
            // 
            this.btnUpdateMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdateMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateMeal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdateMeal.FlatAppearance.BorderSize = 0;
            this.btnUpdateMeal.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnUpdateMeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnUpdateMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMeal.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateMeal.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMeal.Location = new System.Drawing.Point(48, 263);
            this.btnUpdateMeal.Name = "btnUpdateMeal";
            this.btnUpdateMeal.Size = new System.Drawing.Size(182, 45);
            this.btnUpdateMeal.TabIndex = 1;
            this.btnUpdateMeal.Text = "Öğün İşlemleri";
            this.btnUpdateMeal.UseVisualStyleBackColor = false;
            this.btnUpdateMeal.Click += new System.EventHandler(this.btnUpdateMeal_Click);
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMeal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddMeal.FlatAppearance.BorderSize = 0;
            this.btnAddMeal.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAddMeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAddMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMeal.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMeal.ForeColor = System.Drawing.Color.White;
            this.btnAddMeal.Location = new System.Drawing.Point(48, 197);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(182, 45);
            this.btnAddMeal.TabIndex = 1;
            this.btnAddMeal.Text = "Öğün Ekle";
            this.btnAddMeal.UseVisualStyleBackColor = false;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // btnMainPage
            // 
            this.btnMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMainPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMainPage.FlatAppearance.BorderSize = 0;
            this.btnMainPage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnMainPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainPage.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainPage.ForeColor = System.Drawing.Color.White;
            this.btnMainPage.Location = new System.Drawing.Point(48, 131);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(182, 45);
            this.btnMainPage.TabIndex = 1;
            this.btnMainPage.Text = "Ana Sayfa";
            this.btnMainPage.UseVisualStyleBackColor = false;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // ssrMain
            // 
            this.ssrMain.BackColor = System.Drawing.Color.Transparent;
            this.ssrMain.Font = new System.Drawing.Font("ISOCPEUR", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ssrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssActiveUser,
            this.tssCurrentDate});
            this.ssrMain.Location = new System.Drawing.Point(0, 428);
            this.ssrMain.Name = "ssrMain";
            this.ssrMain.Size = new System.Drawing.Size(275, 22);
            this.ssrMain.TabIndex = 1;
            this.ssrMain.Text = "statusStrip2";
            // 
            // tssActiveUser
            // 
            this.tssActiveUser.Name = "tssActiveUser";
            this.tssActiveUser.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.tssActiveUser.Size = new System.Drawing.Size(132, 17);
            this.tssActiveUser.Text = "AKTİF KULLANICI";
            // 
            // tssCurrentDate
            // 
            this.tssCurrentDate.Margin = new System.Windows.Forms.Padding(15, 3, 0, 2);
            this.tssCurrentDate.Name = "tssCurrentDate";
            this.tssCurrentDate.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.tssCurrentDate.Size = new System.Drawing.Size(99, 17);
            this.tssCurrentDate.Text = "GÜNCEL TARİH";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.Font = new System.Drawing.Font("ISOCPEUR", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(52, 75);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(175, 31);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "UYGULAMA İSMİ";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("ISOCPEUR", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(107, 25);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(65, 31);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "LOGO";
            // 
            // pnlNavItems
            // 
            this.pnlNavItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavItems.Location = new System.Drawing.Point(275, 0);
            this.pnlNavItems.Name = "pnlNavItems";
            this.pnlNavItems.Size = new System.Drawing.Size(655, 450);
            this.pnlNavItems.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlNavItems);
            this.Controls.Add(this.pnlNavigation);
            this.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Kalori Takip Taslak";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.ssrMain.ResumeLayout(false);
            this.ssrMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlNavigation;
        private Button btnClose;
        private Button btnAccount;
        private Button btnUpdateMeal;
        private Button btnAddMeal;
        private Button btnMainPage;
        private StatusStrip ssrMain;
        private ToolStripStatusLabel tssActiveUser;
        private Label lblAppName;
        private Label lblLogo;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button7;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ToolStripStatusLabel tssCurrentDate;
        private Panel pnlNavItems;
    }
}