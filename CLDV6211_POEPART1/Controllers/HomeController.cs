// C# class generated with assistance from ChatGPT

using CLDV6211_POEPART1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CLDV6211_POEPART1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderService _orderService;

        private KhumaloCraftDBContext db = new KhumaloCraftDBContext();

        public Models.Order OrderId { get; private set; }
        public Models.OrderDetail OrderDetailId { get; private set; }
        public Models.Transaction TransactionId { get; private set; }

        public HomeController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult MyWork()
        {
            var products = db.Products.ToList(); // Fetch products from database
            return View(products);
        }

        [HttpPost]
        public ActionResult PlaceOrder(int productId, int quantity)
        {
            var product = db.Products.Find(productId);
            if (product == null)
            {
                return HttpNotFound();
            }

            var userId = 1; // Replace with actual user ID from session or authentication mechanism
            var order = new Order
            {
                UserId = userId,
                OrderDate = DateTime.Now,
                TotalAmount = product.Price * quantity
            };
            db.Orders.Add(OrderId);
            db.SaveChanges();

            var orderDetail = new OrderDetail
            {
                OrderId = order.OrderId,
                ProductId = product.ProductId,
                Quantity = quantity,
                Price = product.Price
            };
            db.OrderDetails.Add(OrderDetailId);
            db.SaveChanges();

            // Insert transaction data into Transactions table
            var transaction = new Transaction
            {
                UserId = userId,
                OrderId = order.OrderId,
                TransactionDate = DateTime.Now,
                PaymentStatus = "Pending" // You may adjust this based on your payment process
            };
            db.Transactions.Add(TransactionId);
            db.SaveChanges();

            return RedirectToAction("MyWork");
        }

        // Implement functionality for KhumaloCraft staff to view and process client orders
        public ActionResult ViewClientOrders()
        {
            var orders = _orderService.GetClientOrders();
            return View("ViewClientOrders", orders);
        }

        // Implement functionality for clients to view their previous orders
        public ActionResult ViewUserOrders(int? userId)
        {
            if (userId == null)
            {
                // Handle the case where userId is null, such as displaying an error message or redirecting to another page.
                // For example:
                return RedirectToAction("Index", "Home"); // Redirect to the home page
            }

            var userOrders = (from o in db.Orders
                              join t in db.Transactions on o.OrderId equals t.OrderId
                              where t.UserId == userId
                              select new { Order = o, Transaction = t }).ToList();

            return View("ViewOrders", userOrders);
        }
    }
}

