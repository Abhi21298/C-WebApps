using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication18Exercise.Models;
namespace WebApplication18Exercise.Models
{
    public class Employee : IEmployeeScoped,IEmployeeSingleton,IEmployeeTransient
    {
        public string B;
        public Employee()
        {
          B = Guid.NewGuid().ToString();
        }
        public void GetName(string name)
        {
            Console.WriteLine("The name of the employee is " + name);
            Console.WriteLine(B);
        }
    }
}
