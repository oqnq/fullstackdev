using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebshopAdmin.DataAccess;

namespace WebshopAdmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            WebshopContext db = new WebshopContext();
            
            return View(
                db.Products.ToList()
                .OrderBy(p=>p.UpdatedOn).Reverse()
                );
        }

        public ActionResult About()
        {
            ViewBag.Message = "Feladat kiírás.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}