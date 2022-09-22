using AmazonWeb.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonWeb.Core.Entities
{
    public class OrderItem : Entity
    {
        public int Quantity { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductID { get; set; }
        public decimal SubTotal { get; set; }
        public Product Product { get; set; }
    }
}
