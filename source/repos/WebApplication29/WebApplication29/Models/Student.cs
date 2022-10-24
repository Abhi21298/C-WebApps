using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication29.Models
{
    public class Student
    {
       
        [Required]
        public string Name { get; set; }
       
        [Required]
        public long RollNumber { get; set; }
        [Required]
        public string Course { get; set; }
    }
}