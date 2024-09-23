using DAL.DTO.Entities;
using FluentValidation;

namespace BL.Validators.Validators
{
    public class ColumnSettingValidator : AbstractValidator<ColumnSetting>
    {
        public ColumnSettingValidator()
        {
            RuleFor(x => x.FormName)
                .NotEmpty()
                .NotNull().WithMessage("Form adı boş bırakılamaz.");

            RuleFor(x => x.IsActive)
                .NotNull();
        }
    }
}
