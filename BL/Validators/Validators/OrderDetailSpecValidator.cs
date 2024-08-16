using DAL.DTO.Entities;
using FluentValidation;

namespace BL.Validators.Validators
{
    public class OrderDetailSpecValidator : AbstractValidator<OrderDetailSpec>
    {
        public OrderDetailSpecValidator()
        {
            RuleFor(x => x.Spec)
                .NotNull().WithMessage("Özellik boş bırakılamaz.");

            RuleFor(x => x.OrderDetail)
                .NotNull().WithMessage("Sipariş detayı boş bırakılamaz.");
        }
    }
}
