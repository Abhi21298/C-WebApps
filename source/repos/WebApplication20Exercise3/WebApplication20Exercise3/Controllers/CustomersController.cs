using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication20Exercise3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication20Exercise3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public readonly AccountRepository repository = new AccountRepository();
        // GET: api/<CustomersController>
        [HttpGet]
        public IEnumerable<Account> GetAccounts()
        {
            return repository.GetAll();
            //return new string[] { "value1", "value2" };
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public Account GetCustomer(int id)
        {
            Account item = repository.Get(id);
            if(item == null)
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);
            return item;
            //return "value";
        }

        // POST api/<CustomersController>
        [HttpPost]
        public string PostCustomer(Account item)
        {
            item = repository.Add(item);
            return "Added successfully";
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public string PutCustomer(int id, Account item)
        {
            item.ID = id;
            if (!repository.Update(item))
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);
            return "Updated Successfully";
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public string DeleteCustomer(int id)
        {
            Account item = repository.Get(id);
            if (item == null)
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);
            repository.Remove(id);
            return "Deleted Successfully";
        }
    }
}
