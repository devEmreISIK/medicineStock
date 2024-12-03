namespace medicineStock.UI.Forms
{
    partial class MedicineForm
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
            label4 = new Label();
            label1 = new Label();
            txtBrand = new TextBox();
            txtName = new TextBox();
            lstMedicines = new ListBox();
            searchTxtBox = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            label2 = new Label();
            label3 = new Label();
            cmbSupplier = new ComboBox();
            label6 = new Label();
            nmbrStock = new NumericUpDown();
            nmbrDosage = new NumericUpDown();
            nmbrUsageWeek = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nmbrStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmbrDosage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmbrUsageWeek).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(459, 375);
            button1.Name = "button1";
            button1.Size = new Size(99, 52);
            button1.TabIndex = 47;
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
            label5.TabIndex = 46;
            label5.Text = "Search:";
            // 
            // lblTcNo
            // 
            lblTcNo.AutoSize = true;
            lblTcNo.Location = new Point(323, 196);
            lblTcNo.Name = "lblTcNo";
            lblTcNo.Size = new Size(48, 20);
            lblTcNo.TabIndex = 45;
            lblTcNo.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 153);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 43;
            label4.Text = "Brand:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 110);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 42;
            label1.Text = "Name:";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(380, 150);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(394, 27);
            txtBrand.TabIndex = 41;
            // 
            // txtName
            // 
            txtName.Location = new Point(380, 107);
            txtName.Name = "txtName";
            txtName.Size = new Size(394, 27);
            txtName.TabIndex = 40;
            // 
            // lstMedicines
            // 
            lstMedicines.FormattingEnabled = true;
            lstMedicines.Location = new Point(12, 103);
            lstMedicines.Name = "lstMedicines";
            lstMedicines.Size = new Size(214, 324);
            lstMedicines.TabIndex = 39;
            lstMedicines.SelectedIndexChanged += lstMedicines_SelectedIndexChanged;
            // 
            // searchTxtBox
            // 
            searchTxtBox.Location = new Point(71, 70);
            searchTxtBox.Name = "searchTxtBox";
            searchTxtBox.Size = new Size(155, 27);
            searchTxtBox.TabIndex = 38;
            searchTxtBox.TextChanged += searchTxtBox_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(132, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 52);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 52);
            btnDelete.TabIndex = 36;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(564, 375);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(210, 52);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 239);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 49;
            label2.Text = "Dosage:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 281);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 51;
            label3.Text = "Usage Week:";
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(380, 321);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(394, 28);
            cmbSupplier.TabIndex = 52;
            cmbSupplier.SelectedIndexChanged += cmbSupplier_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(304, 324);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 53;
            label6.Text = "Supplier:";
            // 
            // nmbrStock
            // 
            nmbrStock.Location = new Point(380, 194);
            nmbrStock.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nmbrStock.Name = "nmbrStock";
            nmbrStock.Size = new Size(150, 27);
            nmbrStock.TabIndex = 54;
            // 
            // nmbrDosage
            // 
            nmbrDosage.Location = new Point(380, 237);
            nmbrDosage.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nmbrDosage.Name = "nmbrDosage";
            nmbrDosage.Size = new Size(150, 27);
            nmbrDosage.TabIndex = 55;
            // 
            // nmbrUsageWeek
            // 
            nmbrUsageWeek.Location = new Point(380, 274);
            nmbrUsageWeek.Name = "nmbrUsageWeek";
            nmbrUsageWeek.Size = new Size(150, 27);
            nmbrUsageWeek.TabIndex = 56;
            // 
            // MedicineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nmbrUsageWeek);
            Controls.Add(nmbrDosage);
            Controls.Add(nmbrStock);
            Controls.Add(label6);
            Controls.Add(cmbSupplier);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(lblTcNo);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtBrand);
            Controls.Add(txtName);
            Controls.Add(lstMedicines);
            Controls.Add(searchTxtBox);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "MedicineForm";
            Text = "MedicineForm";
            Load += MedicineForm_Load;
            ((System.ComponentModel.ISupportInitialize)nmbrStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmbrDosage).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmbrUsageWeek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private Label lblTcNo;
        private Label label4;
        private Label label1;
        private TextBox txtBrand;
        private TextBox txtName;
        private ListBox lstMedicines;
        private TextBox searchTxtBox;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Label label2;
        private Label label3;
        private ComboBox cmbSupplier;
        private Label label6;
        private NumericUpDown nmbrStock;
        private NumericUpDown nmbrDosage;
        private NumericUpDown nmbrUsageWeek;
    }
}