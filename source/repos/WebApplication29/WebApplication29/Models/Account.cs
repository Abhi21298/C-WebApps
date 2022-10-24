using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication29.Models
{
    public class Account
    {
        public long AccountID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Balance { get; set; }
    }
}