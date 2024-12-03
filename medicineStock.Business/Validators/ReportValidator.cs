using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using FluentValidation;
using medicineStock.Entities.Models;
namespace medicineStock.Business.Validators
{
    public class ReportValidator : AbstractValidator<Report>
    {
        public ReportValidator()
        {

            RuleFor(r => r.UserID).NotEmpty().WithMessage("UserID boş olamaz.");
            RuleFor(r => r.Content).NotEmpty().WithMessage("Rapor içeriği boş olamaz.").MinimumLength(10).WithMessage("Rapor içeriği en az 10 karakter olmalıdır.");
        }
    }
}
