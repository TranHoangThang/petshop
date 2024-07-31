namespace WinFormsApp_QL
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            buttonEtc = new Button();
            buttonRep = new Button();
            buttonPet = new Button();
            buttonCus = new Button();
            buttonEmp = new Button();
            buttonHome = new Button();
            panel2 = new Panel();
            labelUser = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            labelQ2 = new Label();
            labelQ1 = new Label();
            labelQ3 = new Label();
            labelQ4 = new Label();
            labelQ5 = new Label();
            pictureBoxDog = new PictureBox();
            pictureBoxPen = new PictureBox();
            GroupAbout = new Button();
            AppAbout = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Plum;
            panel1.Controls.Add(buttonEtc);
            panel1.Controls.Add(buttonRep);
            panel1.Controls.Add(buttonPet);
            panel1.Controls.Add(buttonCus);
            panel1.Controls.Add(buttonEmp);
            panel1.Controls.Add(buttonHome);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(661, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(159, 488);
            panel1.TabIndex = 0;
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
            buttonEtc.Size = new Size(159, 62);
            buttonEtc.TabIndex = 7;
            buttonEtc.Text = " Logout";
            buttonEtc.TextAlign = ContentAlignment.MiddleLeft;
            buttonEtc.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEtc.UseVisualStyleBackColor = false;
            buttonEtc.Click += buttonLogout_Click;
            // 
            // buttonRep
            // 
            buttonRep.BackColor = Color.FromArgb(181, 51, 137);
            buttonRep.Cursor = Cursors.Hand;
            buttonRep.Dock = DockStyle.Top;
            buttonRep.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonRep.FlatAppearance.BorderSize = 0;
            buttonRep.FlatAppearance.CheckedBackColor = Color.FromArgb(222, 111, 161);
            buttonRep.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 111, 161);
            buttonRep.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 111, 161);
            buttonRep.FlatStyle = FlatStyle.Flat;
            buttonRep.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            buttonRep.ForeColor = Color.LavenderBlush;
            buttonRep.Image = (Image)resources.GetObject("buttonRep.Image");
            buttonRep.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRep.Location = new Point(0, 365);
            buttonRep.Name = "buttonRep";
            buttonRep.Padding = new Padding(10, 0, 0, 0);
            buttonRep.Size = new Size(159, 61);
            buttonRep.TabIndex = 6;
            buttonRep.Text = " Report";
            buttonRep.TextAlign = ContentAlignment.MiddleLeft;
            buttonRep.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRep.UseVisualStyleBackColor = false;
            buttonRep.Click += GotoRep;
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
            buttonHome.Click += button_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(181, 51, 137);
            panel2.Controls.Add(labelUser);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(159, 121);
            panel2.TabIndex = 1;
            panel2.MouseDown += panel2_MouseDown;
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
            labelUser.MouseDown += labelUser_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(50, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 72);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += pictureBox3_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(128, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 31);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(661, 488);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // labelQ2
            // 
            labelQ2.AutoSize = true;
            labelQ2.BackColor = SystemColors.Desktop;
            labelQ2.Font = new Font("Segoe UI Variable Display", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQ2.ForeColor = Color.Yellow;
            labelQ2.Location = new Point(73, 141);
            labelQ2.Name = "labelQ2";
            labelQ2.Size = new Size(402, 63);
            labelQ2.TabIndex = 2;
            labelQ2.Text = "Growing Success";
            labelQ2.MouseDown += labelQ2_MouseDown;
            // 
            // labelQ1
            // 
            labelQ1.AutoSize = true;
            labelQ1.BackColor = SystemColors.Desktop;
            labelQ1.Font = new Font("Segoe UI Variable Display", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQ1.ForeColor = Color.Chartreuse;
            labelQ1.Location = new Point(73, 85);
            labelQ1.Name = "labelQ1";
            labelQ1.Size = new Size(353, 63);
            labelQ1.TabIndex = 3;
            labelQ1.Text = "Nurturing Pets";
            labelQ1.MouseDown += labelQ1_MouseDown;
            // 
            // labelQ3
            // 
            labelQ3.AutoSize = true;
            labelQ3.BackColor = SystemColors.Desktop;
            labelQ3.Font = new Font("Segoe UI Variable Small Semibol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQ3.ForeColor = Color.LavenderBlush;
            labelQ3.Location = new Point(73, 218);
            labelQ3.Name = "labelQ3";
            labelQ3.Size = new Size(351, 31);
            labelQ3.TabIndex = 4;
            labelQ3.Text = "Don't Get Catty About Business";
            labelQ3.MouseDown += labelQ3_MouseDown;
            // 
            // labelQ4
            // 
            labelQ4.AutoSize = true;
            labelQ4.BackColor = SystemColors.Desktop;
            labelQ4.Font = new Font("Segoe UI Variable Small Semibol", 13.8F, FontStyle.Bold);
            labelQ4.ForeColor = Color.LavenderBlush;
            labelQ4.Location = new Point(73, 253);
            labelQ4.Name = "labelQ4";
            labelQ4.Size = new Size(366, 31);
            labelQ4.TabIndex = 5;
            labelQ4.Text = "Manage Your Pet Store with Ease";
            labelQ4.MouseDown += labelQ4_MouseDown;
            // 
            // labelQ5
            // 
            labelQ5.AutoSize = true;
            labelQ5.BackColor = SystemColors.Desktop;
            labelQ5.Font = new Font("Segoe UI Variable Small Semibol", 13.8F, FontStyle.Bold);
            labelQ5.ForeColor = Color.LavenderBlush;
            labelQ5.Location = new Point(73, 288);
            labelQ5.Name = "labelQ5";
            labelQ5.Size = new Size(220, 31);
            labelQ5.TabIndex = 6;
            labelQ5.Text = "Pawssibilities Await";
            labelQ5.MouseDown += labelQ5_MouseDown;
            // 
            // pictureBoxDog
            // 
            pictureBoxDog.BackColor = Color.Transparent;
            pictureBoxDog.Image = (Image)resources.GetObject("pictureBoxDog.Image");
            pictureBoxDog.Location = new Point(-14, 365);
            pictureBoxDog.Name = "pictureBoxDog";
            pictureBoxDog.Size = new Size(183, 163);
            pictureBoxDog.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDog.TabIndex = 7;
            pictureBoxDog.TabStop = false;
            pictureBoxDog.MouseDown += pictureBoxDog_MouseDown;
            // 
            // pictureBoxPen
            // 
            pictureBoxPen.BackColor = Color.Transparent;
            pictureBoxPen.Image = (Image)resources.GetObject("pictureBoxPen.Image");
            pictureBoxPen.Location = new Point(517, 371);
            pictureBoxPen.Name = "pictureBoxPen";
            pictureBoxPen.Size = new Size(144, 122);
            pictureBoxPen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPen.TabIndex = 8;
            pictureBoxPen.TabStop = false;
            pictureBoxPen.MouseDown += pictureBoxPen_MouseDown;
            // 
            // GroupAbout
            // 
            GroupAbout.BackColor = SystemColors.ControlText;
            GroupAbout.FlatStyle = FlatStyle.Popup;
            GroupAbout.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            GroupAbout.ForeColor = Color.LavenderBlush;
            GroupAbout.Location = new Point(266, 389);
            GroupAbout.Name = "GroupAbout";
            GroupAbout.Size = new Size(160, 40);
            GroupAbout.TabIndex = 9;
            GroupAbout.Text = "Group About";
            GroupAbout.UseVisualStyleBackColor = false;
            GroupAbout.Click += GroupAbout_Click;
            // 
            // AppAbout
            // 
            AppAbout.BackColor = SystemColors.ControlText;
            AppAbout.FlatStyle = FlatStyle.Popup;
            AppAbout.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            AppAbout.ForeColor = Color.LavenderBlush;
            AppAbout.Location = new Point(266, 435);
            AppAbout.Name = "AppAbout";
            AppAbout.Size = new Size(160, 40);
            AppAbout.TabIndex = 10;
            AppAbout.Text = "App About";
            AppAbout.UseVisualStyleBackColor = false;
            AppAbout.Click += AppAbout_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(820, 488);
            ControlBox = false;
            Controls.Add(AppAbout);
            Controls.Add(GroupAbout);
            Controls.Add(pictureBoxDog);
            Controls.Add(pictureBoxPen);
            Controls.Add(labelQ5);
            Controls.Add(labelQ4);
            Controls.Add(labelQ3);
            Controls.Add(labelQ1);
            Controls.Add(labelQ2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDog).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ButtonEmp_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Button buttonEtc;
        private Button buttonRep;
        private Button buttonPet;
        private Button buttonCus;
        private Button buttonEmp;
        private Button buttonHome;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label labelUser;
        private Label labelQ2;
        private Label labelQ1;
        private Label labelQ3;
        private Label labelQ4;
        private Label labelQ5;
        private PictureBox pictureBoxDog;
        private PictureBox pictureBoxPen;
        private Button GroupAbout;
        private Button AppAbout;
    }
}