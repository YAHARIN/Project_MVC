using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Linq;
using System.Web;

namespace Project_MVC.Models
{
    public class User
    {
        [Key]
        [Required]
        public int CustNum { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Length must be betweeb 2 - 50 carecter")]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}