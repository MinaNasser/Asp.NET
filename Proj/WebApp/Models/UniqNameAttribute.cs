using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class UniqNameAttribute: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
                return null;

            string newName = value.ToString();
            ITIContext context = new ITIContext();
           Employee employee= context.Employee.FirstOrDefault(e => e.Name == newName);
            if (employee != null)
            {
                return new ValidationResult("Name Must be Uniq");
            }
            return ValidationResult.Success;
        }
    }
}
