using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_MVC.Models
{
    public class Manager
    {
        [Key]
        [Required]
        public string ManagerName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}