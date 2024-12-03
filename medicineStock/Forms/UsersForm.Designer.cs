namespace medicineStock.UI.Forms
{
    partial class UsersForm
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
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            userSearchTxtBox = new TextBox();
            lstUsers = new ListBox();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtMail = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTcNo = new TextBox();
            lblTcNo = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(513, 306);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(210, 52);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 9);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 52);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(132, 9);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 52);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // userSearchTxtBox
            // 
            userSearchTxtBox.Location = new Point(71, 67);
            userSearchTxtBox.Name = "userSearchTxtBox";
            userSearchTxtBox.Size = new Size(155, 27);
            userSearchTxtBox.TabIndex = 3;
            userSearchTxtBox.TextChanged += userSearchTxtBox_TextChanged;
            // 
            // lstUsers
            // 
            lstUsers.FormattingEnabled = true;
            lstUsers.Location = new Point(12, 100);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(214, 324);
            lstUsers.TabIndex = 4;
            lstUsers.SelectedIndexChanged += lstUsers_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(329, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(394, 27);
            txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(329, 113);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(394, 27);
            txtSurname.TabIndex = 6;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(329, 160);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(394, 27);
            txtMail.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(329, 206);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(394, 27);
            txtPhone.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 73);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 10;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 116);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 11;
            label2.Text = "Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 160);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 12;
            label3.Text = "E-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 206);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 13;
            label4.Text = "Phone:";
            // 
            // txtTcNo
            // 
            txtTcNo.Location = new Point(329, 252);
            txtTcNo.Name = "txtTcNo";
            txtTcNo.Size = new Size(394, 27);
            txtTcNo.TabIndex = 14;
            // 
            // lblTcNo
            // 
            lblTcNo.AutoSize = true;
            lblTcNo.Location = new Point(266, 255);
            lblTcNo.Name = "lblTcNo";
            lblTcNo.Size = new Size(55, 20);
            lblTcNo.TabIndex = 15;
            lblTcNo.Text = "TC. No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 70);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 16;
            label5.Text = "Search:";
            // 
            // button1
            // 
            button1.Location = new Point(408, 306);
            button1.Name = "button1";
            button1.Size = new Size(99, 52);
            button1.TabIndex = 17;
            button1.Text = "Clean";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 436);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(lblTcNo);
            Controls.Add(txtTcNo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtMail);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(lstUsers);
            Controls.Add(userSearchTxtBox);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "UsersForm";
            Text = "UsersForm";
            Load += UsersForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox userSearchTxtBox;
        private ListBox lstUsers;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtMail;
        private TextBox txtPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTcNo;
        private Label lblTcNo;
        private Label label5;
        private Button button1;
    }
}