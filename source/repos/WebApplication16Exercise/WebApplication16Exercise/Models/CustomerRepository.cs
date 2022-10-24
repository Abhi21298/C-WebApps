using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebApplication16Exercise.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        List<Customer> l1 = new List<Customer>();
        private int _nextID = 1;
        public CustomerRepository()
        {
            Add(new Customer { FirstName = "Abhi", LastName = "rao", ID = 1, balance = 2000.0 });
            Add(new Customer { FirstName = "Shek", LastName = "P", ID = 2, balance = 6500.0 });
            Add(new Customer { FirstName = "Adi", LastName = "avi", ID = 3, balance = 8950.0 });
        }
        public Customer Get(int id)
        {
            return l1.Find(p => p.ID == id);
        }
        public Customer Add(Customer item)
        {
            if(item == null)
            {
                throw new NotImplementedException();
            }
            item.ID = _nextID++;
            l1.Add(item);
            return item;

        }
        public IEnumerable<Customer> GetAll()
        {
            return l1;
        }

        public void Remove(int id) 
        {
            l1.RemoveAll(p => p.ID == id);
        }

        public bool Update(Customer item)
        {
            if(item == null)
            {
                throw new NotImplementedException();
            }
            int index = l1.FindIndex(p => p.ID == item.ID);
            if (index == -1)
                return false;
            l1.RemoveAt(index);
            l1.Add(item);
            return true;
        }
            
        
    }
}
