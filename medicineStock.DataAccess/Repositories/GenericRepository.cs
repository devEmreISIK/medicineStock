using medicineStock.DataAccess.Abstractions;
using medicineStock.Entities.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace medicineStock.DataAccess.Context
{
    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            _dbSet.Remove(GetById(Id));
            _dbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(Guid Id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == Id) ?? throw new Exception("Cannot Find!");
        }

        public bool IfEntityExists(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Any(filter);
        }

        public void Update(T entity)
        {
            _dbContext.SaveChanges();
        }
    }
}
