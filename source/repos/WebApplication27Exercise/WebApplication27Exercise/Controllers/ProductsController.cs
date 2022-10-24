using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication27Exercise.Models;

namespace WebApplication27Exercise.Controllers
{
    public class ProductsController : ApiController
    {
        public static List<Product> prod = new List<Product>();

        public ProductsController()
        {
            prod.Add(new Product { ID = 1, Name = "tea", Cost = 20M });
            prod.Add(new Product { ID = 2, Name = "Coffee", Cost = 30M });
            prod.Add(new Product { ID = 3, Name = "Milk", Cost = 5M });
        }
        // GET: api/Products
        public IEnumerable<Product> Get()
        {
            //return new string[] { "value1", "value2" };
            return prod;
        }

        // GET: api/Products/5
        public Product Get(int id)
        {
            //return "value";
            int index = prod.FindIndex(p => p.ID == id);
            if (index == -1)
                return null;
            return prod.Find(p => p.ID == id);
        }

        // POST: api/Products
        public string Post([FromBody]Product value)
        {
            if(value!=null)
            {
                prod.Add(value);
                return "Added successfully";
            }
            return "Error adding";
        }

        // PUT: api/Products/5
        public string Put(int id, [FromBody]Product value)
        {
            int index = prod.FindIndex(p => p.ID == id);
            if (index == -1)
                return "Couldn't find product";
            prod.RemoveAt(index);
            prod.Add(value);
            return "Updated successfully";
        }

        // DELETE: api/Products/5
        public string Delete(int id)
        {
            int index = prod.FindIndex(p => p.ID == id);
            if (index == -1)
                return "Couldn't find product";
            prod.RemoveAt(id);
            return "deleted successfully";
        }
    }
}
