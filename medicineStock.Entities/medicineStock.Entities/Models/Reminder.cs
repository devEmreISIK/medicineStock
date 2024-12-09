using medicineStock.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicineStock.Entities.Models
{
    public class Reminder : Entity
    {
        public Guid MedicineID { get; set; }
        public Guid UserID { get; set; }
        public DateTime RemindDate { get; set; }

        public User? User { get; set; }
        public Medicine? Medicine { get; set; }

        public string? UserName { get; set; }
        public string? MedicineName { get; set; }

    }
}
