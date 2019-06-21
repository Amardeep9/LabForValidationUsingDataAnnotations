using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabForValidationUsingDataAnnotations.Models
{
    public class Employee
    {
        [Required (ErrorMessage =" Please Enter UserName")]
        [StringLength(30)]

        [Display(Name = "Enter UserName")]
        public string username { get; set; }

        [Required(ErrorMessage = " Please Enter Email")]
       // [RegularExpression(" .+@.+\\..+ ", ErrorMessage= "Email format is not good ")]

          [Display(Name="Enter Mail")]
        public string Email { get; set; }
        [Range(20,35)]
        [Required]
        public string Age { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage ="Password and ConfirmPassword Should Match")]
        public string ConfirmPassword { get; set; }
        [ValidateCheckBox(ErrorMessage ="Please Check terms and Conditions")]
        public bool Terms { get; set; }

        public class ValidateCheckBox : RequiredAttribute
        {
            public override bool IsValid(object value)
            {
                return (bool)value;
            }
        }
    }
}