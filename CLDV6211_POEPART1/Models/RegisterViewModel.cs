// C# class generated with assistance from ChatGPT

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CLDV6211_POEPART1.Models
{
    // Model for Register View Model
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email is required")] // Adding Required attribute with error message
        [EmailAddress(ErrorMessage = "Invalid Email Address")] // Adding EmailAddress attribute with error message
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")] // Adding Required attribute with error message
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)] // Adding StringLength attribute with error message
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")] // Adding Compare attribute with error message
        public string ConfirmPassword { get; set; }
    }
}