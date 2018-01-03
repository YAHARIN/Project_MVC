using Project_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_MVC.Controllers
{
    public class LoginMngController : Controller
    {
        // GET: LoginMng
        public ActionResult LoginHome_mng()
        {
            Manager mng = new Manager();
            ViewBag.message = "";
            return View(mng);
        }

        public ActionResult Login_Manager(Manager mng)
        {
            return View("LoginHome_mng", mng);
        }
        

    }
}