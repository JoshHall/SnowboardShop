using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Snowboarding.Controllers
{
    public class HomeController : Controller
    {
        private static SnowGear _db = new SnowGear();
        public ActionResult Index()
        {
            //Home View
            return View();
        }

        public ActionResult Shop()
        {
            ViewBag.Message = "Your Shop Page";


            var query = from g in _db.Products
                        orderby g.Id
                        select g;

            return View(query);

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

            var query = from g in _db.CartItems
                        select g;

            return View(query);
        }

        [HttpPost]

        public ActionResult AddToCart(int id)
        {
            var product = _db.Products.Find(id);
            var addItem = new CartItem { ProductID = id , Product = product, Quantity = 1 };
            _db.CartItems.Add(addItem);
            _db.SaveChanges();

            var query = from g in _db.CartItems
                        select g;

            return View("Shop",query);
        }

        public ActionResult RemoveFromCart(int id)
        {
            var toDelete = _db.CartItems.Find(2); 
            _db.CartItems.Remove(toDelete);
            _db.SaveChanges();

            return View();
        }

    }
}

/* 
--Create--
    var addToCart = new Cart { Name =  };
    _db.CartItems.Add(addToCart);
    _db.SaveChanges();

        --Read--
    var query = from g in _db.CartItems
              orderby g.Id
              select g;

    foreach (var item in query)
    {
        ***DO SOMETHING**
    }

        --Update--
    var toChange = _db.CartItems.Find(1);
    toChange.Quantity =  **CHANGE QUANTITY**
    _db.SaveChanges();

        --Delete--
    var toDelete = db.Carts.Find(2); **INPUT IS THE ID/PRIMARY KEY**
    _db.CartItems.Remove(toDelete);
    _db.SaveChanges();
*/
