using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication29.Models;
namespace WebApplication29.Controllers
{
    public class ValuesController : ApiController
    {
        static List<Account> Ac = new List<Account>()
        {
            new Account{ AccountID = 1, Name = "Ram", Type = "Savings", Balance = 2000.0},
            new Account{ AccountID = 2, Name = "Raj", Type = "Savings", Balance = 1200.0},
            new Account{ AccountID = 3, Name = "Ramesh", Type = "Savings", Balance = 1700.0},
            new Account{ AccountID = 4, Name = "AbhiRam", Type = "Savings", Balance = 1850.0}
        };
        // GET api/values
        public IEnumerable<Account> Get()
        {
            return Ac;
        }

        // GET api/values/5
        public Account Get(int id)
        {
            return Ac.Find(p => p.AccountID == id);
        }

        // POST api/values
        public string Post([FromBody] Account value)
        {
            if (value != null)
            {
                Ac.Add(value);
               
            }
            return "added successfully";   
        }

        // PUT api/values/5
        public string Put(int id, [FromBody] Account value)
        {
            int index = Ac.FindIndex(p => p.AccountID == id);
            if (index == -1)
                return "cannot update";
            Ac.RemoveAt(index);
            Ac.Add(value);
            return "updated successfully";
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            int index = Ac.FindIndex(p => p.AccountID == id);
            if (index == -1)
                return "cannot delete";
            Ac.RemoveAt(id);
            return "deleted successfully";
        }
    }
}
