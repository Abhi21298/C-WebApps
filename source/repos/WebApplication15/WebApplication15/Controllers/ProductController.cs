using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication15.Models;
using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System.Web.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication15.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        static readonly IProductRepository repository = new ProductRepository();


        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            
            return repository.GetAll();
            //return new string[] { "value1", "value2" };
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
            Product item = repository.Get(id);
            if(item == null)
            {
                //throw new System.Web.Http.HttpResponse
            }
            return item;
            //return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
