using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication18Exercise.Models
{
    public interface IEmployee
    {
        void GetName(string name);
    }

    public interface IEmployeeSingleton : IEmployee { }
    public interface IEmployeeTransient : IEmployee { }
    public interface IEmployeeScoped : IEmployee { }

}
