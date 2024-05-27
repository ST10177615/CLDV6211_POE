// C# class generated with assistance from ChatGPT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CLDV6211_POEPART1.Models
{
    // Model for Product
    public class Product
    {
        [Key] // Adding Key attribute to specify primary key
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name is required")] // Adding Required attribute with error message
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")] // Adding Required attribute with error message
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required")] // Adding Required attribute with error message
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.01")] // Adding Range attribute with error message
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public bool Availability { get; set; }
    }
}