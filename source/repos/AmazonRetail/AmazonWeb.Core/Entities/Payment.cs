using AmazonWeb.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AmazonWeb.Core.Entities
{
    public class Payment : Entity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public long Number { get; set; }
        [MinLength(16),MaxLength(16)]
        [Required]
        public int CVV { get; set; }
        [MinLength(5), MaxLength(5)]
        [Required]
        public string Expiry { get; set; }
    }
}
