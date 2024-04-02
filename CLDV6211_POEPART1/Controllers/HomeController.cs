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
            // Fetch products from database or mock data
            List<Product> products = GetProductsFromDatabaseOrMock();
            return View(products);
        }

        private List<Product> GetProductsFromDatabaseOrMock()
        {
            // Implement logic to fetch products from database or mock data
            // For demonstration purposes, I'll use mock data
            return new List<Product>
        {
           new Product { Id = 1, Name = "Handcrafted Mug", Description = "Beautifully crafted ceramic mug", Price = 10.99m, ImageUrl = "Mug.jpg" },
            new Product { Id = 2, Name = "Wooden Jewelry Box", Description = "Hand-carved jewelry box made from solid wood", Price = 29.99m, ImageUrl = "Jewellery box.png" }
            // Add more products as needed
        };
        }
    }
}