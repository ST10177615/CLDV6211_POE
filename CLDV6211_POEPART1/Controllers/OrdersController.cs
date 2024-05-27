// C# class generated with assistance from ChatGPT

using CLDV6211_POEPART1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CLDV6211_POEPART1.Controllers
{
    public class OrdersController : Controller
    {
        private readonly OrderService _orderService;

        public OrdersController()
        {
            _orderService = new OrderService();
        }
        // GET: Orders
        public ActionResult ViewClientOrders()
        {
            var orders = _orderService.GetClientOrders();
            return View(orders);
        }
    }
}