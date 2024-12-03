using FluentValidation;
using medicineStock.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicineStock.Business.Validators
{
    public class SupplierValidator : AbstractValidator<Supplier>
    {
        public SupplierValidator()
        {
            RuleFor(s => s.SupplierName).NotEmpty().WithMessage("Supplier Name cannot be empty!");
            RuleFor(s => s.SupplierAddress).NotEmpty().WithMessage("Supplier Address cannot be empty!");
            RuleFor(s => s.SupplierPhone).NotEmpty().WithMessage("Supplier Phone cannot be empty!");
        }
    }
}
