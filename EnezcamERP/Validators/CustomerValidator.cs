using BL.Repositories;
using DAL.DTO.Entities;
using FluentValidation;

namespace EnezcamERP.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Cari adını girin.")
                .MinimumLength(3).WithMessage("Cari adı en az 3 karakter uzunluğunda olmalı.");
        }
    }
}
