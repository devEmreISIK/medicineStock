using medicineStock.Business.Services;
using medicineStock.DataAccess.Context;
using medicineStock.DataAccess.Repositories;
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
    public partial class SupplierForm : Form
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly SupplierService _supplierService;

        Supplier? selectedSupplier;
        public SupplierForm()
        {
            InitializeComponent();
            _dbContext = new ApplicationDBContext();
            SupplierRepository supplierRepository = new SupplierRepository(_dbContext);
            _supplierService = new SupplierService(supplierRepository);
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            GetAllSuppliersBySearchText(string.Empty);
            GetAllSuppliers();
            FormClean();
        }

        private void GetAllSuppliersBySearchText(string searchText)
        {
            if (!string.IsNullOrEmpty(searchText.ToLower()) && searchText.Length >= 3)
            {
                var productList = _supplierService.GetAll().Where(u => u.SupplierName!.ToLower().Contains(searchText.ToLower()));

                lstSuppliers.ValueMember = "Id";
                lstSuppliers.DisplayMember = "SupplierName";
                lstSuppliers.DataSource = productList.ToList();
            }

            if (searchText.Length == 0)
            {
                lstSuppliers.ValueMember = "Id";
                lstSuppliers.DisplayMember = "SupplierName";
                lstSuppliers.DataSource = _supplierService.GetAll().ToList();
            }
        }

        private void GetAllSuppliers()
        {
            lstSuppliers.ValueMember = "Id";
            lstSuppliers.DisplayMember = "SupplierName";
            lstSuppliers.DataSource = _supplierService.GetAll();
            lstSuppliers.SelectedIndex = -1;
            FormClean();
        }

        private void FormClean()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtName.Focus();
        }

        private void supplierSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            GetAllSuppliersBySearchText(supplierSearchTxtBox.Text);
        }

        private void lstSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSuppliers.SelectedIndex != -1)
            {
                selectedSupplier = (Supplier?)lstSuppliers.SelectedItem;

                if (selectedSupplier != null)
                {
                    txtName.Text = selectedSupplier.SupplierName;
                    txtAddress.Text = selectedSupplier.SupplierAddress;
                    txtPhone.Text = selectedSupplier.SupplierPhone;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string sName = txtName.Text;
                string sAddress = txtAddress.Text;
                string sPhone = txtPhone.Text;

                Supplier supplier = new Supplier()
                {
                    SupplierName = sName,
                    SupplierAddress = sAddress,
                    SupplierPhone = sPhone,
                    IsActive = true
                };

                _supplierService.Create(supplier);
                MessageBox.Show("Success!");
                GetAllSuppliers();
                FormClean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSupplier != null)
            {
                selectedSupplier.SupplierName = txtName.Text;
                selectedSupplier.SupplierAddress = txtAddress.Text;
                selectedSupplier.SupplierPhone = txtPhone.Text;

                _supplierService.Update(selectedSupplier);
                FormClean();
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Please select a supplier from list!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSupplier != null)
            {
                _supplierService.Delete(selectedSupplier.Id);
                GetAllSuppliers();
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Please select a supplier from list!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClean();
        }
    }
}
