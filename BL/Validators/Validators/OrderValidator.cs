using DAL.DTO.Entities;
using FluentValidation;

namespace BL.Validators.Validators
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(x => x.OrderDetails)
                .NotNull().NotEmpty().WithMessage("Siparişe ait herhangi bir kalem yok.");

            RuleFor(x => x.OrderDetails.SelectMany(x => x.ProducedOrders).DefaultIfEmpty(new() { ProducedDate = x.IssueDate.AddMicroseconds(1) }).Min(x => x.ProducedDate))
                .GreaterThanOrEqualTo(x => x.IssueDate).WithMessage("Sipariş tarihi siparişe ait üretim tarihlerinden daha ileri bir tarih olamaz.");

            RuleFor(x => x.IssueDate)
                .LessThanOrEqualTo(x => x.DeliveryDate).WithMessage("Sipariş tarihi teslim tarihinden ileri bir tarih olamaz.")
                .NotNull().NotEmpty().WithMessage("Sipariş tarihi boş bırakılamaz.");

            RuleFor(x => x.DeliveryDate)
                .NotNull().NotEmpty().WithMessage("Teslim tarihi boş bırakılamaz.")
                .GreaterThanOrEqualTo(x => x.IssueDate).WithMessage("Teslim tarihi sipariş tarihinden erken bir tarih olamaz.");

            RuleFor(x => x.Customer)
                .NotNull().NotEmpty().WithMessage("Cari boş bırakılamaz.");

            RuleFor(x => x.JobNo)
                .NotNull().NotEmpty().WithMessage("Sipariş numarası boş bırakılamaz.")
                .GreaterThan(0).WithMessage("Sipariş numarası boş veya 1'den küçük olamaz.");
        }
    }
}
