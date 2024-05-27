// C# class generated with assistance from ChatGPT

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CLDV6211_POEPART1.Models
{
        // Model for User
        public class User
        {
            [Key] // Adding Key attribute to specify primary key
            public int UserId { get; set; }

            [Required(ErrorMessage = "Username is required")] // Adding Required attribute with error message
            public string Username { get; set; }

            [Required(ErrorMessage = "Password is required")] // Adding Required attribute with error message
            public string Password { get; set; }

            [Required(ErrorMessage = "Email is required")] // Adding Required attribute with error message
            [EmailAddress(ErrorMessage = "Invalid Email Address")] // Adding EmailAddress attribute with error message
            public string Email { get; set; }
        }
    }
