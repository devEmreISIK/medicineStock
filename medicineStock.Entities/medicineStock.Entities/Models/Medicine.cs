using medicineStock.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicineStock.Entities.Models
{
    public class Medicine : Entity
    {
        public string? MedicineName { get; set; }
        public string? MedicineBrand { get; set; }
        public int Stock { get; set; }
        public int Dosage { get; set; }
        public int UsageWeek { get; set; }
        public Guid SupplierID { get; set; }
        public Supplier? Supplier { get; set; }

        public ICollection<Reminder>? Reminders { get; set; }
    }
}
