using FluentValidation;
using FluentValidation.Results;
using medicineStock.Business.Abstractions;
using medicineStock.Business.Validators;
using medicineStock.DataAccess.Repositories;
using medicineStock.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace medicineStock.Business.Services
{
    public class MedicineService : IManager<Medicine>
    {
        private readonly MedicineRepository _medicineRepository;

        public MedicineService(MedicineRepository mRepo)
        {
            _medicineRepository = mRepo;
        }

        public void Create(Medicine entity)
        {
            if (IfEntityExists(s => s.MedicineName == entity.MedicineName))
            {
                throw new Exception("This medicine already created!");
            }

            MedicineValidator uVal = new MedicineValidator();
            ValidationResult result = uVal.Validate(entity);
            StringBuilder stringBuilder = new StringBuilder();
            result.Errors.ForEach(x => stringBuilder.AppendLine(x.ToString()));

            if (!result.IsValid)
            {
                throw new Exception(stringBuilder.ToString());
            }

            _medicineRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            _medicineRepository.Delete(Id);
        }

        public IEnumerable<Medicine> GetAll()
        {
            return _medicineRepository.GetAll();
        }

        public Medicine GetByID(Guid Id)
        {
            return _medicineRepository.GetById(Id);
        }

        public bool IfEntityExists(Expression<Func<Medicine, bool>> filter)
        {
            return _medicineRepository.IfEntityExists(filter);
        }

        public void Update(Medicine entity)
        {
            if (entity != null)
            {
                _medicineRepository.Update(entity);
            }
        }
    }
}
