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
    public partial class MedicineForm : Form
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly MedicineService _medicineService;
        private readonly SupplierService _supplierService;

        Medicine? selectedMedicine;
        Supplier? selectedSupplier;
        public MedicineForm()
        {
            InitializeComponent();
            _dbContext = new ApplicationDBContext();
            MedicineRepository medicineRepository = new MedicineRepository(_dbContext);
            _medicineService = new MedicineService(medicineRepository);

            SupplierRepository supplierRepository = new SupplierRepository(_dbContext);
            _supplierService = new SupplierService(supplierRepository);
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            GetAllMedicinesBySearchText(string.Empty);
            GetAllMedicines();
            GetAllSuppliers();
            FormClean();
        }

        private void GetAllSuppliers()
        {
            cmbSupplier.ValueMember = "Id";
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.DataSource = _supplierService.GetAll();
        }

        private void GetAllMedicines()
        {
            lstMedicines.ValueMember = "Id";
            lstMedicines.DisplayMember = "MedicineName";
            lstMedicines.DataSource = _medicineService.GetAll();
            lstMedicines.SelectedIndex = -1;
            FormClean();
        }

        private void FormClean()
        {
            txtName.Text = "";
            txtBrand.Text = "";
            nmbrDosage.Value = 0;
            nmbrStock.Value = 0;
            nmbrUsageWeek.Value = 0;
        }

        private void GetAllMedicinesBySearchText(string searchText)
        {
            if (!string.IsNullOrEmpty(searchText.ToLower()) && searchText.Length >= 3)
            {
                var medicineList = _medicineService.GetAll().Where(m => m.MedicineName!.ToLower().Contains(searchText.ToLower()));

                lstMedicines.ValueMember = "Id";
                lstMedicines.DisplayMember = "MedicineName";
                lstMedicines.DataSource = medicineList.ToList();
            }

            if (searchText.Length == 0)
            {
                lstMedicines.ValueMember = "Id";
                lstMedicines.DisplayMember = "MedicineName";
                lstMedicines.DataSource = _medicineService.GetAll().ToList();
            }
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            GetAllMedicinesBySearchText(searchTxtBox.Text);
        }

        private void lstMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMedicines.SelectedIndex != -1)
            {
                selectedMedicine = (Medicine?)lstMedicines.SelectedItem;

                if (selectedMedicine != null)
                {
                    txtName.Text = selectedMedicine.MedicineName;
                    txtBrand.Text = selectedMedicine.MedicineBrand;
                    nmbrDosage.Value = selectedMedicine.Dosage;
                    nmbrStock.Value = selectedMedicine.Stock;
                    nmbrUsageWeek.Value = selectedMedicine.UsageWeek;
                    cmbSupplier.SelectedValue = selectedMedicine.SupplierID;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string mName = txtName.Text;
                string mBrand = txtBrand.Text;
                int mStock = (int)nmbrStock.Value;
                int mDosage = (int)nmbrDosage.Value;
                int mUsageWeek = (int)nmbrUsageWeek.Value;
                Supplier mSupplier = selectedSupplier!;

                Medicine medicine = new Medicine()
                {
                    MedicineName = mName,
                    MedicineBrand = mBrand,
                    Stock = mStock,
                    Dosage = mDosage,
                    UsageWeek = mUsageWeek,
                    Supplier = mSupplier,
                };

                _medicineService.Create(medicine);
                MessageBox.Show("Success!");
                GetAllMedicines();
                FormClean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMedicine != null)
            {
                selectedMedicine.MedicineName = txtName.Text;
                selectedMedicine.MedicineBrand = txtBrand.Text;
                selectedMedicine.Dosage = (int)nmbrDosage.Value;
                selectedMedicine.UsageWeek = (int)nmbrUsageWeek.Value;
                selectedMedicine.Stock = (int)nmbrStock.Value;
                //selectedMedicine.Supplier = (Supplier?)cmbSupplier.SelectedValue;
                selectedMedicine.SupplierID = (Guid)cmbSupplier.SelectedValue;

                _medicineService.Update(selectedMedicine);
                GetAllMedicines();
                FormClean();
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Please select a medicine from list!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSupplier != null)
            {
                _medicineService.Delete(selectedMedicine!.Id);
                GetAllMedicines();
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Please select a medicine from list!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClean();
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedIndex != -1)
            {
                selectedSupplier = (Supplier?)cmbSupplier.SelectedItem;
            }
        }
    }
}
