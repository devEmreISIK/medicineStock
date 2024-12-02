using medicineStock.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace medicineStock.DataAccess.Abstractions
{
    public interface IRepository<T> where T : Entity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(Guid Id);
        IEnumerable<T> GetAll();
        T GetById(Guid Id);
        bool IfEntityExists(Expression<Func<T, bool>> filter);
    }
}
