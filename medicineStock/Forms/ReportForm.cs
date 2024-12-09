using medicineStock.Business.Services;
using medicineStock.DataAccess.Context;
using medicineStock.DataAccess.Repositories;
using medicineStock.Entities.Models;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iText.Kernel.Font;
using iText.Layout.Properties;

namespace medicineStock.UI.Forms
{
    public partial class ReportForm : Form
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly ReportService _reportService;
        private readonly ReminderService _reminderService;
        private readonly UserService _userService;

        User? selectedUser;
        Report? selectedReport;
        Reminder? reminder;

        public ReportForm()
        {
            InitializeComponent();
            _dbContext = new ApplicationDBContext();
            ReportRepository reportRepository = new ReportRepository(_dbContext);
            _reportService = new ReportService(reportRepository);

            ReminderRepository reminderRepository = new ReminderRepository(_dbContext);
            _reminderService = new ReminderService(reminderRepository);

            UserRepository userRepository = new UserRepository(_dbContext);
            _userService = new UserService(userRepository);
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            GetAllUsers();
            GetAllUsersBySearchText(string.Empty);
            GetAllReports();
        }

        private void GetAllReports()
        {
            var reports = _reportService.GetAll().ToList();

            var reportData = reports.Select(report => new
            {
                Id = report.Id,
                ReportContent = report.Content,
                UserName = report.UserName,
                CreatedDate = report.CreatedDate,
                UserId = report.UserID,

            }).ToList();

            dataGridView1.DataSource = reportData;
        }

        private void GetAllUsers()
        {
            lstUsers.ValueMember = "Id";
            lstUsers.DisplayMember = "FullName";
            lstUsers.DataSource = _userService.GetAll();
            lstUsers.SelectedIndex = -1;
        }

        private void GetAllUsersBySearchText(string searchText)
        {
            if (!string.IsNullOrEmpty(searchText.ToLower()) && searchText.Length >= 3)
            {
                var productList = _userService.GetAll().Where(u => u.Name!.ToLower().Contains(searchText.ToLower()));

                lstUsers.ValueMember = "Id";
                lstUsers.DisplayMember = "FullName";
                lstUsers.DataSource = productList.ToList();
            }

            if (searchText.Length == 0)
            {
                lstUsers.ValueMember = "Id";
                lstUsers.DisplayMember = "FullName";
                lstUsers.DataSource = _userService.GetAll().ToList();
            }
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsers.SelectedIndex != -1)
            {
                selectedUser = (User?)lstUsers.SelectedItem;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                User? rUser = selectedUser;

                var userReminders = _reminderService.GetAll()
                            .Where(r => r.UserID == rUser.Id)
                            .ToList();

                if (!userReminders.Any())
                {
                    MessageBox.Show("Bu kullanıcı için herhangi bir hatırlatma yok.");
                    return;
                }

                StringBuilder reminderDetails = new StringBuilder();
                foreach (var reminder in userReminders)
                {
                    reminderDetails.AppendLine($"- {reminder.MedicineName ?? "İlaç Yok"} | {reminder.RemindDate:dd.MM.yyyy}");
                }

                Report report = new Report()
                {
                    User = rUser,
                    UserID = rUser!.Id,
                    Content = $"{reminderDetails}"
                };


                _reportService.Create(report);
                MessageBox.Show("Success!");
                GetAllReports();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var reportId = (Guid)selectedRow.Cells["Id"].Value;

                _reportService.Delete(reportId);
                GetAllReports();
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Please select a report to delete!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    var selectedRow = dataGridView1.SelectedRows[0];

                    var reportId = (Guid)selectedRow.Cells["Id"].Value;
                    var userName = selectedRow.Cells["UserName"].Value.ToString();
                    Guid userId = (Guid)selectedRow.Cells["UserId"].Value;
                    var content = selectedRow.Cells["ReportContent"].Value.ToString();
                    var createdDate = selectedRow.Cells["CreatedDate"].Value.ToString();
                    string? userPhone = _userService.GetByID(userId).Phone;

                    var userReminders = _reminderService.GetAll()
                        .Where(r => r.UserID == (Guid)selectedRow.Cells["UserId"].Value)
                        .ToList();

                    if (!userReminders.Any())
                    {
                        MessageBox.Show("Bu kullanıcı için hatırlatma yok.");
                        return;
                    }

                    string fileName = $"{userName}_Report.pdf";
                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

                    using (PdfWriter writer = new PdfWriter(filePath))
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);

                        PdfFont font = PdfFontFactory.CreateFont("C:\\Windows\\Fonts\\arialuni.ttf", PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);

                        document.Add(new Paragraph("Patient Medicine Report")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFont(font)
                            .SetFontSize(20));

                        document.Add(new Paragraph($"Patient Name: {userName}")
                            .SetFont(font)
                            .SetFontSize(14));
                        document.Add(new Paragraph($"Patient Phone: {userPhone}")
                            .SetFont(font)
                            .SetFontSize(14));
                        document.Add(new Paragraph($"Report Date: {createdDate}")
                            .SetFont(font)
                            .SetFontSize(14));
                        document.Add(new Paragraph("\nReminders:\n").SetFont(font).SetFontSize(14));

                        foreach (var reminder in userReminders)
                        {
                            document.Add(new Paragraph($"- Medicine: {reminder.MedicineName ?? "Medicine Not Specified"} | Date: {reminder.RemindDate:dd.MM.yyyy}")
                                .SetFont(font));
                        }

                        document.Close();
                    }

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });

                    MessageBox.Show("PDF başarıyla oluşturuldu ve açıldı.");
                }
                else
                {
                    MessageBox.Show("Lütfen bir rapor seçin!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void userSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            GetAllUsersBySearchText(userSearchTxtBox.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
