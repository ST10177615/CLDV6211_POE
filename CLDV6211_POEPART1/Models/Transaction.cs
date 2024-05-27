// C# class generated with assistance from ChatGPT

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CLDV6211_POEPART1.Models
{
    // Model for Transaction
    public class Transaction
    {
        [Key] // Adding Key attribute to specify primary key
        public int TransactionId { get; set; }

        [Required(ErrorMessage = "User ID is required")] // Adding Required attribute with error message
        public int UserId { get; set; }

        [Required(ErrorMessage = "Order ID is required")] // Adding Required attribute with error message
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Transaction date is required")] // Adding Required attribute with error message
        public DateTime TransactionDate { get; set; }

        [Required(ErrorMessage = "Payment status is required")] // Adding Required attribute with error message
        public string PaymentStatus { get; set; }
    }
}