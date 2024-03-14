using DAL.DTO.Entities;
using FluentValidation;

namespace BL.Validators.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name)
                .MinimumLength(3).WithMessage("Ürün adı en az 3 karakter uzunluğunda olmalı.");

            RuleFor(x => x.Type)
                .NotNull().WithMessage("İşlem tipi boş bırakılamaz.");

            RuleFor(x => x.Code)
                .MinimumLength(3).WithMessage("Ürün kodu en az 3 uzunluğunda olmalıdır.");
        }
    }
}
