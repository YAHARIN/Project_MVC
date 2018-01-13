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
        static string CusName;
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

        public ActionResult View_Customers_Jason()
        {
            //jason - view products
            UserDal dal = new UserDal();
            Thread.Sleep(7000);
            List<User> objCustomers = dal.Customers.ToList<User>();

            /*
            ProductViewModle pro = new ProductViewModle();
            pro.product = new Product();
            pro.Products = objProducts;
            */
            return Json(objCustomers, JsonRequestBehavior.AllowGet);
        }

        public ActionResult View_Customers()
        {
            return View("View_Customers");
        }


        public ActionResult Login(CustomerViewModel cvm1)
        {
            UserDal dal = new UserDal();
            List<User> objCustomers = dal.Customers.ToList<User>();
            List<Product> objProducts = dal.Products.ToList<Product>();
            ProductViewModle cvm = new ProductViewModle();

            cvm.product = new Product();
            cvm.Products = objProducts;
            if (ModelState.IsValid)
            {
                for (int i = 0; i < objCustomers.Count; i++)
                {
                    if (objCustomers[i].UserName.Equals(cvm1.Customer.UserName))
                    {
                        CusName = cvm1.Customer.UserName;
                        ViewBag.NameOfCust = CusName;
                        return View("Enter_Cus",cvm);
                    }

                }
                return View("LoginHome",cvm1);

            }
            else
            {
                ViewBag.message = "Please try Again";
                return View("LoginHome", cvm1);
            }
  
            
        }

        public ActionResult Enter_Cus()
        {
            
            return View("Enter_Cus");
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
        
        public ActionResult Purches_Aprroval()
        {
            UserDal dal = new UserDal();
 
            
            List<Purchase> objPurchases = dal.Purchase.ToList<Purchase>();
            ManagerViewModel mvv = new ManagerViewModel();
            mvv.Purchase = new Purchase();
            mvv.Purchases = objPurchases;
            

            return View("Purches_Aprroval", mvv);
        }

        public ActionResult Add_Purches(string mvm, string proName)
        {
            UserDal dal = new UserDal();
            ManagerViewModel mvv = new ManagerViewModel();
            mvv.Purchase = new Purchase();
            mvv.Purchase.UserName = CusName;
            mvv.Purchase.ProductName = proName;

            List<User> objCustomers = dal.Customers.ToList<User>();


            dal.Purchase.Add(mvv.Purchase);
            dal.SaveChanges();
            /*
            List<Purchase> objPurchases = dal.Purchase.ToList<Purchase>();
            ManagerViewModel mvv = new ManagerViewModel();
            mvv.Purchase = new Purchase();
            mvv.Purchases = objPurchases;
            */

           
            List<Product> objProducts = dal.Products.ToList<Product>();
            ProductViewModle cvm = new ProductViewModle();

            cvm.product = new Product();
            cvm.Products = objProducts;
            return View("Enter_Cus",cvm);
        }

     
        }
}

