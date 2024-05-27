// C# class generated with assistance from ChatGPT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLDV6211_POEPART1.Models
{
    // Interface for Order Service
    public interface IOrderService
    {
        List<OrderViewModel> GetClientOrders();
    }

    // Implementation of Order Service
    public class OrderService : IOrderService
    {
        public List<OrderViewModel> GetClientOrders()
        {
            // Mock data for demonstration purposes
            return new List<OrderViewModel>
            {
                new OrderViewModel
                {
                    Order = new Order
                    {
                        OrderId = 1,
                        UserId = 123,
                        OrderDate = DateTime.Now.AddDays(-10),
                        TotalAmount = 99.99m
                    },
                    Transaction = new Transaction
                    {
                        TransactionDate = DateTime.Now.AddDays(-9),
                        PaymentStatus = "Completed"
                    }
                },
                // Add more orders as needed
            };
        }
    }
}