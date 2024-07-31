﻿namespace WinFormsApp_QL
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            panelMenu = new Panel();
            buttonEtc = new Button();
            buttonReport = new Button();
            buttonPet = new Button();
            buttonCus = new Button();
            buttonEmp = new Button();
            buttonHome = new Button();
            panelUser = new Panel();
            labelUser = new Label();
            pictureBoxUser = new PictureBox();
            pictureBoxExit = new PictureBox();
            tabControl1 = new TabControl();
            tabPageReport = new TabPage();
            buttonBilling = new Button();
            buttonRepFin = new Button();
            buttonRepInventory = new Button();
            buttonRepStaff = new Button();
            buttonRepSale = new Button();
            panelMenu.SuspendLayout();
            panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).BeginInit();
            tabControl1.SuspendLayout();
            tabPageReport.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Plum;
            panelMenu.Controls.Add(buttonEtc);
            panelMenu.Controls.Add(buttonReport);
            panelMenu.Controls.Add(buttonPet);
            panelMenu.Controls.Add(buttonCus);
            panelMenu.Controls.Add(buttonEmp);
            panelMenu.Controls.Add(buttonHome);
            panelMenu.Controls.Add(panelUser);
            panelMenu.Dock = DockStyle.Right;
            panelMenu.ForeColor = SystemColors.ControlText;
            panelMenu.Location = new Point(662, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(159, 488);
            panelMenu.TabIndex = 5;
            // 
            // buttonEtc
            // 
            buttonEtc.BackColor = Color.FromArgb(181, 51, 137);
            buttonEtc.Cursor = Cursors.Hand;
            buttonEtc.Dock = DockStyle.Top;
            buttonEtc.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonEtc.FlatAppearance.BorderSize = 0;
            buttonEtc.FlatAppearance.CheckedBackColor = Color.FromArgb(222, 111, 161);
            buttonEtc.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 111, 161);
            buttonEtc.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 111, 161);
            buttonEtc.FlatStyle = FlatStyle.Flat;
            buttonEtc.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            buttonEtc.ForeColor = Color.LavenderBlush;
            buttonEtc.Image = (Image)resources.GetObject("buttonEtc.Image");
            buttonEtc.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEtc.Location = new Point(0, 426);
            buttonEtc.Name = "buttonEtc";
            buttonEtc.Padding = new Padding(10, 0, 0, 0);
            buttonEtc.Size = new Size(159, 61);
            buttonEtc.TabIndex = 7;
            buttonEtc.Text = " Logout";
            buttonEtc.TextAlign = ContentAlignment.MiddleLeft;
            buttonEtc.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEtc.UseVisualStyleBackColor = false;
            buttonEtc.Click += buttonLogout_Click;
            // 
            // buttonReport
            // 
            buttonReport.BackColor = Color.FromArgb(181, 51, 137);
            buttonReport.Cursor = Cursors.Hand;
            buttonReport.Dock = DockStyle.Top;
            buttonReport.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.FlatAppearance.CheckedBackColor = Color.FromArgb(222, 111, 161);
            buttonReport.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 111, 161);
            buttonReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 111, 161);
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            buttonReport.ForeColor = Color.LavenderBlush;
            buttonReport.Image = (Image)resources.GetObject("buttonReport.Image");
            buttonReport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReport.Location = new Point(0, 365);
            buttonReport.Name = "buttonReport";
            buttonReport.Padding = new Padding(10, 0, 0, 0);
            buttonReport.Size = new Size(159, 61);
            buttonReport.TabIndex = 6;
            buttonReport.Text = " Report";
            buttonReport.TextAlign = ContentAlignment.MiddleLeft;
            buttonReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReport.UseVisualStyleBackColor = false;
            buttonReport.Click += button_Click;
            // 
            // buttonPet
            // 
            buttonPet.BackColor = Color.FromArgb(181, 51, 137);
            buttonPet.Cursor = Cursors.Hand;
            buttonPet.Dock = DockStyle.Top;
            buttonPet.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonPet.FlatAppearance.BorderSize = 0;
            buttonPet.FlatAppearance.CheckedBackColor = Color.FromArgb(222, 111, 161);
            buttonPet.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 111, 161);
            buttonPet.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 111, 161);
            buttonPet.FlatStyle = FlatStyle.Flat;
            buttonPet.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            buttonPet.ForeColor = Color.LavenderBlush;
            buttonPet.Image = (Image)resources.GetObject("buttonPet.Image");
            buttonPet.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPet.Location = new Point(0, 304);
            buttonPet.Name = "buttonPet";
            buttonPet.Padding = new Padding(10, 0, 0, 0);
            buttonPet.Size = new Size(159, 61);
            buttonPet.TabIndex = 5;
            buttonPet.Text = " Pet's";
            buttonPet.TextAlign = ContentAlignment.MiddleLeft;
            buttonPet.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPet.UseVisualStyleBackColor = false;
            buttonPet.Click += GotoPet;
            // 
            // buttonCus
            // 
            buttonCus.BackColor = Color.FromArgb(181, 51, 137);
            buttonCus.Cursor = Cursors.Hand;
            buttonCus.Dock = DockStyle.Top;
            buttonCus.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonCus.FlatAppearance.BorderSize = 0;
            buttonCus.FlatAppearance.CheckedBackColor = Color.FromArgb(222, 111, 161);
            buttonCus.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 111, 161);
            buttonCus.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 111, 161);
            buttonCus.FlatStyle = FlatStyle.Flat;
            buttonCus.Font = new Font("Segoe UI Historic", 9.9F, FontStyle.Bold);
            buttonCus.ForeColor = Color.LavenderBlush;
            buttonCus.Image = (Image)resources.GetObject("buttonCus.Image");
            buttonCus.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCus.Location = new Point(0, 243);
            buttonCus.Name = "buttonCus";
            buttonCus.Padding = new Padding(9, 0, 0, 0);
            buttonCus.Size = new Size(159, 61);
            buttonCus.TabIndex = 4;
            buttonCus.Text = " Customer";
            buttonCus.TextAlign = ContentAlignment.MiddleLeft;
            buttonCus.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCus.UseVisualStyleBackColor = false;
            buttonCus.Click += GotoCus;
            // 
            // buttonEmp
            // 
            buttonEmp.BackColor = Color.FromArgb(181, 51, 137);
            buttonEmp.Cursor = Cursors.Hand;
            buttonEmp.Dock = DockStyle.Top;
            buttonEmp.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonEmp.FlatAppearance.BorderSize = 0;
            buttonEmp.FlatAppearance.CheckedBackColor = Color.FromArgb(222, 111, 161);
            buttonEmp.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 111, 161);
            buttonEmp.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 111, 161);
            buttonEmp.FlatStyle = FlatStyle.Flat;
            buttonEmp.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            buttonEmp.ForeColor = Color.LavenderBlush;
            buttonEmp.Image = (Image)resources.GetObject("buttonEmp.Image");
            buttonEmp.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEmp.Location = new Point(0, 182);
            buttonEmp.Name = "buttonEmp";
            buttonEmp.Padding = new Padding(10, 0, 0, 0);
            buttonEmp.Size = new Size(159, 61);
            buttonEmp.TabIndex = 3;
            buttonEmp.Text = " Employee";
            buttonEmp.TextAlign = ContentAlignment.MiddleLeft;
            buttonEmp.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEmp.UseVisualStyleBackColor = false;
            buttonEmp.Click += GotoEmp;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.FromArgb(181, 51, 137);
            buttonHome.Cursor = Cursors.Hand;
            buttonHome.Dock = DockStyle.Top;
            buttonHome.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatAppearance.CheckedBackColor = Color.FromArgb(254, 78, 218);
            buttonHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 111, 161);
            buttonHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 111, 161);
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            buttonHome.ForeColor = Color.LavenderBlush;
            buttonHome.Image = (Image)resources.GetObject("buttonHome.Image");
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(0, 121);
            buttonHome.Margin = new Padding(0);
            buttonHome.Name = "buttonHome";
            buttonHome.Padding = new Padding(10, 0, 0, 0);
            buttonHome.Size = new Size(159, 61);
            buttonHome.TabIndex = 2;
            buttonHome.Text = " Home";
            buttonHome.TextAlign = ContentAlignment.MiddleLeft;
            buttonHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += GotoHome;
            // 
            // panelUser
            // 
            panelUser.BackColor = Color.FromArgb(181, 51, 137);
            panelUser.Controls.Add(labelUser);
            panelUser.Controls.Add(pictureBoxUser);
            panelUser.Controls.Add(pictureBoxExit);
            panelUser.Dock = DockStyle.Top;
            panelUser.ForeColor = SystemColors.ControlText;
            panelUser.Location = new Point(0, 0);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(159, 121);
            panelUser.TabIndex = 1;
            panelUser.MouseDown += panelUser_MouseDown;
            // 
            // labelUser
            // 
            labelUser.Cursor = Cursors.Hand;
            labelUser.Dock = DockStyle.Bottom;
            labelUser.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            labelUser.ForeColor = Color.LavenderBlush;
            labelUser.Location = new Point(0, 76);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(159, 45);
            labelUser.TabIndex = 2;
            labelUser.Text = "User Name";
            labelUser.TextAlign = ContentAlignment.MiddleCenter;
            labelUser.MouseDown += labelUserName_MouseDown;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Cursor = Cursors.Hand;
            pictureBoxUser.Image = (Image)resources.GetObject("pictureBoxUser.Image");
            pictureBoxUser.Location = new Point(50, 12);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(66, 72);
            pictureBoxUser.TabIndex = 1;
            pictureBoxUser.TabStop = false;
            pictureBoxUser.MouseDown += pictureBoxUser_MouseDown;
            // 
            // pictureBoxExit
            // 
            pictureBoxExit.BackColor = Color.Transparent;
            pictureBoxExit.Cursor = Cursors.Hand;
            pictureBoxExit.Image = (Image)resources.GetObject("pictureBoxExit.Image");
            pictureBoxExit.Location = new Point(128, 11);
            pictureBoxExit.Name = "pictureBoxExit";
            pictureBoxExit.Size = new Size(32, 31);
            pictureBoxExit.TabIndex = 0;
            pictureBoxExit.TabStop = false;
            pictureBoxExit.Click += pictureBoxExit_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageReport);
            tabControl1.Cursor = Cursors.Hand;
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            tabControl1.ItemSize = new Size(150, 28);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(662, 488);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 7;
            tabControl1.MouseDown += tabControl1_MouseDown;
            // 
            // tabPageReport
            // 
            tabPageReport.BackgroundImage = (Image)resources.GetObject("tabPageReport.BackgroundImage");
            tabPageReport.BackgroundImageLayout = ImageLayout.None;
            tabPageReport.Controls.Add(buttonBilling);
            tabPageReport.Controls.Add(buttonRepFin);
            tabPageReport.Controls.Add(buttonRepInventory);
            tabPageReport.Controls.Add(buttonRepStaff);
            tabPageReport.Controls.Add(buttonRepSale);
            tabPageReport.Cursor = Cursors.Hand;
            tabPageReport.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            tabPageReport.ForeColor = Color.LavenderBlush;
            tabPageReport.Location = new Point(4, 32);
            tabPageReport.Name = "tabPageReport";
            tabPageReport.Padding = new Padding(3);
            tabPageReport.Size = new Size(654, 452);
            tabPageReport.TabIndex = 1;
            tabPageReport.Text = "Report";
            tabPageReport.UseVisualStyleBackColor = true;
            tabPageReport.MouseDown += tabPageReport_MouseDown;
            // 
            // buttonBilling
            // 
            buttonBilling.BackColor = Color.FromArgb(222, 111, 161);
            buttonBilling.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonBilling.FlatAppearance.BorderSize = 0;
            buttonBilling.FlatStyle = FlatStyle.Flat;
            buttonBilling.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBilling.ForeColor = Color.LavenderBlush;
            buttonBilling.Location = new Point(370, 200);
            buttonBilling.Name = "buttonBilling";
            buttonBilling.Size = new Size(200, 100);
            buttonBilling.TabIndex = 19;
            buttonBilling.Text = "Billing";
            buttonBilling.UseVisualStyleBackColor = false;
            buttonBilling.Click += buttonBilling_Click;
            // 
            // buttonRepFin
            // 
            buttonRepFin.BackColor = Color.FromArgb(222, 111, 161);
            buttonRepFin.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonRepFin.FlatAppearance.BorderSize = 0;
            buttonRepFin.FlatStyle = FlatStyle.Flat;
            buttonRepFin.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRepFin.ForeColor = Color.LavenderBlush;
            buttonRepFin.Location = new Point(214, 200);
            buttonRepFin.Name = "buttonRepFin";
            buttonRepFin.Size = new Size(145, 100);
            buttonRepFin.TabIndex = 16;
            buttonRepFin.Text = "Transaction History";
            buttonRepFin.UseVisualStyleBackColor = false;
            buttonRepFin.Click += buttonRepFin_Click;
            // 
            // buttonRepInventory
            // 
            buttonRepInventory.BackColor = Color.FromArgb(222, 111, 161);
            buttonRepInventory.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonRepInventory.FlatAppearance.BorderSize = 0;
            buttonRepInventory.FlatStyle = FlatStyle.Flat;
            buttonRepInventory.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRepInventory.ForeColor = Color.LavenderBlush;
            buttonRepInventory.Location = new Point(60, 200);
            buttonRepInventory.Name = "buttonRepInventory";
            buttonRepInventory.Size = new Size(145, 100);
            buttonRepInventory.TabIndex = 14;
            buttonRepInventory.Text = "Inventory And Service";
            buttonRepInventory.UseVisualStyleBackColor = false;
            buttonRepInventory.Click += buttonRepInventory_Click;
            // 
            // buttonRepStaff
            // 
            buttonRepStaff.BackColor = Color.FromArgb(222, 111, 161);
            buttonRepStaff.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonRepStaff.FlatAppearance.BorderSize = 0;
            buttonRepStaff.FlatStyle = FlatStyle.Flat;
            buttonRepStaff.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRepStaff.ForeColor = Color.LavenderBlush;
            buttonRepStaff.Location = new Point(370, 90);
            buttonRepStaff.Name = "buttonRepStaff";
            buttonRepStaff.Size = new Size(200, 100);
            buttonRepStaff.TabIndex = 13;
            buttonRepStaff.Text = "Staff List";
            buttonRepStaff.UseVisualStyleBackColor = false;
            buttonRepStaff.Click += buttonRepStaff_Click;
            // 
            // buttonRepSale
            // 
            buttonRepSale.BackColor = Color.FromArgb(222, 111, 161);
            buttonRepSale.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonRepSale.FlatAppearance.BorderSize = 0;
            buttonRepSale.FlatStyle = FlatStyle.Flat;
            buttonRepSale.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRepSale.ForeColor = Color.LavenderBlush;
            buttonRepSale.Location = new Point(60, 90);
            buttonRepSale.Name = "buttonRepSale";
            buttonRepSale.Size = new Size(299, 100);
            buttonRepSale.TabIndex = 12;
            buttonRepSale.Text = "Sales Report";
            buttonRepSale.UseVisualStyleBackColor = false;
            buttonRepSale.Click += buttonRepSale_Click;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 488);
            Controls.Add(tabControl1);
            Controls.Add(panelMenu);
            DoubleBuffered = true;
            Name = "Report";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report";
            Load += Report_Load;
            panelMenu.ResumeLayout(false);
            panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageReport.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button buttonEtc;
        private Button buttonReport;
        private Button buttonPet;
        private Button buttonCus;
        private Button buttonEmp;
        private Button buttonHome;
        private Panel panelUser;
        private Label labelUser;
        private PictureBox pictureBoxUser;
        private PictureBox pictureBoxExit;
        private TabControl tabControl1;
        private TabPage tabPageList;
        private Label labelSearch;
        private DataGridView dataGridView1;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private TabPage tabPageReport;
        private Button buttonRepFin;
        private Button buttonRepInventory;
        private Button buttonRepStaff;
        private Button buttonRepSale;
        private Button buttonBilling;
    }
}