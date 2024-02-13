using System.Text;

namespace EnezcamERP.Validators
{
    public class ErrorStringify
    {
        public static string Stringify(List<FluentValidation.Results.ValidationFailure> errors)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var error in errors)
            {
                stringBuilder.AppendLine(error.ErrorMessage);
            }

            return stringBuilder.ToString();
        }
    }
}
