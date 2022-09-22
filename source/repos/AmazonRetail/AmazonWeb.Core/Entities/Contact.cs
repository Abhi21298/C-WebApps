using AmazonWeb.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace AmazonWeb.Core.Entities
{
    public class Contact : Entity
    {
        [Required]
        public string Name { get; set; }
        public string Phone { get; set; }
        [Phone]
        [Required]
        public string Email { get; set; }
        [MinLength(12)]
        [Required]
        public string Message { get; set; }
    }
}
