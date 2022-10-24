using miniproj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniproj.ViewModels
{
    public class ProductModel
    {
        public List<Product> _products { get; set; }
        public List<Product> findAll()
        {
            _products=new List<Product> { new Product() { Id = "1", Name = "Dhoni", Photo = "dhoni.jpg", Price = 20.0 } };
            _products = new List<Product> { new Product() { Id = "2", Name = "Kohli", Photo = "kohli.jpg", Price = 20.0 } };
            _products = new List<Product> { new Product() { Id = "3", Name = "Rohit", Photo = "rohit.jpg", Price = 20.0 } };
            _products = new List<Product> { new Product() { Id = "4", Name = "KL Rahul", Photo = "rahul.jpg", Price = 20.0 } };
            return _products;
        }
        public Product find(string id)
        {
            List<Product> products = findAll();
            var prod = products.Where(a => a.Id == id).FirstOrDefault();
            return prod;
        }
    }
}
