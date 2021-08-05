using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SignUpPage.Attributes;

namespace SignUpPage.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please Enter Name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Username.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Password.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Confirm Password.")]
        [Compare("Password",ErrorMessage = "Confirm Password Doesn't Match.")]
        public string ConfirmPassword { get; set; }

        [RegularExpression ("^[6789]\\d{9}$", ErrorMessage ="Please Enter Correct Contact Number.")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please Enter Country.")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please Select City.")]
        public string City { get; set; }
   
        [Required(ErrorMessage = "Please Select Gender.")]
        public string Gender { get; set; }

        [ValidateCheckBox(ErrorMessage = "Please Accept Terms.")]
        public bool Terms { get; set; }
    }


    
}
