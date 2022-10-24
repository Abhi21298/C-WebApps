using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationLASTDAY1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationLASTDAY1.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public static List<Product> prod = new List<Product>()
        {
            new Product{ Id=1, Name="tea",Price=20.0},
            new Product{ Id=2, Name="coffee",Price=30.0},
            new Product{ Id=3, Name="milk",Price=10.0}
        };
        
        

        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return prod.ToArray();
            //return new string[] { "value1", "value2" };
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return prod.Find(p => p.Id == id);
            //return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            prod.Add(value);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Product value)
        {
            int index = prod.FindIndex(p => p.Id == id);
            if(index == -1)
            {
                return "Cannot find product index to update, enter the correct id to update";
            }
            prod.RemoveAt(index);
            prod.Add(value);
            return "Product Updated Successfully";
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            int index = prod.FindIndex(p => p.Id == id);
            if (index == -1)
            {
                return "Cannot find product index to delete, enter the correct id to delete";
            }
            prod.RemoveAt(index);
            return "Product deleted successfully";
        }
    }
}
