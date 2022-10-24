using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication28.Models
{
    public class LoginPage
    {
        [Required]
        public string UserName { get; set; }
        //string UserName;
        [Required]
        public string Password { get; set; }
       

        //string Password;
    }
}
