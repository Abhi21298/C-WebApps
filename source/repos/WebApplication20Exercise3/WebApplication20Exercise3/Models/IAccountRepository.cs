using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication20Exercise3.Models
{
    interface IAccountRepository
    {
        IEnumerable<Account> GetAll();
        Account Get(int id);
        Account Add(Account item);
        void Remove(int id);
        bool Update(Account item);
    }
}
