using DAL.DTO.Entities;
using FluentValidation;

namespace EnezcamERP.Validators
{
    public class ProducedOrderValidator : AbstractValidator<ProducedOrder>
    {
        public ProducedOrderValidator()
        {
            RuleFor(x => x.ProducedDate)
                .GreaterThanOrEqualTo(x => x.OrderDetail.Order.IssueDate).WithMessage("Üretim tarihi sipariş tarihinden öncesi olamaz.");

            RuleFor(x => x.ProducedOrderQuantity).GreaterThan(0).WithMessage("Üretim miktarı 0 olamaz.");
        }
    }
}
