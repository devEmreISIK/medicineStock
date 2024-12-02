using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicineStock.Entities.Abstractions
{
    public class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; }
    }
}
