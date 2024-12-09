using medicineStock.Business.Services;
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
        }

        private void InitializeComponent()
        {
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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ılacYonetimiToolStripMenuItem, tedarikciYonetimiToolStripMenuItem, kullanıcıYonetimiToolStripMenuItem, hatırlatıcıYönetimiToolStripMenuItem, raporYönetimiToolStripMenuItem, cikisToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(889, 28);
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
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 5;
            label1.Text = "Toplam Hasta Sayısı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 6;
            label2.Text = "Toplam Tedarikçi Sayısı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(172, 20);
            label3.TabIndex = 7;
            label3.Text = "Toplam Hatırlatıcı Sayısı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 169);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 8;
            label4.Text = "Toplam Rapor Sayısı:";
            // 
            // lstReminders
            // 
            lstReminders.FormattingEnabled = true;
            lstReminders.Location = new Point(12, 262);
            lstReminders.Name = "lstReminders";
            lstReminders.Size = new Size(847, 164);
            lstReminders.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(12, 228);
            label5.Name = "label5";
            label5.Size = new Size(303, 31);
            label5.TabIndex = 41;
            label5.Text = "Yaklaşan Tarihli Hatırlatıcılar:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(12, 40);
            label6.Name = "label6";
            label6.Size = new Size(130, 31);
            label6.TabIndex = 42;
            label6.Text = "İstatistikler:";
            // 
            // MainForm
            // 
            ClientSize = new Size(889, 476);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lstReminders);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Medicine Stock Management System with Reminder";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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

            var reminders = _reminderService.GetAll()
                .Where(r => (r.RemindDate - today).TotalDays <= 3 && r.RemindDate >= today)
                .Select(r => new
                {
                    r.Id,
                    DisplayText = $"{r.UserName} - {r.MedicineName ?? "İlaç Yok"} - {Math.Ceiling((r.RemindDate - today).TotalDays)} gün kaldı"
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
    }
}
