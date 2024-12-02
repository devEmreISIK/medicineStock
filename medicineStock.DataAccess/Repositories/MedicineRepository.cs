using medicineStock.DataAccess.Context;
using medicineStock.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicineStock.DataAccess.Repositories
{
    public class MedicineRepository : GenericRepository<Medicine>
    {
        public MedicineRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
        }
    }
}
