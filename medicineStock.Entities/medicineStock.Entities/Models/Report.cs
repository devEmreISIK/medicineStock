using medicineStock.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicineStock.Entities.Models
{
    public class Report : Entity
    {
        public Guid UserID { get; set; }
        public string? Content { get; set; }
        public User? User { get; set; }

        public string? UserName => User?.FullName;
    }
}
