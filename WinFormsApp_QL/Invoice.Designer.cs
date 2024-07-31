namespace WinFormsApp_QL
{
    partial class Invoice
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
            labelInvoice = new Label();
            labelCustomer = new Label();
            labelBill = new Label();
            lblTotalPrice = new Label();
            lblCustomerName = new Label();
            PN = new Label();
            lstProducts = new ListBox();
            labelEmployee = new Label();
            lblEmployeeName = new Label();
            SuspendLayout();
            // 
            // labelInvoice
            // 
            labelInvoice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelInvoice.AutoSize = true;
            labelInvoice.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInvoice.ForeColor = Color.Indigo;
            labelInvoice.Location = new Point(306, 9);
            labelInvoice.Name = "labelInvoice";
            labelInvoice.Size = new Size(158, 54);
            labelInvoice.TabIndex = 0;
            labelInvoice.Text = "Invoice";
            labelInvoice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            labelCustomer.ForeColor = Color.Indigo;
            labelCustomer.Location = new Point(15, 80);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(170, 27);
            labelCustomer.TabIndex = 1;
            labelCustomer.Text = "Customer Name:";
            // 
            // labelBill
            // 
            labelBill.AutoSize = true;
            labelBill.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBill.ForeColor = Color.Indigo;
            labelBill.Location = new Point(605, 670);
            labelBill.Name = "labelBill";
            labelBill.Size = new Size(96, 27);
            labelBill.TabIndex = 3;
            labelBill.Text = "Total Bill:";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.Indigo;
            lblTotalPrice.Location = new Point(700, 670);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(27, 27);
            lblTotalPrice.TabIndex = 4;
            lblTotalPrice.Text = "...";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.ForeColor = Color.Indigo;
            lblCustomerName.Location = new Point(180, 80);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(27, 27);
            lblCustomerName.TabIndex = 5;
            lblCustomerName.Text = "...";
            // 
            // PN
            // 
            PN.AutoSize = true;
            PN.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PN.ForeColor = Color.Indigo;
            PN.Location = new Point(15, 165);
            PN.Name = "PN";
            PN.Size = new Size(148, 31);
            PN.TabIndex = 6;
            PN.Text = "Billing Detail";
            // 
            // lstProducts
            // 
            lstProducts.BackColor = Color.DarkSlateBlue;
            lstProducts.BorderStyle = BorderStyle.None;
            lstProducts.Cursor = Cursors.Hand;
            lstProducts.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstProducts.ForeColor = Color.LavenderBlush;
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 31;
            lstProducts.Location = new Point(15, 200);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(770, 465);
            lstProducts.TabIndex = 8;
            // 
            // labelEmployee
            // 
            labelEmployee.AutoSize = true;
            labelEmployee.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            labelEmployee.ForeColor = Color.Indigo;
            labelEmployee.Location = new Point(15, 120);
            labelEmployee.Name = "labelEmployee";
            labelEmployee.Size = new Size(168, 27);
            labelEmployee.TabIndex = 9;
            labelEmployee.Text = "Employee Name:";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeName.ForeColor = Color.Indigo;
            lblEmployeeName.Location = new Point(180, 120);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(27, 27);
            lblEmployeeName.TabIndex = 10;
            lblEmployeeName.Text = "...";
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(807, 703);
            Controls.Add(lblEmployeeName);
            Controls.Add(labelEmployee);
            Controls.Add(lstProducts);
            Controls.Add(PN);
            Controls.Add(lblCustomerName);
            Controls.Add(lblTotalPrice);
            Controls.Add(labelBill);
            Controls.Add(labelCustomer);
            Controls.Add(labelInvoice);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Invoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice";
            FormClosing += Invoice_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInvoice;
        private Label labelCustomer;
        private Label labelBill;
        private Label lblTotalPrice;
        private Label lblCustomerName;
        private Label PN;
        private ListBox lstProducts;
        private Label labelEmployee;
        private Label lblEmployeeName;
    }
}