using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicE_commerece.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Models.basicE_commerceEntities1 db = new Models.basicE_commerceEntities1();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View(db.Products.ToList());
        }
        public ActionResult ProductAdd()
        {
            return View();
        }
    }

}