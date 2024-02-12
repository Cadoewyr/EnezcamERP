using BL.Repositories;
using DAL.DTO.Entities;
using FluentValidation;

namespace EnezcamERP.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Ürün adı boş bırakılamaz.")
                .MinimumLength(3).WithMessage("Ürün adı en az 3 karakter uzunluğunda olmalı.");
                
            RuleFor(x => x.Type)
                .NotNull().WithMessage("İşlem tipi boş bırakılamaz.");
        }
    }
}
