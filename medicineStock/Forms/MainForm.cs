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
        public MainForm()
        {
            InitializeComponent();

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
            panel1 = new Panel();
            button6 = new Button();
            button4 = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
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
            kullanıcıYonetimiToolStripMenuItem.Size = new Size(141, 24);
            kullanıcıYonetimiToolStripMenuItem.Text = "Kullanıcı Yonetimi";
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
            // panel1
            // 
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(0, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 428);
            panel1.TabIndex = 5;
            // 
            // button6
            // 
            button6.Location = new Point(117, 185);
            button6.Name = "button6";
            button6.Size = new Size(206, 70);
            button6.TabIndex = 11;
            button6.Text = "Güncel Stok";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(117, 95);
            button4.Name = "button4";
            button4.Size = new Size(206, 69);
            button4.TabIndex = 9;
            button4.Text = "Yeni İlaç Ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(889, 516);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ılacYonetimiToolStripMenuItem;
        private ToolStripMenuItem tedarikciYonetimiToolStripMenuItem;
        private ToolStripMenuItem kullanıcıYonetimiToolStripMenuItem;
        private ToolStripMenuItem cikisToolStripMenuItem;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button button3;

        private void ılacYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicineForm medicine = new MedicineForm();
            medicine.Show();

        }


        private Button button4;
        private Button button6;

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

        private void button4_Click(object sender, EventArgs e)
        {
            MedicineForm medicineForm = new MedicineForm();
            medicineForm.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(medicineForm);
            medicineForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MedicineForm medicineForm = new MedicineForm();
            medicineForm.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(medicineForm);
            medicineForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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
    }
}
