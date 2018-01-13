using Project_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_MVC.ModelView
{
    public class ManagerViewModel
    {
     public Manager Manager { get; set; }

     public List<Manager> Managers { get; set; }

     public Purchase Purchase { get; set; }

     public List<Purchase> Purchases { get; set; }

    }
}
