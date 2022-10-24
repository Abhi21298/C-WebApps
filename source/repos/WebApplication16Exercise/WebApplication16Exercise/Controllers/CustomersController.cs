using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication16Exercise.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication16Exercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        static readonly ICustomerRepository repository = new CustomerRepository();
        // GET: api/<CustomersController>
        [HttpGet]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return repository.GetAll();
            //return new string[] { "value1", "value2" };
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public Customer GetCustomer(int id)
        {
            Customer item = repository.Get(id);
            if (item == null)
            {
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return item;
            //return "value";
        }

        // POST api/<CustomersController>
        [HttpPost]
        public string PostCustomer(Customer value)
        {
            value = repository.Add(value);
            return "Added successfully";
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void PutCustomer(int id,Customer value)
        {
            value.ID = id;
            if (!repository.Update(value))
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void DeleteCustomer(int id)
        {
            Customer item = repository.Get(id);
            if (item == null)
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);
            repository.Remove(id);
        }
    }
}
