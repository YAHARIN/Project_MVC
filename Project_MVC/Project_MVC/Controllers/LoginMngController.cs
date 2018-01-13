using Project_MVC.DL;
using Project_MVC.Models;
using Project_MVC.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Project_MVC.Controllers
{
    public class LoginMngController : Controller
    {
        // GET: LoginMng
        public ActionResult LoginHome_mng()
        {
            UserDal dal = new UserDal();
            List<Manager> objManagers= dal.Managers.ToList<Manager>();

            ManagerViewModel cvm = new ManagerViewModel();
            cvm.Manager = new Manager();
            cvm.Managers = objManagers;
            return View(cvm);
        }

        public ActionResult Login_Manager(ManagerViewModel mng)
        {
            UserDal dal = new UserDal();
            List<Manager> objManagers = dal.Managers.ToList<Manager>();

            if (ModelState.IsValid)
            {
                for (int i = 0; i < objManagers.Capacity; i++)
                {
                   if(objManagers[i].ManagerName.Equals(mng.Manager.ManagerName))
                    {
                        return View("Enter_Mng");
                    }
               
                }
                //ScriptManager.RegisterStartupScript(this.GetType(), typeof(string), "Alert", "alert('Message here');", true);
                
                return View("LoginHome_mng");

            }
            else
            {
                return View("LoginHome_mng");
            }
        }
        
        public ActionResult Enter_Mng()
        {
            return View();
        }

    }
}