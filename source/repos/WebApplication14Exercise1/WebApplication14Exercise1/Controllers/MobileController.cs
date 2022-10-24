using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication14Exercise1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileController : ControllerBase
    {
        static List<string> phones = new List<string>() 
            {
             "Samsung","iPhone", "Oneplus"
            };
        // GET: api/<MobileController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return phones;
            //return new string[] { "value1", "value2" };
        }

        // GET api/<MobileController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return phones[id];
        }

        // POST api/<MobileController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            phones.Add(value);
        }

        // PUT api/<MobileController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            phones[id] = value;
        }

        // DELETE api/<MobileController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            phones.RemoveAt(id);
        }
    }
}
