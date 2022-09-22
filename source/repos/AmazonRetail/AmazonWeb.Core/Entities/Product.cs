using System;
using System.Collections.Generic;
using System.Text;

using AmazonWeb.Core.Entities.Base;
using System.ComponentModel.DataAnnotations;
namespace AmazonWeb.Core.Entities
{
    public class Product : Entity
    {
        [Required, StringLength(80)]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImageFile { get; set; }
        public int? UnitsInStock { get; set; }
        public double Star { get; set; }

        // 1-n Relationships
        //public List<Specification> Specifications { get; set; } = new List<Specification>();
        //public List<Review> Reviews { get; set; } = new List<Review>();
        //public List<Tag> Tags { get; set; } = new List<Tag>();

        // n - n Relationships
        //public List<ProductList> ProductLists { get; set; } = new List<ProductList>();


    }
}
