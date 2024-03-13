using FluentValidation.Results;
using System.Text;

namespace EnezcamERP.Validators
{
    public class ErrorStringify
    {
        public static string Stringify(List<ValidationFailure> errors)
        {
            StringBuilder stringBuilder = new();

            foreach (var error in errors)
            {
                stringBuilder.AppendLine(error.ErrorMessage);
            }

            return stringBuilder.ToString();
        }
    }
}
