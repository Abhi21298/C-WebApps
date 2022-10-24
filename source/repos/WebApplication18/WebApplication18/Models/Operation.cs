using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication18.Models
{
    public class Operation : IOperationScoped ,IOperationTransient,IOperationSingleton
    {
        public Operation()
        {
            OperationID = Guid.NewGuid().ToString();
        }
        public string OperationID { get;  }
    }
}
