﻿using Project_MVC.Models;
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
                return View("LoginHome", usr);
            }
  
            
        }

        public ActionResult Enter_Cus(User usr)
        {
            return View(usr);

        }



        public ActionResult Register()
        {
            User usr = new Models.User();
            return View(usr);
        }
        public ActionResult AddUser(User usr)
        {
            return View("Register",usr);
        }
    }
}