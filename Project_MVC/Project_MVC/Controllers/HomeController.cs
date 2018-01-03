using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Yaharin Ben Ayon & Adar Figel";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Yaharin: yaharin@gmail.com Contact Adar: ";

            return View();
        }
    }
}