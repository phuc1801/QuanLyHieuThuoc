namespace QLHieuThuoc
{
    partial class frmMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.ibtnHome = new FontAwesome.Sharp.IconButton();
            this.ibtnLogout = new FontAwesome.Sharp.IconButton();
            this.ibtnSellMedine = new FontAwesome.Sharp.IconButton();
            this.ibtnMedicineVlyCheck = new FontAwesome.Sharp.IconButton();
            this.ibtnModifyMedicine = new FontAwesome.Sharp.IconButton();
            this.ibtnNewMedicine = new FontAwesome.Sharp.IconButton();
            this.ibtnAddMedicine = new FontAwesome.Sharp.IconButton();
            this.ibtnDashbord = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.ibtnProfile = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelShadow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.ibtnLogout);
            this.panelMenu.Controls.Add(this.ibtnProfile);
            this.panelMenu.Controls.Add(this.ibtnSellMedine);
            this.panelMenu.Controls.Add(this.ibtnMedicineVlyCheck);
            this.panelMenu.Controls.Add(this.ibtnModifyMedicine);
            this.panelMenu.Controls.Add(this.ibtnNewMedicine);
            this.panelMenu.Controls.Add(this.ibtnAddMedicine);
            this.panelMenu.Controls.Add(this.ibtnDashbord);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 708);
            this.panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 99);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.lblHome);
            this.panel1.Controls.Add(this.ibtnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(165, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 54);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHome.Location = new System.Drawing.Point(57, 17);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(35, 13);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "Home";
            // 
            // panelShadow
            // 
            this.panelShadow.Controls.Add(this.panelDesktop);
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShadow.Location = new System.Drawing.Point(165, 54);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(912, 654);
            this.panelShadow.TabIndex = 2;
            // 
            // ibtnHome
            // 
            this.ibtnHome.FlatAppearance.BorderSize = 0;
            this.ibtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.ibtnHome.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.ibtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnHome.IconSize = 40;
            this.ibtnHome.Location = new System.Drawing.Point(6, 4);
            this.ibtnHome.Name = "ibtnHome";
            this.ibtnHome.Size = new System.Drawing.Size(61, 38);
            this.ibtnHome.TabIndex = 0;
            this.ibtnHome.UseVisualStyleBackColor = true;
            this.ibtnHome.Click += new System.EventHandler(this.ibtnHome_Click);
            // 
            // ibtnLogout
            // 
            this.ibtnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnLogout.FlatAppearance.BorderSize = 0;
            this.ibtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.ibtnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ibtnLogout.IconColor = System.Drawing.Color.White;
            this.ibtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLogout.Location = new System.Drawing.Point(0, 523);
            this.ibtnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnLogout.Name = "ibtnLogout";
            this.ibtnLogout.Size = new System.Drawing.Size(165, 56);
            this.ibtnLogout.TabIndex = 9;
            this.ibtnLogout.Text = "Log Out";
            this.ibtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLogout.UseVisualStyleBackColor = true;
            this.ibtnLogout.Click += new System.EventHandler(this.ibtnLogout_Click);
            // 
            // ibtnSellMedine
            // 
            this.ibtnSellMedine.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnSellMedine.FlatAppearance.BorderSize = 0;
            this.ibtnSellMedine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSellMedine.ForeColor = System.Drawing.Color.Transparent;
            this.ibtnSellMedine.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.ibtnSellMedine.IconColor = System.Drawing.Color.White;
            this.ibtnSellMedine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSellMedine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSellMedine.Location = new System.Drawing.Point(0, 407);
            this.ibtnSellMedine.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnSellMedine.Name = "ibtnSellMedine";
            this.ibtnSellMedine.Size = new System.Drawing.Size(165, 61);
            this.ibtnSellMedine.TabIndex = 8;
            this.ibtnSellMedine.Text = "Sell Medicine";
            this.ibtnSellMedine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSellMedine.UseVisualStyleBackColor = true;
            this.ibtnSellMedine.Click += new System.EventHandler(this.ibtnSellMedine_Click);
            // 
            // ibtnMedicineVlyCheck
            // 
            this.ibtnMedicineVlyCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnMedicineVlyCheck.FlatAppearance.BorderSize = 0;
            this.ibtnMedicineVlyCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMedicineVlyCheck.ForeColor = System.Drawing.Color.Transparent;
            this.ibtnMedicineVlyCheck.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.ibtnMedicineVlyCheck.IconColor = System.Drawing.Color.White;
            this.ibtnMedicineVlyCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMedicineVlyCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMedicineVlyCheck.Location = new System.Drawing.Point(0, 346);
            this.ibtnMedicineVlyCheck.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnMedicineVlyCheck.Name = "ibtnMedicineVlyCheck";
            this.ibtnMedicineVlyCheck.Size = new System.Drawing.Size(165, 61);
            this.ibtnMedicineVlyCheck.TabIndex = 7;
            this.ibtnMedicineVlyCheck.Text = "MedicineVlyCheck";
            this.ibtnMedicineVlyCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnMedicineVlyCheck.UseVisualStyleBackColor = true;
            this.ibtnMedicineVlyCheck.Click += new System.EventHandler(this.ibtnMedicineVlyCheck_Click);
            // 
            // ibtnModifyMedicine
            // 
            this.ibtnModifyMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnModifyMedicine.FlatAppearance.BorderSize = 0;
            this.ibtnModifyMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnModifyMedicine.ForeColor = System.Drawing.Color.Transparent;
            this.ibtnModifyMedicine.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.ibtnModifyMedicine.IconColor = System.Drawing.Color.White;
            this.ibtnModifyMedicine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnModifyMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnModifyMedicine.Location = new System.Drawing.Point(0, 285);
            this.ibtnModifyMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnModifyMedicine.Name = "ibtnModifyMedicine";
            this.ibtnModifyMedicine.Size = new System.Drawing.Size(165, 61);
            this.ibtnModifyMedicine.TabIndex = 6;
            this.ibtnModifyMedicine.Text = "Modify Medicine";
            this.ibtnModifyMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnModifyMedicine.UseVisualStyleBackColor = true;
            this.ibtnModifyMedicine.Click += new System.EventHandler(this.ibtnModifyMedicine_Click);
            // 
            // ibtnNewMedicine
            // 
            this.ibtnNewMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnNewMedicine.FlatAppearance.BorderSize = 0;
            this.ibtnNewMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnNewMedicine.ForeColor = System.Drawing.Color.Transparent;
            this.ibtnNewMedicine.IconChar = FontAwesome.Sharp.IconChar.FolderTree;
            this.ibtnNewMedicine.IconColor = System.Drawing.Color.White;
            this.ibtnNewMedicine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnNewMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnNewMedicine.Location = new System.Drawing.Point(0, 224);
            this.ibtnNewMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnNewMedicine.Name = "ibtnNewMedicine";
            this.ibtnNewMedicine.Size = new System.Drawing.Size(165, 61);
            this.ibtnNewMedicine.TabIndex = 4;
            this.ibtnNewMedicine.Text = "New Medicine";
            this.ibtnNewMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnNewMedicine.UseVisualStyleBackColor = true;
            this.ibtnNewMedicine.Click += new System.EventHandler(this.ibtnNewMedicine_Click);
            // 
            // ibtnAddMedicine
            // 
            this.ibtnAddMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnAddMedicine.FlatAppearance.BorderSize = 0;
            this.ibtnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAddMedicine.ForeColor = System.Drawing.Color.Transparent;
            this.ibtnAddMedicine.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.ibtnAddMedicine.IconColor = System.Drawing.Color.White;
            this.ibtnAddMedicine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAddMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAddMedicine.Location = new System.Drawing.Point(0, 162);
            this.ibtnAddMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnAddMedicine.Name = "ibtnAddMedicine";
            this.ibtnAddMedicine.Size = new System.Drawing.Size(165, 62);
            this.ibtnAddMedicine.TabIndex = 2;
            this.ibtnAddMedicine.Text = "Add Medicine";
            this.ibtnAddMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAddMedicine.UseVisualStyleBackColor = true;
            this.ibtnAddMedicine.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // ibtnDashbord
            // 
            this.ibtnDashbord.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnDashbord.FlatAppearance.BorderSize = 0;
            this.ibtnDashbord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDashbord.ForeColor = System.Drawing.Color.Transparent;
            this.ibtnDashbord.IconChar = FontAwesome.Sharp.IconChar.ChessBoard;
            this.ibtnDashbord.IconColor = System.Drawing.Color.White;
            this.ibtnDashbord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDashbord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDashbord.Location = new System.Drawing.Point(0, 99);
            this.ibtnDashbord.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnDashbord.Name = "ibtnDashbord";
            this.ibtnDashbord.Size = new System.Drawing.Size(165, 63);
            this.ibtnDashbord.TabIndex = 1;
            this.ibtnDashbord.Text = "Dashbord";
            this.ibtnDashbord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDashbord.UseVisualStyleBackColor = true;
            this.ibtnDashbord.Click += new System.EventHandler(this.ibtnDashbord_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLHieuThuoc.Properties.Resources.logo_nha_thuoc_ovn;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(912, 651);
            this.panelDesktop.TabIndex = 0;
            // 
            // ibtnProfile
            // 
            this.ibtnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnProfile.FlatAppearance.BorderSize = 0;
            this.ibtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnProfile.ForeColor = System.Drawing.Color.Transparent;
            this.ibtnProfile.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ibtnProfile.IconColor = System.Drawing.Color.White;
            this.ibtnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnProfile.Location = new System.Drawing.Point(0, 468);
            this.ibtnProfile.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnProfile.Name = "ibtnProfile";
            this.ibtnProfile.Size = new System.Drawing.Size(165, 55);
            this.ibtnProfile.TabIndex = 10;
            this.ibtnProfile.Text = "Profile";
            this.ibtnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnProfile.UseVisualStyleBackColor = true;
            this.ibtnProfile.Click += new System.EventHandler(this.ibtnProfile_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 708);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelShadow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton ibtnNewMedicine;
        private FontAwesome.Sharp.IconButton ibtnAddMedicine;
        private FontAwesome.Sharp.IconButton ibtnDashbord;
        private FontAwesome.Sharp.IconButton ibtnLogout;
        private FontAwesome.Sharp.IconButton ibtnSellMedine;
        private FontAwesome.Sharp.IconButton ibtnMedicineVlyCheck;
        private FontAwesome.Sharp.IconButton ibtnModifyMedicine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ibtnHome;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton ibtnProfile;
    }
}