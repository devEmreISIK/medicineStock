using medicineStock.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicineStock.DataAccess.Context
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=EMRE;Initial Catalog=medicineStock;Integrated Security=True;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    // Medicine -> Supplier
    modelBuilder.Entity<Medicine>()
        .HasOne(m => m.Supplier)
        .WithMany(s => s.Medicines)
        .HasForeignKey(m => m.SupplierID)
        .OnDelete(DeleteBehavior.Restrict);

    // Reminder -> User
    modelBuilder.Entity<Reminder>()
        .HasOne(r => r.User)
        .WithMany()
        .HasForeignKey(r => r.UserID)
        .OnDelete(DeleteBehavior.Restrict);

    // Reminder -> Medicine
    modelBuilder.Entity<Reminder>()
        .HasOne(r => r.Medicine)
        .WithMany(m => m.Reminders)
        .HasForeignKey(r => r.MedicineID)
        .OnDelete(DeleteBehavior.Restrict);

    // Report -> User
    modelBuilder.Entity<Report>()
        .HasOne(r => r.User)
        .WithMany()
        .HasForeignKey(r => r.UserID)
        .OnDelete(DeleteBehavior.Restrict);


        }


    }
}
