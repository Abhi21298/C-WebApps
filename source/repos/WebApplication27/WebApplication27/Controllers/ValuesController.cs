using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication27.Controllers
{
    public class ValuesController : ApiController
    {
        // public string[] ab = new string[10];
        List<string> val = new List<string>()
        {
            "value1", "value2" , "value3" , "value4", "value5" , "value6" , "value7"
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return val;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return val[(id - 1)];
        }

        // POST api/values
        public string Post([FromBody] string value)
        {
            val.Add(value);
            return "Add success";
        }

        // PUT api/values/5
        public IEnumerable<string> Put(int id, [FromBody] string value)
        {
            val[id] = value;
            return val;
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            val.RemoveAt(id);
            return "Removed Successfully";
        }
    }
}
