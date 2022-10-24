using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication25.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> l1 = new List<Employee>();
        int _nextid = 1;
        public EmployeeRepository()
        {
            Add(new Employee { EmpID = 1, EmpName = "Abhi", EmpDept = "Azure", Salary = 5000.0, DOJ = DateTime.Parse("2021-01-13")});
            Add(new Employee { EmpID = 2, EmpName = "Ram", EmpDept = "Azure", Salary = 4000.0, DOJ = DateTime.Parse("2021-01-11") });
            Add(new Employee { EmpID = 3, EmpName = "Rakesh", EmpDept = "Azure", Salary = 4000.0, DOJ = DateTime.Parse("2021-01-11") });
        }
        public IEnumerable<Employee> GetAll()
        {
            return l1;
        }
        public Employee Get(int id)
        {
            return l1.Find(p => p.EmpID == id);
        }
        public Employee Add(Employee item)
        {
            if (item == null)
            {
                throw new NotImplementedException();
            }
            item.EmpID = _nextid++;
            l1.Add(item);
            return item;
        }
        public void Remove(int id)
        {
            l1.RemoveAll(p => p.EmpID == id);
        }
        public bool Update(Employee item)
        {
            if (item == null)
            {
                throw new NotImplementedException();
            }
            int index = l1.FindIndex(p => p.EmpID == item.EmpID);
            if (index == -1)
                return false;
            l1.RemoveAt(index);
            l1.Add(item);
            return true;
        }
    }
}
