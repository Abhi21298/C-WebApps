using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication20Exercise3.Models
{
    public class AccountRepository : IAccountRepository
    {
        List<Account> a = new List<Account>();
        int _nextid = 3;
        public AccountRepository()
        {
            Add(new Account {  Name = "Abhijeet", AccountNumber = "129223", AccountBalance = 200.0 });
            Add(new Account {  Name = "Shek", AccountNumber = "129289", AccountBalance = 9000.0 });
            Add(new Account {  Name = "Dj", AccountNumber = "129562", AccountBalance = 2100.0 });
            
        }
        public IEnumerable<Account> GetAll()
        {
            return a;
        }
        public Account Get(int id)
        {
            return a.Find(p => p.ID == id);
        }
        public Account Add(Account item)
        {
            if(item == null)
            {
                throw new NotImplementedException();
            }
            item.ID = _nextid++;
            a.Add(item);
            return item;

        }
        public void Remove(int id)
        {
            a.RemoveAll(p => p.ID == id);
        }
        public bool Update(Account item)
        {
            if (item == null)
            {
                throw new NotImplementedException();
            }
            int index = a.FindIndex(p => p.ID == item.ID);
            if (index == -1)
                return false;
            a.RemoveAt(index);
            a.Add(item);
            return true;
        }
    }
}
