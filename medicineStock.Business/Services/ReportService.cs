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
    public class ReportService : IManager<Report>
    {
        private readonly ReportRepository _reportRepository;

        public ReportService(ReportRepository rRepo)
        {
            _reportRepository = rRepo;
        }

        public void Create(Report entity)
        {
            if (IfEntityExists(r => r.UserID == entity.UserID && r.Content == entity.Content))
            {
                throw new Exception("This report already exists!");
            }

            ReportValidator validator = new ReportValidator();
            ValidationResult result = validator.Validate(entity);
            StringBuilder stringBuilder = new StringBuilder();
            result.Errors.ForEach(x => stringBuilder.AppendLine(x.ToString()));

            if (!result.IsValid)
            {
                throw new Exception(stringBuilder.ToString());
            }

           
            _reportRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            _reportRepository.Delete(Id);
        }

        public IEnumerable<Report> GetAll()
        {
            return _reportRepository.GetAll();
        }

        public Report GetByID(Guid Id)
        {
            return _reportRepository.GetById(Id);
        }

        public bool IfEntityExists(Expression<Func<Report, bool>> filter)
        {
            return _reportRepository.IfEntityExists(filter);
        }

        public void Update(Report entity)
        {
            if (entity != null)
            {

                ReportValidator validator = new ReportValidator();
                ValidationResult result = validator.Validate(entity);
                StringBuilder stringBuilder = new StringBuilder();
                result.Errors.ForEach(x => stringBuilder.AppendLine(x.ToString()));

                if (!result.IsValid)
                {
                    throw new Exception(stringBuilder.ToString());
                }


                _reportRepository.Update(entity);
            }
        }
    }

}
