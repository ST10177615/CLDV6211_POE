// C# class generated with assistance from ChatGPT

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CLDV6211_POEPART1.Models
{
    // Model for Order Detail
    public class OrderDetail
    {
        [Key] // Adding Key attribute to specify primary key
        public int OrderDetailId { get; set; }

        [Required(ErrorMessage = "Order Id is required")] // Adding Required attribute with error message
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Product Id is required")] // Adding Required attribute with error message
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Quantity is required")] // Adding Required attribute with error message
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Price is required")] // Adding Required attribute with error message
        public decimal Price { get; set; }

        // Navigation properties
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}