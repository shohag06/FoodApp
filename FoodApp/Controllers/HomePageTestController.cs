using FoodApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodApp.Controllers
{
    public class HomePageTestController : Controller
    {

        AppFoodDbContext db = new AppFoodDbContext();
        // GET: HomePageTest
        public ActionResult Index()
        {
            List<Products> products = db.Products.ToList<Products>();
            return View(products);


        }
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}