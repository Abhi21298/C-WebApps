using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using static WebApplication20Exercise2.Data.IAccount;

namespace WebApplication20Exercise2.Models
{
    public class Account : IAccountScoped,IAccountTransient,IAccountSingleton
    {
        public string B { get; set; }
        public Account()
        {
           B = Guid.NewGuid().ToString();
        }
        public void Getdetails(string AccountNumber, string AccountHolder, double balance)
        {
            Console.WriteLine("The AccountHolder is " + AccountHolder);
            Console.WriteLine("THe Account number is " + AccountNumber);
            Console.WriteLine("the account balance is " + balance);
            Console.WriteLine(B);
            
        }
    }
}
