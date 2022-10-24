using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication20Exercise1.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public DateTime? OrderTime { get; set; }
        public IEnumerable<Product> Products { get; set; }

    }
}
