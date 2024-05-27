// C# class generated with assistance from ChatGPT

using CLDV6211_POEPART1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CLDV6211_POEPART1.Controllers
{
    public class TransactionController : Controller
    {
        private KhumaloCraftDBContext db = new KhumaloCraftDBContext();

        // GET: Transaction
        public ActionResult Index()
        {
            // Retrieve all transactions from the database
            var transactions = db.Transactions.ToList();
            return View(transactions);
        }
    }
}