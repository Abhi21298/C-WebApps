using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication16.Models;
namespace WebApplication16.Models
{
    public class ProductRepository : IProductRepository
    {
        List<Product> products = new List<Product>();
        private int _nextId = 1;
        public ProductRepository()
        {
            Add(new Product { Name = "Tomato Soup", Category = "Groceries", Price = 1.39M });
            Add(new Product { Name = "Yo-yo", Category = "Toys", Price = 3.75M });
            Add(new Product { Name = "Hammer", Category = "Hardware", Price = 16.99M });
        }
        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new NotImplementedException();
            }
            item.ID = _nextId++;
            products.Add(item);
            return item;
        }

        public Product Get(int id)
        {
            return products.Find(p => p.ID == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public void Remove(int id)
        {
            products.RemoveAll(p => p.ID == id);
            //throw new NotImplementedException();
        }

        public bool Update(Product item)
        {
            if (item == null)
            {
                throw new NotImplementedException();
            }
            int index = products.FindIndex(p => p.ID == item.ID);
            if (index == -1)
                return false;
            products.RemoveAt(index);
            products.Add(item);
            return true;

        }
    }
}
