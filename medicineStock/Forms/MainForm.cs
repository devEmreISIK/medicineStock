﻿using medicineStock.Business.Services;
using medicineStock.DataAccess.Context;
using medicineStock.DataAccess.Repositories;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicineStock.UI.Forms
{
    public partial class MainForm : Form
    {
        private readonly ApplicationDBContext _dbContext;
        UserService _userService;
        ReminderService _reminderService;
        ReportService _reportService;
        SupplierService _supplierService;
        MedicineService _medicineService;

        public MainForm()
        {
            InitializeComponent();
            _dbContext = new ApplicationDBContext();
            UserRepository userRepository = new UserRepository(_dbContext);
            _userService = new UserService(userRepository);

            ReminderRepository reminderRepository = new ReminderRepository(_dbContext);
            _reminderService = new ReminderService(reminderRepository);

            ReportRepository reportService = new ReportRepository(_dbContext);
            _reportService = new ReportService(reportService);

            SupplierRepository supplierRepository = new SupplierRepository(_dbContext);
            _supplierService = new SupplierService(supplierRepository);

            MedicineRepository medicineRepository = new MedicineRepository(_dbContext);
            _medicineService = new MedicineService(medicineRepository);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            ılacYonetimiToolStripMenuItem = new ToolStripMenuItem();
            tedarikciYonetimiToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıYonetimiToolStripMenuItem = new ToolStripMenuItem();
            hatırlatıcıYönetimiToolStripMenuItem = new ToolStripMenuItem();
            raporYönetimiToolStripMenuItem = new ToolStripMenuItem();
            cikisToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lstReminders = new ListBox();
            label5 = new Label();
            label6 = new Label();
            button4 = new Button();
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ılacYonetimiToolStripMenuItem, tedarikciYonetimiToolStripMenuItem, kullanıcıYonetimiToolStripMenuItem, hatırlatıcıYönetimiToolStripMenuItem, raporYönetimiToolStripMenuItem, cikisToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(871, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // ılacYonetimiToolStripMenuItem
            // 
            ılacYonetimiToolStripMenuItem.Name = "ılacYonetimiToolStripMenuItem";
            ılacYonetimiToolStripMenuItem.Size = new Size(108, 24);
            ılacYonetimiToolStripMenuItem.Text = "Ilac Yonetimi";
            ılacYonetimiToolStripMenuItem.Click += ılacYonetimiToolStripMenuItem_Click;
            // 
            // tedarikciYonetimiToolStripMenuItem
            // 
            tedarikciYonetimiToolStripMenuItem.Name = "tedarikciYonetimiToolStripMenuItem";
            tedarikciYonetimiToolStripMenuItem.Size = new Size(144, 24);
            tedarikciYonetimiToolStripMenuItem.Text = "Tedarikci Yonetimi";
            tedarikciYonetimiToolStripMenuItem.Click += tedarikciYonetimiToolStripMenuItem_Click;
            // 
            // kullanıcıYonetimiToolStripMenuItem
            // 
            kullanıcıYonetimiToolStripMenuItem.Name = "kullanıcıYonetimiToolStripMenuItem";
            kullanıcıYonetimiToolStripMenuItem.Size = new Size(123, 24);
            kullanıcıYonetimiToolStripMenuItem.Text = "Hasta Yonetimi";
            kullanıcıYonetimiToolStripMenuItem.Click += kullanıcıYonetimiToolStripMenuItem_Click;
            // 
            // hatırlatıcıYönetimiToolStripMenuItem
            // 
            hatırlatıcıYönetimiToolStripMenuItem.Name = "hatırlatıcıYönetimiToolStripMenuItem";
            hatırlatıcıYönetimiToolStripMenuItem.Size = new Size(150, 24);
            hatırlatıcıYönetimiToolStripMenuItem.Text = "Hatırlatıcı Yönetimi";
            hatırlatıcıYönetimiToolStripMenuItem.Click += hatırlatıcıYönetimiToolStripMenuItem_Click;
            // 
            // raporYönetimiToolStripMenuItem
            // 
            raporYönetimiToolStripMenuItem.Name = "raporYönetimiToolStripMenuItem";
            raporYönetimiToolStripMenuItem.Size = new Size(125, 24);
            raporYönetimiToolStripMenuItem.Text = "Rapor Yönetimi";
            raporYönetimiToolStripMenuItem.Click += raporYönetimiToolStripMenuItem_Click;
            // 
            // cikisToolStripMenuItem
            // 
            cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            cikisToolStripMenuItem.Size = new Size(53, 24);
            cikisToolStripMenuItem.Text = "Cikis";
            cikisToolStripMenuItem.Click += cikisToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumTurquoise;
            label1.Font = new Font("Calibri", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(164, 22);
            label1.TabIndex = 5;
            label1.Text = "Toplam Hasta Sayısı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumTurquoise;
            label2.Font = new Font("Calibri", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(14, 68);
            label2.Name = "label2";
            label2.Size = new Size(186, 22);
            label2.TabIndex = 6;
            label2.Text = "Toplam Tedarikçi Sayısı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumTurquoise;
            label3.Font = new Font("Calibri", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(325, 15);
            label3.Name = "label3";
            label3.Size = new Size(194, 22);
            label3.TabIndex = 7;
            label3.Text = "Toplam Hatırlatıcı Sayısı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumTurquoise;
            label4.Font = new Font("Calibri", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(325, 68);
            label4.Name = "label4";
            label4.Size = new Size(166, 22);
            label4.TabIndex = 8;
            label4.Text = "Toplam Rapor Sayısı:";
            // 
            // lstReminders
            // 
            lstReminders.FormattingEnabled = true;
            lstReminders.Location = new Point(12, 316);
            lstReminders.Name = "lstReminders";
            lstReminders.Size = new Size(847, 164);
            lstReminders.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumTurquoise;
            label5.Font = new Font("Calibri", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(12, 282);
            label5.Name = "label5";
            label5.Size = new Size(291, 28);
            label5.TabIndex = 41;
            label5.Text = "Yaklaşan Tarihli Hatırlatıcılar:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MediumTurquoise;
            label6.Font = new Font("Calibri", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label6.Location = new Point(12, 97);
            label6.Name = "label6";
            label6.Size = new Size(153, 35);
            label6.TabIndex = 42;
            label6.Text = "İstatistikler:";
            // 
            // button4
            // 
            button4.BackColor = Color.MediumTurquoise;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(673, 276);
            button4.Name = "button4";
            button4.Size = new Size(186, 34);
            button4.TabIndex = 43;
            button4.Text = "Yenile";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 51);
            panel1.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label7.Location = new Point(203, 5);
            label7.Name = "label7";
            label7.Size = new Size(458, 40);
            label7.TabIndex = 0;
            label7.Text = "Hatırlatıcılı İlaç Stok Yönetim Sistemi";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumTurquoise;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(12, 135);
            panel2.Name = "panel2";
            panel2.Size = new Size(847, 125);
            panel2.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(661, 93);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 9;
            label8.Text = "label8";
            label8.Click += label8_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.Bisque;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(871, 489);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lstReminders);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(889, 536);
            MinimumSize = new Size(889, 536);
            Name = "MainForm";
            Text = "Medicine Stock Management System with Reminder";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ılacYonetimiToolStripMenuItem;
        private ToolStripMenuItem tedarikciYonetimiToolStripMenuItem;
        private ToolStripMenuItem kullanıcıYonetimiToolStripMenuItem;
        private ToolStripMenuItem cikisToolStripMenuItem;
        private Button button2;
        private Button button1;
        private Button button3;

        private void ılacYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicineForm medicine = new MedicineForm();
            medicine.Show();

        }

        private void tedarikciYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.Show();
        }

        private void kullanıcıYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            CountCalculator();
            GetAllExpiringReminders();
        }

        private void GetAllExpiringReminders()
        {
            var today = DateTime.Now;

            var users = _userService.GetAll().ToDictionary(u => u.Id);
            var medicines = _medicineService.GetAll().ToDictionary(m => m.Id);

            var reminders = _reminderService.GetAll()
                .Where(r => (r.RemindDate - today).TotalDays <= 3 && r.RemindDate >= today)
                .Select(r => new
                {
                    r.Id,
                    DisplayText = $"{(users.ContainsKey(r.UserID) ? users[r.UserID].FullName : "Bilinmeyen Kullanıcı")} - " +
                                  $"{(medicines.ContainsKey(r.MedicineID) ? medicines[r.MedicineID].MedicineName : "İlaç Yok")} - " +
                                  $"{Math.Ceiling((r.RemindDate - today).TotalDays)} gün kaldı"
                })
                .ToList();

            lstReminders.ValueMember = "Id";
            lstReminders.DisplayMember = "DisplayText";
            lstReminders.DataSource = reminders;
            lstReminders.SelectedIndex = -1;

            if (reminders.Count == 0)
            {
                MessageBox.Show("3 gün içinde herhangi bir hatırlatma bulunmamaktadır.");
            }
        }


        private void CountCalculator()
        {
            int userCount = _userService.GetAll().Count();
            label1.Text = $"Hasta Sayısı: {userCount}";

            int supplierCount = _supplierService.GetAll().Count();
            label2.Text = $"Tedarikçi Sayısı: {supplierCount}";

            int reminderCount = _reminderService.GetAll().Count();
            label3.Text = $"Hatırlatıcı Sayısı: {reminderCount}";

            int reportCount = _reportService.GetAll().Count();
            label4.Text = $"Rapor Sayısı: {reportCount}";

            label8.Text = DateTime.Now.ToString();
        }

        private ToolStripMenuItem hatırlatıcıYönetimiToolStripMenuItem;
        private ToolStripMenuItem raporYönetimiToolStripMenuItem;

        private void hatırlatıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReminderForm reminderForm = new ReminderForm();
            reminderForm.Show();
        }

        private void raporYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox lstReminders;
        private Label label5;
        private Label label6;
        private Button button4;

        private void button4_Click(object sender, EventArgs e)
        {
            GetAllExpiringReminders();
        }

        private Panel panel1;
        private Label label7;
        private Panel panel2;
        private Label label8;

        private void label8_Click(object sender, EventArgs e)
        {
            
        }
    }
}
