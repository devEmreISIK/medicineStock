using medicineStock.DataAccess.Context;
using medicineStock.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicineStock.DataAccess.Repositories
{
    public class ReportRepository : GenericRepository<Report>
    {
        public ReportRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
        }
    }
}
