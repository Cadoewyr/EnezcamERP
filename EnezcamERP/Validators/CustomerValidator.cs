using DAL.DTO.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnezcamERP.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Cari adını girin.");
            RuleFor(x=>x.ContactName).NotEmpty().WithMessage("Yetkili adını girin.");
            RuleFor(x => x.ContactPhone).NotEmpty().WithMessage("Yetkili telefon numarasını girin.");
        }
    }
}
