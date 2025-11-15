using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using lab_3.Validation;

namespace lab_3.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[a-zA-Z\s\.\-]+$",
            ErrorMessage = "Name must contain only alphabets, spaces, dots, or dashes.")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [RegularExpression(@"^\S+$",
            ErrorMessage = "Username can not contain spaces")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "ID is required")]
        [RegularExpression(@"^\d{2}-\d{5}-[1-3]$",
            ErrorMessage = "ID must be in the format xx-xxxxx-x, where the first 7 digits are 0-9 and the last digit is 1-3.")]
        [Display(Name = "Id")]
        public string Id { get; set; }
        public string Address { get; set; }

        [Required]
        [ValidateEmailAddress] // custom email validation
        public string Email { get; set; }

        [Required]
        [ValidateMinAge] // custom age validation
        public DateTime DateOfBirth { get; set; }
    }
}