using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lab_3.Models;
using System.ComponentModel.DataAnnotations;

namespace lab_3.Validation
{
    public class ValidateMinAge : ValidationAttribute
    {
        // user's input age from the view (Studentinfor.cshtml) should be greater or equal to 18 right today (15th november, 2025)
        private readonly int _minAge = 18;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return new ValidationResult("Date of Birth is required");

            DateTime dob;
            if(!DateTime.TryParse(value.ToString(), out dob)) return new ValidationResult("Invalid date format");

            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;

            if (age < _minAge) return new ValidationResult("You must be at least 18 years old");

            return ValidationResult.Success;
        }
    }
}