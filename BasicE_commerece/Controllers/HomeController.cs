using BasicE_commerece.Models;
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

        basicE_commerceEntities1 db = new basicE_commerceEntities1();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product()
        {
            return View(db.Products.ToList());
        }
        [HttpGet]
        public ActionResult ProductAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ProductAdd([Bind(Include ="Id,Name,Description,Image,Stock,Price" )]Product product)
        {

            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Product");
            }
           
                return View();
        }
        public ActionResult Slider()
        {
            return View(db.Sliders.ToList());
        }

        public ActionResult Comment()
        {
            return View(db.Comments.ToList());
        }
    }

}