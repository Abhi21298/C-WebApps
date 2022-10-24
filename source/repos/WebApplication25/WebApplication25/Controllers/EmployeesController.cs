using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication25.Models;
//using System.Web.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication25.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        static readonly EmployeeRepository repository = new EmployeeRepository();
        // GET: api/<EmployeesController>
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return repository.GetAll();
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public Employee GetEmployee(int id)
        {
            Employee item = repository.Get(id);
            if (item == null)
            {
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return item;
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public string AddEmployee(Employee item)
        {
            item = repository.Add(item);
            return "Added successfully";

        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void UpdateEmployee(int id, Employee value)
        {
            value.EmpID = id;
            if (!repository.Update(value))
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void DeleteEmployee(int id)
        {
            Employee item = repository.Get(id);
            if (item == null)
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);
            repository.Remove(id);
        }
    }
}
