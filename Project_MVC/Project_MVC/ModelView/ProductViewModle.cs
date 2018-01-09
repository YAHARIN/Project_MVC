using Project_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_MVC.ModelView
{
    public class ProductViewModle
    {
        public Product product { get; set; }


        public List<Product> Products { get; set; }
    }
}