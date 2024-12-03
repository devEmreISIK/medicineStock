using FluentValidation;
using medicineStock.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicineStock.Business.Validators
{
    public class MedicineValidator : AbstractValidator<Medicine>
    {
        public MedicineValidator()
        {
            RuleFor(m => m.MedicineName).NotEmpty().WithMessage("Medicine name cannot be empty!");
            RuleFor(m => m.MedicineBrand).NotEmpty().WithMessage("Medicine brand cannot be empty!");
            RuleFor(m => m.Stock).NotEmpty().WithMessage("Medicine stock cannot be empty!");
            RuleFor(m => m.Dosage).NotEmpty().WithMessage("Medicine dosage cannot be empty!");
            RuleFor(m => m.UsageWeek).NotEmpty().WithMessage("Medicine usage week cannot be empty!");
            RuleFor(m => m.Supplier).NotNull().WithMessage("Medicine supplier cannot be empty!");
        }
    }
}
