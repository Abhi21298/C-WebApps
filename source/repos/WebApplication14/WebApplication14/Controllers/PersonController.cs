using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.Model;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication14.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        List<Person> people = new List<Person>() {

            new Person { PersonID = 7687, FirstName = "Abdullah", LastName = "Khan", Location = "IN" },
            new Person { PersonID = 7688, FirstName = "Mark", LastName = "Joe", Location = "IN" },
            new Person { PersonID = 7689, FirstName = "Mike", LastName = "Doe", Location = "US" }
                };
        // GET: api/<PersonController>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            //var rng = new Random();


            //return people.ToArray();
            //return new string[] { "value1", "value2" };
            return people;
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return people.Find(p => p.PersonID == id);
            //return "value";
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] Person value)
        {
            people.Add(value);
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Person value)
        {
            int index = people.FindIndex(p => p.PersonID == id);
            if (index == -1)
                return "Cant find produc to update";
            people.RemoveAt(index);
            people.Add(value);
            return "Added";

        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
