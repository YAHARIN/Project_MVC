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
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Length must be betweeb 2 - 50 carecter")]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}