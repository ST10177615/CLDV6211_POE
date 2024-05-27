// C# class generated with assistance from ChatGPT

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CLDV6211_POEPART1.Models
{
    // Model for Order
    public class Order
    {
        [Key] // Adding Key attribute to specify primary key
        public int OrderId { get; set; }

        [Required(ErrorMessage = "UserId is required")] // Adding Required attribute with error message
        public int UserId { get; set; }

        [Display(Name = "Order Date")] // Display attribute for better labeling
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Total Amount is required")] // Adding Required attribute with error message
        public decimal TotalAmount { get; set; }

        // Navigation property to User
        public virtual User User { get; set; }
        public Transaction Transaction { get; internal set; }
    }
}