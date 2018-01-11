using Project_MVC.DL;
using Project_MVC.Models;
using Project_MVC.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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

        public ActionResult View_Products()
        {
            //jason - view products
            UserDal dal = new UserDal();
            Thread.Sleep(7000);
            List<Product> objProducts = dal.Products.ToList<Product>();

            /*
            ProductViewModle pro = new ProductViewModle();
            pro.product = new Product();
            pro.Products = objProducts;
            */
            return Json(objProducts, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Login(CustomerViewModel cvm)
        {
            UserDal dal = new UserDal();
            List<User> objCustomers = dal.Customers.ToList<User>();

            if (ModelState.IsValid)
            {
                for (int i = 0; i < objCustomers.Count; i++)
                {
                    if (objCustomers[i].UserName.Equals(cvm.Customer.UserName))
                    {
                        return View("Enter_Cus");
                    }

                }
                return View("LoginHome");

            }
            else
            {
                ViewBag.message = "Please try Again";
                return View("LoginHome", cvm);
            }
  
            
        }

        public ActionResult Enter_Cus()
        {
            return View();
        }

        public ActionResult AddUser(CustomerViewModel cvm)
        {
            if (ModelState.IsValid)
            {
                UserDal dal = new UserDal();
                dal.Customers.Add(cvm.Customer);
                dal.SaveChanges();


                return View("Enter_Cus");
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

