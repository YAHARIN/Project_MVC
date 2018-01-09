using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_MVC.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int ProNum { get; set; }
        [Required]
        public string ProductName { get; set; }

        [Required]
        public string SerialNum { get; set; }

    }
}