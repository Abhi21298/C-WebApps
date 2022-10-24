using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationLAST.Models
{
    public class Stud
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public DateTime? RegisterationDate { get; set; }
        public int orderHistory { get; set; }
    }
}
