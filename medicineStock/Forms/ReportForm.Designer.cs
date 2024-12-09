namespace medicineStock.UI.Forms
{
    partial class ReportForm
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
            label5 = new Label();
            lstUsers = new ListBox();
            userSearchTxtBox = new TextBox();
            btnDelete = new Button();
            btnCreate = new Button();
            dataGridView1 = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            ReportContent = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            UserId = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            btnPdfCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 56);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 47;
            label5.Text = "Search:";
            // 
            // lstUsers
            // 
            lstUsers.FormattingEnabled = true;
            lstUsers.Location = new Point(12, 86);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(217, 324);
            lstUsers.TabIndex = 46;
            lstUsers.SelectedIndexChanged += lstUsers_SelectedIndexChanged;
            // 
            // userSearchTxtBox
            // 
            userSearchTxtBox.Location = new Point(74, 53);
            userSearchTxtBox.Name = "userSearchTxtBox";
            userSearchTxtBox.Size = new Size(155, 27);
            userSearchTxtBox.TabIndex = 45;
            userSearchTxtBox.TextChanged += userSearchTxtBox_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(395, 274);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 52);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Delete Report";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(515, 274);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(210, 52);
            btnCreate.TabIndex = 42;
            btnCreate.Text = "Create Report";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UserName, ReportContent, CreatedDate, Id, UserId });
            dataGridView1.Location = new Point(275, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(938, 109);
            dataGridView1.TabIndex = 49;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "Patient Name";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.Width = 125;
            // 
            // ReportContent
            // 
            ReportContent.DataPropertyName = "ReportContent";
            ReportContent.HeaderText = "Report Content";
            ReportContent.MinimumWidth = 6;
            ReportContent.Name = "ReportContent";
            ReportContent.Width = 125;
            // 
            // CreatedDate
            // 
            CreatedDate.DataPropertyName = "CreatedDate";
            CreatedDate.HeaderText = "Created Date";
            CreatedDate.MinimumWidth = 6;
            CreatedDate.Name = "CreatedDate";
            CreatedDate.Width = 125;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Report ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "User ID";
            UserId.MinimumWidth = 6;
            UserId.Name = "UserId";
            UserId.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 38);
            label1.TabIndex = 50;
            label1.Text = "Find User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(275, 9);
            label2.Name = "label2";
            label2.Size = new Size(215, 38);
            label2.TabIndex = 51;
            label2.Text = "Created Reports";
            // 
            // btnPdfCreate
            // 
            btnPdfCreate.Location = new Point(395, 216);
            btnPdfCreate.Name = "btnPdfCreate";
            btnPdfCreate.Size = new Size(114, 52);
            btnPdfCreate.TabIndex = 52;
            btnPdfCreate.Text = "Create PDF";
            btnPdfCreate.UseVisualStyleBackColor = true;
            btnPdfCreate.Click += button1_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 465);
            Controls.Add(btnPdfCreate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(lstUsers);
            Controls.Add(userSearchTxtBox);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Name = "ReportForm";
            Text = "ReportForm";
            Load += ReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private ListBox lstUsers;
        private TextBox userSearchTxtBox;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCreate;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button btnPdfCreate;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn ReportContent;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn UserId;
    }
}