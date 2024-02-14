using DAL.DTO.Entities;
using FluentValidation;

namespace EnezcamERP.Validators
{
    public class OrderDetailValidator : AbstractValidator<OrderDetail>
    {
        public OrderDetailValidator()
        {
            RuleFor(x => x.Order)
                .NotNull().WithMessage("Bu ürünün ekleneceği siparişe ait nesne oluşturulmadı.");

            RuleFor(x => x.Product)
                .NotNull().WithMessage("Bir ürün seçin.");

            RuleFor(x => x.Quantity)
                .NotNull().NotEmpty().WithMessage("Ürün adedi girin.")
                .GreaterThan(0).WithMessage("Ürün adedi sıfıra eşit veya küçük olamaz.");

            RuleFor(x => x.UnitCost)
                .NotNull().NotEmpty().WithMessage("Maliyet boş bırakılamaz.")
                .GreaterThan(0).WithMessage("Maliyet sıfıra eşit veya küçük olamaz.");

            RuleFor(x => x.UnitPrice)
                .NotNull().NotEmpty().WithMessage("Fiyat boş bırakılamaz.")
                .GreaterThan(0).WithMessage("Fiyat sıfıra eşit veya küçük olamaz.");

            RuleFor(x => x.TaxRatio)
                .GreaterThanOrEqualTo(0).WithMessage("Vergi oranı 0 veya daha büyük olmalı.")
                .LessThanOrEqualTo(100).WithMessage("Vergi oranı 100 veya daha küçük olmalı.");
        }
    }
}
