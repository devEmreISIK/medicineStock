using medicineStock.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicineStock.Entities.Models
{
    public class Supplier : Entity
    {
        public string? SupplierName { get; set; }
        public string? SupplierAddress { get; set; }
        public string? SupplierPhone { get; set; }
        public ICollection<Medicine>? Medicines { get; set; }
    }
}
