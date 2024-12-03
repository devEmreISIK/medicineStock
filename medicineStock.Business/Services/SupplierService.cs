using FluentValidation.Results;
using medicineStock.Business.Abstractions;
using medicineStock.Business.Validators;
using medicineStock.DataAccess.Context;
using medicineStock.DataAccess.Repositories;
using medicineStock.Entities.Models;
using System.Linq.Expressions;
using System.Text;

namespace medicineStock.Business.Services
{
    public class SupplierService : IManager<Supplier>
    {
        private readonly SupplierRepository _supplierRepository;

        public SupplierService(SupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public void Create(Supplier entity)
        {
            if (IfEntityExists(s => s.SupplierName == entity.SupplierName))
            {
                throw new Exception("This supplier already created!");
            }

            SupplierValidator uVal = new SupplierValidator();
            ValidationResult result = uVal.Validate(entity);
            StringBuilder stringBuilder = new StringBuilder();
            result.Errors.ForEach(x => stringBuilder.AppendLine(x.ToString()));

            if (!result.IsValid)
            {
                throw new Exception(stringBuilder.ToString());
            }

            _supplierRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            _supplierRepository.Delete(Id);
        }

        public IEnumerable<Supplier> GetAll()
        {
            return _supplierRepository.GetAll();
        }

        public Supplier GetByID(Guid Id)
        {
            return _supplierRepository.GetById(Id);
        }

        public bool IfEntityExists(Expression<Func<Supplier, bool>> filter)
        {
            return _supplierRepository.IfEntityExists(filter);
        }

        public void Update(Supplier entity)
        {
            if (entity != null)
            {
                _supplierRepository.Update(entity);
            }
        }
    }
}
