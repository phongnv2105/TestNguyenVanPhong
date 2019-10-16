using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_NguyenVanPhong.Models
{
    public class User
    {   
        [Key]
        public int userId { get; set; } 
        [Required]
        public string  FirstName { get; set; }
        [Required]
        public string  LastName { get; set; }
        [Required]
        [RegularExpression(@"^(([\w])+(@)+([\w])+(.)+([a-zA-Z]{2,4}))$", ErrorMessage = "Email invalidate!")]
        public string  Email { get; set; }
        [Required]
        public string  Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [RegularExpression(@"^(([07]||[08]||[09]||[03]||[05])+([\d]{8}))$", ErrorMessage = "Phone Number invalidate!")]
        public string  Phone { get; set; }
        [Required]
        public DateTime  Birthday { get; set; }
        
        public string  Avatar { get; set; }


    }
}