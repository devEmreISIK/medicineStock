using medicineStock.Business.Services;
using medicineStock.DataAccess.Context;
using medicineStock.Entities.Models;
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
    public partial class UsersForm : Form
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly UserService _userService;

        User? selectedUser;
        public UsersForm()
        {
            InitializeComponent();
            _dbContext = new ApplicationDBContext();
            UserRepository userRepository = new UserRepository(_dbContext);
            _userService = new UserService(userRepository);
        }

        private void userSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            GetAllUsersBySearchText(userSearchTxtBox.Text);
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

                if (selectedUser != null)
                {
                    txtMail.Text = selectedUser.Email;
                    txtName.Text = selectedUser.Name;
                    txtPhone.Text = selectedUser.Phone;
                    txtSurname.Text = selectedUser.Surname;
                    txtTcNo.Text = selectedUser.TCno;
                }
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            GetAllUsers();
            GetAllUsersBySearchText(string.Empty);
            FormClean();
        }

        private void GetAllUsers()
        {
            lstUsers.ValueMember = "Id";
            lstUsers.DisplayMember = "FullName";
            lstUsers.DataSource = _userService.GetAll();
            lstUsers.SelectedIndex = -1;
            FormClean();
        }

        private void FormClean()
        {
            txtMail.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtPhone.Text = "";
            txtTcNo.Text = "";
            txtName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string uName = txtName.Text;
                string uPhone = txtPhone.Text;
                string uSurname = txtSurname.Text;
                string uMail = txtMail.Text;
                string uTcNo = txtTcNo.Text;

                User newUser = new User()
                {
                    Name = uName,
                    Phone = uPhone,
                    Surname = uSurname,
                    Email = uMail,
                    TCno = uTcNo,
                    IsActive = true
                };

                _userService.Create(newUser);
                MessageBox.Show("Success!");
                GetAllUsers();
                FormClean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                selectedUser.Name = txtName.Text;
                selectedUser.Surname = txtSurname.Text;
                selectedUser.Email = txtMail.Text;
                selectedUser.TCno = txtTcNo.Text;
                selectedUser.Phone = txtPhone.Text;

                _userService.Update(selectedUser);
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Please select a user from user list!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                _userService.Delete(selectedUser.Id);
                GetAllUsers();
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Please select a user from user list!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClean();
        }
    }
}
