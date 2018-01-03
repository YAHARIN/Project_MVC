using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_MVC.Models
{
    public class User
    {
        [Key]
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}