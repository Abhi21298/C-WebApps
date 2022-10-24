using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication16.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApplication16.Models;
//using System.Web.Http;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication16.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        static readonly IProductRepository repository = new ProductRepository();
        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return repository.GetAll();
            //return new string[] { "value1", "value2" };
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
            Product item = repository.Get(id);
            if(item == null)
            {
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return item;
            //return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public string PostProduct(Product item)
        {
             item = repository.Add(item);
            return "Added successfully";
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void PutProduct(int id,Product product)
        {
            product.ID = id;
            if(! repository.Update(product))
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);

        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Product item = repository.Get(id);
            if(item == null)
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);
            repository.Remove(id);


        }
    }
}
