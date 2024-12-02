using medicineStock.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicineStock.DataAccess.Context
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
        }
    }
}
