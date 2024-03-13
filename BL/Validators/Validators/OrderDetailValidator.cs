using DAL.DTO.Entities;
using FluentValidation;

namespace BL.Validators.Validators
{
    public class OrderDetailValidator : AbstractValidator<OrderDetail>
    {
        public OrderDetailValidator()
        {
            RuleFor(x => x.Order)
                .NotNull().WithMessage("Bu ürünün ekleneceği siparişe ait nesne oluşturulmadı.");

            RuleFor(x => x.Product)
                .NotNull().WithMessage("Bir ürün seçin.");

            RuleFor(x => x.UnitCode)
                .NotNull().WithMessage("Birim kodu seçin.");

            //RuleFor(x => x.Order.OrderDetails.Count)
            //    .GreaterThan(1).WithMessage("Siparişe ait en az bir kalem bulunmak zorunda.");

            RuleFor(x => x.Quantity)
                .GreaterThan(0).WithMessage("Ürün adedi sıfıra eşit veya küçük olamaz.");

            RuleFor(x => x.UnitCost)
                .GreaterThan(0).WithMessage("Maliyet sıfıra eşit veya küçük olamaz.");

            RuleFor(x => x.UnitPrice)
                .GreaterThan(0).WithMessage("Fiyat sıfıra eşit veya küçük olamaz.");

            RuleFor(x => x.TaxRatio)
                .GreaterThanOrEqualTo(0).WithMessage("Vergi oranı 0 veya daha büyük olmalı.")
                .LessThanOrEqualTo(100).WithMessage("Vergi oranı 100 veya daha küçük olmalı.");

            RuleFor(x => x.DiscountRatio)
                .GreaterThanOrEqualTo(0).WithMessage("İskonto oranı en az sıfır olabilir.")
                .LessThanOrEqualTo(100).WithMessage("İskonto oranı en fazla yüz olabilir.");
        }
    }
}
