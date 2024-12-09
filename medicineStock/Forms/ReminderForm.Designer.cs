namespace medicineStock.UI.Forms
{
    partial class ReminderForm
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
            lstReminders = new ListBox();
            reminderSearchTxtBox = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            cmbMedicine = new ComboBox();
            cmbUser = new ComboBox();
            dtpRemind = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(620, 345);
            button1.Name = "button1";
            button1.Size = new Size(99, 52);
            button1.TabIndex = 41;
            button1.Text = "Clean";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 23);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 40;
            label5.Text = "Search:";
            // 
            // lstReminders
            // 
            lstReminders.FormattingEnabled = true;
            lstReminders.Location = new Point(12, 53);
            lstReminders.Name = "lstReminders";
            lstReminders.Size = new Size(923, 164);
            lstReminders.TabIndex = 39;
            lstReminders.SelectedIndexChanged += lstReminders_SelectedIndexChanged;
            // 
            // reminderSearchTxtBox
            // 
            reminderSearchTxtBox.Location = new Point(71, 20);
            reminderSearchTxtBox.Name = "reminderSearchTxtBox";
            reminderSearchTxtBox.Size = new Size(864, 27);
            reminderSearchTxtBox.TabIndex = 38;
            reminderSearchTxtBox.TextChanged += reminderSearchTxtBox_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(132, 227);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 52);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 227);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 52);
            btnDelete.TabIndex = 36;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(725, 345);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(210, 52);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbMedicine
            // 
            cmbMedicine.FormattingEnabled = true;
            cmbMedicine.Location = new Point(652, 229);
            cmbMedicine.Name = "cmbMedicine";
            cmbMedicine.Size = new Size(283, 28);
            cmbMedicine.TabIndex = 42;
            cmbMedicine.SelectedIndexChanged += cmbMedicine_SelectedIndexChanged;
            // 
            // cmbUser
            // 
            cmbUser.FormattingEnabled = true;
            cmbUser.Location = new Point(652, 263);
            cmbUser.Name = "cmbUser";
            cmbUser.Size = new Size(283, 28);
            cmbUser.TabIndex = 43;
            cmbUser.SelectedIndexChanged += cmbUser_SelectedIndexChanged;
            // 
            // dtpRemind
            // 
            dtpRemind.Location = new Point(652, 297);
            dtpRemind.Name = "dtpRemind";
            dtpRemind.Size = new Size(283, 27);
            dtpRemind.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(573, 232);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 45;
            label1.Text = "Medicine:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(589, 266);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 46;
            label2.Text = "Patient:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(547, 302);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 47;
            label3.Text = "Remind Date:";
            // 
            // ReminderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 428);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpRemind);
            Controls.Add(cmbUser);
            Controls.Add(cmbMedicine);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(lstReminders);
            Controls.Add(reminderSearchTxtBox);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "ReminderForm";
            Text = "Reminder Manager";
            Load += ReminderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private ListBox lstReminders;
        private TextBox reminderSearchTxtBox;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private ComboBox cmbMedicine;
        private ComboBox cmbUser;
        private DateTimePicker dtpRemind;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}