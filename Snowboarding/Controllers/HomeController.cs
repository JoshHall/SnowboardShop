using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Snowboarding.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Home View
            return View();
        }

        public ActionResult Shop()
        {
            ViewBag.Message = "Your Shop Page";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SnowReports()
        {
            ViewBag.Message = "Your page with snow conditions/reports.";

            return View();
        }

        public ActionResult ShoppingCart()
        {
            ViewBag.Message = "Your Shopping Cart";

            return View();
        }
    }
}