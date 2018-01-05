using Project_MVC.DL;
using Project_MVC.Models;
using Project_MVC.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Project_MVC.Controllers
{
    public class LoginController : Controller
    {
        //static CustomerViewModel cvm1 = new CustomerViewModel();
        public ActionResult LoginHome()
        {
            UserDal dal = new UserDal();
            List<User> objCustomers = dal.Customers.ToList<User>();


            CustomerViewModel cvm = new CustomerViewModel();
            cvm.Customer = new User();
            cvm.Customers = objCustomers;
            //cvm1.Customer = new User();
            //cvm1.Customers = objCustomers;
            //TempData["cvm"] = cvm;
            //return RedirectToAction("View_Customers", "LoginMng");
            //View_Customers(cvm);
            return View(cvm);
        }

        public ActionResult View_Customers() {
            UserDal dal = new UserDal();
            List<User> objCustomers = dal.Customers.ToList<User>();


            CustomerViewModel cvm = new CustomerViewModel();
            cvm.Customer = new User();
            cvm.Customers = objCustomers;
            return View(cvm);
        }


        public ActionResult Login(CustomerViewModel cvm)
        {
          
            if (ModelState.IsValid)
            {           
                return View("Enter_Cus", cvm);
            }
            else
            {
                ViewBag.message = "Please try Again";
                return View("LoginHome", cvm);
            }
  
            
        }

        public ActionResult Enter_Cus(CustomerViewModel cvm)
        {
            return View("Enter_Cus", cvm.Customer);

        }

        public ActionResult AddUser(CustomerViewModel cvm)
        {
            if (ModelState.IsValid)
            {
                UserDal dal = new UserDal();
                dal.Customers.Add(cvm.Customer);
                dal.SaveChanges();


                return View("Enter_Cus", cvm);
            }
            else
            {
                return View("Register", cvm);
            }
      
        }

        public ActionResult Register(CustomerViewModel cvm)
        {
                return View("Register", cvm);
  
               
            
        }
        
    }
}

