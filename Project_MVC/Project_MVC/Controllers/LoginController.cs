using Project_MVC.DL;
using Project_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_MVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginHome()
        {
            User usr = new User();
            ViewBag.message = "";
            return View(usr);
        }
        
        public ActionResult Login(User usr)
        {
            if (ModelState.IsValid)
            {
                return View("Enter_Cus", usr);
            }
            else
            {
                ViewBag.message = "Please try Again";
                return View("LoginHome", usr);
            }
  
            
        }

        public ActionResult Enter_Cus(User usr)
        {
            return View(usr);

        }

        public ActionResult AddUser(User usr)
        {
            if (ModelState.IsValid)
            {
                UserDal dal = new UserDal();
                dal.Customers.Add(usr);
                dal.SaveChanges();


                return View("Enter_Cus", usr);
            }
            else
            {
                return View("Register", usr);
            }
      
        }

        public ActionResult Register(User usr)
        {
                return View("Register", usr);
  
               
            
        }
        
    }
}