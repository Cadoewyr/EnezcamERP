using DAL.DTO.Entities;
using FluentValidation;

namespace BL.Validators.Validators
{
    public class ProducedOrderValidator : AbstractValidator<ProducedOrder>
    {
        public ProducedOrderValidator()
        {
            RuleFor(x => x.ProducedDate)
                .GreaterThanOrEqualTo(x => x.OrderDetail.Order.IssueDate).WithMessage("Üretim tarihi sipariş tarihinden öncesi olamaz.");

            RuleFor(x => x.ProducedOrderQuantity)
                .GreaterThan(0).WithMessage("Üretim miktarı 0 olamaz.")
                .LessThanOrEqualTo(x => x.OrderDetail.Quantity - x.OrderDetail.ProducedQuantity).WithMessage("Üretim miktarı kalan üretim miktarından fazla olamaz.");
        }
    }
}
