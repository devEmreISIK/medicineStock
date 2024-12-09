    using System;
    using FluentValidation.Results;
    using medicineStock.Business.Abstractions;
    using medicineStock.Business.Validators;
    using medicineStock.DataAccess.Repositories;
    using medicineStock.Entities.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Linq.Expressions;

    namespace medicineStock.Business.Services
    {
        public class ReminderService : IManager<Reminder>
        {
            private readonly ReminderRepository _reminderRepository;

            public ReminderService(ReminderRepository reminderRepo)
            {
                _reminderRepository = reminderRepo;
            }

            public void Create(Reminder entity)
            {
                if (IfEntityExists(r => r.MedicineID == entity.MedicineID && r.UserID == entity.UserID && r.RemindDate == entity.RemindDate))
                {
                    throw new Exception("Bu hatırlatma zaten mevcut.");
                }

                ReminderValidator validator = new ReminderValidator();
                ValidationResult result = validator.Validate(entity);

                StringBuilder stringBuilder = new StringBuilder();
                result.Errors.ForEach(x => stringBuilder.AppendLine(x.ToString()));

                if (!result.IsValid)
                {
                    throw new Exception(stringBuilder.ToString());
                }

                _reminderRepository.Create(entity);
            }

            public void Delete(Guid Id)
            {
                _reminderRepository.Delete(Id);
            }

            public IEnumerable<Reminder> GetAll()
            {
                return _reminderRepository.GetAll();
            }


            public Reminder GetByID(Guid Id)
            {
                return _reminderRepository.GetById(Id);
            }

            public bool IfEntityExists(Expression<Func<Reminder, bool>> filter)
            {
                return _reminderRepository.IfEntityExists(filter);
            }

            public void Update(Reminder entity)
            {
                if (entity != null)
                {
                    ReminderValidator validator = new ReminderValidator();
                    ValidationResult result = validator.Validate(entity);

                    StringBuilder stringBuilder = new StringBuilder();
                    result.Errors.ForEach(x => stringBuilder.AppendLine(x.ToString()));

                    if (!result.IsValid)
                    {
                        throw new Exception(stringBuilder.ToString());
                    }

                    _reminderRepository.Update(entity);
                }
            }
        }
    }

