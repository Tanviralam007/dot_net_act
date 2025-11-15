using lab_3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab_3.Validation
{
    public class ValidateEmailAddress : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = validationContext.ObjectInstance as Student;

            string email = model.Email;
            string id = model.Id;
            string ExpectedEmail = id + "@student.aiub.edu";

            if (!(email.Equals(ExpectedEmail, StringComparison.OrdinalIgnoreCase)))
            {
                return new ValidationResult($"Email must be in the following format: {ExpectedEmail}");
            }

            return ValidationResult.Success;
        }
    }
}