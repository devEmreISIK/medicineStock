using medicineStock.Business.Services;
using medicineStock.DataAccess.Context;
using medicineStock.DataAccess.Repositories;
using medicineStock.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicineStock.UI.Forms
{
    public partial class ReminderForm : Form
    {
        private readonly ApplicationDBContext _dBContext;
        private readonly ReminderService _reminderService;
        private readonly MedicineService _medicineService;
        private readonly UserService _userService;

        Medicine? selectedMedicine;
        User? selectedUser;
        Reminder? selectedReminder;
        public ReminderForm()
        {
            InitializeComponent();
            _dBContext = new ApplicationDBContext();
            ReminderRepository reminderRepository = new ReminderRepository(_dBContext);
            _reminderService = new ReminderService(reminderRepository);

            MedicineRepository medicineRepository = new MedicineRepository(_dBContext);
            _medicineService = new MedicineService(medicineRepository);

            UserRepository userRepository = new UserRepository(_dBContext);
            _userService = new UserService(userRepository);
        }

        private void ReminderForm_Load(object sender, EventArgs e)
        {
            GetAllRemindersBySearchText(string.Empty);
            GetAllReminders();
            GetAllMedicines();
            GetAllUsers();
            FormClean();
        }

        private void FormClean()
        {
            cmbUser.SelectedIndex = -1;
            cmbMedicine.SelectedIndex = -1;
        }

        private void GetAllUsers()
        {
            cmbUser.ValueMember = "Id";
            cmbUser.DisplayMember = "FullName";
            cmbUser.DataSource = _userService.GetAll();
        }

        private void GetAllMedicines()
        {
            cmbMedicine.ValueMember = "Id";
            cmbMedicine.DisplayMember = "MedicineName";
            cmbMedicine.DataSource = _medicineService.GetAll();
        }

        private void GetAllReminders()
        {
            var reminders = _reminderService.GetAll()
                .Select(r => new
                {
                    r.Id, // Değer seçimi için
                    DisplayText = $"{_userService.GetByID(r.UserID).FullName} - {r.MedicineName ?? "İlaç Yok"} - {r.RemindDate:dd.MM.yyyy}"
                })
                .ToList();

            lstReminders.ValueMember = "Id";
            lstReminders.DisplayMember = "DisplayText";
            lstReminders.DataSource = reminders;
            lstReminders.SelectedIndex = -1;

            FormClean();
        }


        private void GetAllRemindersBySearchText(string searchText)
        {
            var users = _userService.GetAll().ToDictionary(u => u.Id);
            var medicines = _medicineService.GetAll().ToDictionary(m => m.Id);

            var reminders = _reminderService.GetAll()
                .Where(r =>
                    (users.ContainsKey(r.UserID) && users[r.UserID].FullName!.ToLower().Contains(searchText.ToLower())) ||
                    (medicines.ContainsKey(r.MedicineID) && medicines[r.MedicineID].MedicineName!.ToLower().Contains(searchText.ToLower()))
                )
                .Select(r => new
                {
                    r.Id,
                    DisplayText = $"{(users.ContainsKey(r.UserID) ? users[r.UserID].FullName : "Bilinmeyen Kullanıcı")} - " +
                                  $"{(medicines.ContainsKey(r.MedicineID) ? medicines[r.MedicineID].MedicineName : "İlaç Yok")} - " +
                                  $"{r.RemindDate:dd.MM.yyyy}"
                })
                .ToList();

            lstReminders.ValueMember = "Id";
            lstReminders.DisplayMember = "DisplayText";
            lstReminders.DataSource = reminders;
            lstReminders.SelectedIndex = -1;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Medicine? rMedicine = selectedMedicine;
                User? rUser = selectedUser;
                DateTime rDateTime = dtpRemind.Value;
                string? rUserName = selectedUser?.FullName;
                string? rMedicineName = selectedMedicine?.MedicineName;


                Reminder reminder = new Reminder()
                {
                    User = rUser,
                    Medicine = rMedicine,
                    RemindDate = rDateTime,
                    MedicineName = rMedicineName,
                    UserName = rUserName,
                };

                _reminderService.Create(reminder);
                MessageBox.Show("Success!");
                GetAllReminders();
                FormClean();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void reminderSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            GetAllRemindersBySearchText(reminderSearchTxtBox.Text);
        }

        private void lstReminders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstReminders.SelectedIndex != -1)
            {
                var selectedId = (Guid)lstReminders.SelectedValue;
                selectedReminder = _reminderService.GetAll().FirstOrDefault(r => r.Id == selectedId);

                if (selectedReminder != null)
                {
                    cmbUser.SelectedValue = selectedReminder.UserID;
                    cmbMedicine.SelectedValue = selectedReminder.MedicineID;
                    dtpRemind.Value = selectedReminder.RemindDate;
                }
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedReminder != null)
            {
                selectedReminder.UserID = (Guid)cmbUser.SelectedValue;
                selectedReminder.MedicineID = (Guid)cmbMedicine.SelectedValue;
                selectedReminder.RemindDate = dtpRemind.Value;
                selectedReminder.UserName = _userService.GetByID((Guid)cmbUser.SelectedValue).FullName;
                selectedReminder.MedicineName = _medicineService.GetByID((Guid)cmbMedicine.SelectedValue).MedicineName;

                _reminderService.Update(selectedReminder);
                MessageBox.Show("Success!");
                FormClean();
                GetAllReminders();
            }
            else
            {
                MessageBox.Show("Please select a reminder from list!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedReminder != null)
            {
                _reminderService.Delete(selectedReminder!.Id);
                GetAllReminders();
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Please select a reminder from list!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClean();
        }

        private void cmbMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedicine.SelectedIndex != -1)
            {
                selectedMedicine = (Medicine?)cmbMedicine.SelectedItem;
            }
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUser.SelectedIndex != -1)
            {
                selectedUser = (User?)cmbUser.SelectedItem;
            }
        }
    }
}
