using Project_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_MVC.ModelView
{
    public class CustomerViewModel
    {
        public User Customer { get; set; }

        public List<User> Customers { get; set; }

    }
}