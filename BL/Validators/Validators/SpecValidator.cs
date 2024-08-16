using DAL.DTO.Entities;
using FluentValidation;

namespace BL.Validators.Validators
{
    public class SpecValidator : AbstractValidator<Spec>
    {
        public SpecValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Özellik adı boş bırakılamaz.")
                .NotEmpty().WithMessage("Özellik adı boş bırakılamaz.");
        }
    }
}
