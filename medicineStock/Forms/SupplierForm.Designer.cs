namespace medicineStock.UI.Forms
{
    partial class SupplierForm
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
            button1 = new Button();
            label5 = new Label();
            lblTcNo = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            label1 = new Label();
            txtPhone = new TextBox();
            txtName = new TextBox();
            lstSuppliers = new ListBox();
            supplierSearchTxtBox = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(320, 246);
            button1.Name = "button1";
            button1.Size = new Size(178, 52);
            button1.TabIndex = 34;
            button1.Text = "Clean";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 73);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 33;
            label5.Text = "Search:";
            // 
            // lblTcNo
            // 
            lblTcNo.AutoSize = true;
            lblTcNo.Location = new Point(251, 193);
            lblTcNo.Name = "lblTcNo";
            lblTcNo.Size = new Size(65, 20);
            lblTcNo.TabIndex = 32;
            lblTcNo.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(320, 190);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(394, 27);
            txtAddress.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 150);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 30;
            label4.Text = "Phone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 107);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 27;
            label1.Text = "Name:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(320, 147);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(394, 27);
            txtPhone.TabIndex = 26;
            // 
            // txtName
            // 
            txtName.Location = new Point(320, 104);
            txtName.Name = "txtName";
            txtName.Size = new Size(394, 27);
            txtName.TabIndex = 23;
            // 
            // lstSuppliers
            // 
            lstSuppliers.FormattingEnabled = true;
            lstSuppliers.Location = new Point(12, 103);
            lstSuppliers.Name = "lstSuppliers";
            lstSuppliers.Size = new Size(214, 324);
            lstSuppliers.TabIndex = 22;
            lstSuppliers.SelectedIndexChanged += lstSuppliers_SelectedIndexChanged;
            // 
            // supplierSearchTxtBox
            // 
            supplierSearchTxtBox.Location = new Point(71, 70);
            supplierSearchTxtBox.Name = "supplierSearchTxtBox";
            supplierSearchTxtBox.Size = new Size(155, 27);
            supplierSearchTxtBox.TabIndex = 21;
            supplierSearchTxtBox.TextChanged += supplierSearchTxtBox_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(132, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 52);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 52);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(504, 246);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(210, 52);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(746, 447);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(lblTcNo);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(lstSuppliers);
            Controls.Add(supplierSearchTxtBox);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "SupplierForm";
            Text = "Supplier Manager";
            Load += SupplierForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private Label lblTcNo;
        private TextBox txtAddress;
        private Label label4;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtName;
        private ListBox lstSuppliers;
        private TextBox supplierSearchTxtBox;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
    }
}