using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication20Exercise2.Models
{
    public interface IAccount
    {
        void Getdetails(string AccountNumber, string AccountHolder, double balance);

        
    }

    public interface IAccountScoped : IAccount { }

    public interface IAccountTransient : IAccount { }

    public interface IAccountSingleton : IAccount { }
}
