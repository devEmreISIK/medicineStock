using FluentValidation;
using medicineStock.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicineStock.Business.Validators
{
    public class ReminderValidator : AbstractValidator<Reminder>
    {
        public ReminderValidator() 
        {
            RuleFor(m => m.MedicineID).NotEmpty().WithMessage("MedicineID cannot be empty!");
            RuleFor(r => r.UserID).NotEmpty().WithMessage("UserID boş olamaz.");
            RuleFor(r => r.RemindDate).GreaterThan(DateTime.Now).WithMessage("Hatırlatma tarihi gelecekte bir tarih olmalıdır.");
            RuleFor(r => r.IsActive).Must(value => value == true || value == false)
            .WithMessage("IsActive değeri doğru veya yanlış olmalıdır.");

        }

    }
}
