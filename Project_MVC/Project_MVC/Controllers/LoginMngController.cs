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
            UserDal dal = new UserDal();
            List<Manager> objManagers = dal.Managers.ToList<Manager>();
            if (ModelState.IsValid)
            {
                for(int i =0;i<10; i++)
                {

                }
                return View("Enter_Mng");
            }
            else
            {
                return View("LoginHome_mng", mng);
            }
        }
        
        

    }
}