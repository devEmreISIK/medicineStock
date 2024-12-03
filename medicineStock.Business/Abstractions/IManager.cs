﻿using medicineStock.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace medicineStock.Business.Abstractions
{
    public interface IManager<T> where T : Entity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(Guid Id);
        IEnumerable<T> GetAll();
        T GetByID(Guid Id);
        bool IfEntityExists(Expression<Func<T, bool>> filter);
    }
}