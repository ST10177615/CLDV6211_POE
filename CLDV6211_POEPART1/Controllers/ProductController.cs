// C# class generated with assistance from ChatGPT

using CLDV6211_POEPART1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CLDV6211_POEPART1.Controllers
{
    public class ProductController : Controller
    {
        private KhumaloCraftDBContext db = new KhumaloCraftDBContext();

        // GET: Product
        public ActionResult Index()
        {
            // Retrieve all products from the database
            var products = db.Products.ToList();
            return View(products);
        }
    }
}