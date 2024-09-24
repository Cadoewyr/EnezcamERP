using DAL.DTO.Entities;
using FluentValidation;

namespace BL.Validators.Validators
{
    public class OvertimeOutgoingValidator : AbstractValidator<OvertimeOutgoing>
    {
        public OvertimeOutgoingValidator()
        {
            RuleFor(x => x.Outgoing)
                .GreaterThanOrEqualTo(0).WithMessage("Günlük gider 0 veya 0'dan büyük olmalıdır.");
        }
    }
}