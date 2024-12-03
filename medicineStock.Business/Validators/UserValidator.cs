using FluentValidation;
using medicineStock.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicineStock.Business.Validators
{
    internal class UserValidator : AbstractValidator<User>
    {
        public UserValidator() 
        {
            RuleFor(u => u.Name).NotEmpty().WithMessage("Kullanıcının ismi boş kalamaz!");
            RuleFor(u => u.Surname).NotEmpty().WithMessage("Kullanıcının soyismi boş kalamaz!");
            RuleFor(u => u.Email).NotEmpty().WithMessage("Kullanıcının mail bilgisi boş kalamaz!");
            RuleFor(u => u.Phone).NotEmpty().WithMessage("Kullanıcının telefon bilgisi boş kalamaz!");
            RuleFor(u => u.TCno).NotEmpty().WithMessage("Kullanıcının kimlik bilgisi boş kalamaz!");
        }
    }
}
