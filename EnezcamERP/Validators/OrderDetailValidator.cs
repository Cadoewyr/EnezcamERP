using DAL.DTO.Entities;
using FluentValidation;

namespace EnezcamERP.Validators
{
    public class OrderDetailValidator : AbstractValidator<OrderDetail>
    {
        public OrderDetailValidator()
        {
            RuleFor(x => x.Order).NotNull().WithMessage("Bu ürünün ekleneceği siparişe ait nesne oluşturulmadı.");
            RuleFor(x => x.Product).NotNull().WithMessage("Bir ürün seçin.");
            RuleFor(x => x.Quantity).NotNull().NotEmpty().WithMessage("Ürün adedi girin.");
            RuleFor(x => x.Quantity).GreaterThan(0).WithMessage("Ürün adedi sıfıra eşit veya küçük olamaz.");
            RuleFor(x => x.UnitCost).NotNull().NotEmpty().WithMessage("Maliyet boş bırakılamaz.");
            RuleFor(x => x.UnitCost).GreaterThan(0).WithMessage("Maliyet sıfıra eşit veya küçük olamaz.");
            RuleFor(x => x.UnitPrice).NotNull().NotEmpty().WithMessage("Fiyat boş bırakılamaz.");
            RuleFor(x => x.UnitPrice).GreaterThan(0).WithMessage("Fiyat sıfıra eşit veya küçük olamaz.");
        }
    }
}
