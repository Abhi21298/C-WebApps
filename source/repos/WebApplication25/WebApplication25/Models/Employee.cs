using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication25.Models
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpDept { get; set; }
        public double Salary { get; set; }
        public DateTime? DOJ { get; set; }
    }
}
