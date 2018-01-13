using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_MVC.Models
{
    public class Purchase
    {
        [Key]
        [Required]
        public int PurNum { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string ProductName { get; set; }


    }
}