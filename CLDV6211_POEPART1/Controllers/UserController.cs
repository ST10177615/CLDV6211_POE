// C# class generated with assistance from ChatGPT

using CLDV6211_POEPART1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CLDV6211_POEPART1.Controllers
{
    public class UserController : Controller
    {
        private KhumaloCraftDBContext db = new KhumaloCraftDBContext();

        // GET: User
        public ActionResult Index()
        {
            // Retrieve all users from the database
            var users = db.Users.ToList();
            return View(users);
        }
    }
}