namespace WinFormsApp_QL
{
    partial class Member
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(162, 38);
            label1.TabIndex = 0;
            label1.Text = "Thành viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(10, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 207);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách thành viên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(6, 164);
            label6.Name = "label6";
            label6.Size = new Size(243, 28);
            label6.TabIndex = 4;
            label6.Text = "2100002892 - Vũ Đức Huy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(6, 131);
            label4.Name = "label4";
            label4.Size = new Size(257, 28);
            label4.TabIndex = 3;
            label4.Text = "2100007994 - Lê Thanh Tâm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 100);
            label5.Name = "label5";
            label5.Size = new Size(266, 28);
            label5.TabIndex = 2;
            label5.Text = "2100008330 - Trần Quốc Phú";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 69);
            label3.Name = "label3";
            label3.Size = new Size(299, 28);
            label3.TabIndex = 1;
            label3.Text = "2100008107 - Trần Hoàng Thắng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(292, 28);
            label2.TabIndex = 0;
            label2.Text = "2100008178 - Trần Thiên Quang";
            // 
            // Member
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 273);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Member";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label3;
    }
}