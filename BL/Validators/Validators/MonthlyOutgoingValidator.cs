using DAL.DTO.Entities;
using FluentValidation;

namespace BL.Validators.Validators
{
    public class MonthlyOutgoingValidator : AbstractValidator<MonthlyOutgoing>
    {
        public MonthlyOutgoingValidator()
        {
            RuleFor(x => x.Month)
                .GreaterThanOrEqualTo(1).WithMessage("Ay değerleri 1 ile 12 arasında olabilir.")
                .LessThanOrEqualTo(12).WithMessage("Ay değerleri 1 ile 12 arasında olabilir.");

            RuleFor(x => x.Outgoing)
                .GreaterThanOrEqualTo(0).WithMessage("Sabit gider negatif bir değer olamaz.");
        }
    }
}
