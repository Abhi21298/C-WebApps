using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication20Exercise1.Models;
using WebApplication20Exercise1.Data;
namespace WebApplication20Exercise1.Data
{
    public static class DBInitializer
    {
        public static void Initialize(OrderContext context)
        {
            context.Database.EnsureCreated();

            if(context.Orders.Any())
            {
                return;   // DB has been seeded
            }

            var orders = new Order[]
            {
                new Order{ OrderID = 101,CustomerName = "Rajesh",OrderTime = DateTime.Parse("2005-09-01")},
                new Order{ OrderID = 102,CustomerName = "Abhi",OrderTime = DateTime.Parse("2005-09-04")},
                new Order{ OrderID = 103,CustomerName = "Rakesh",OrderTime = DateTime.Parse("2005-09-05")},
                new Order{ OrderID = 104,CustomerName = "Chichu",OrderTime = DateTime.Parse("2005-09-02")},
                new Order{ OrderID = 105,CustomerName = "Siri",OrderTime = DateTime.Parse("2005-08-07")},
                new Order{ OrderID = 106,CustomerName = "Raju",OrderTime = DateTime.Parse("2015-08-20")},
                new Order{ OrderID = 107,CustomerName = "Siddy",OrderTime = DateTime.Parse("2012-08-10")}

            };
            foreach (Order s in orders)
            {
                context.Orders.Add(s);
            }
            context.SaveChanges();

            var products = new Product[]
            {
                new Product{ ProductID = 1 , ProductName = "tea", Cost = 100.0},
                new Product{ ProductID = 2 , ProductName = "Coffee", Cost = 120.0},
                new Product{ ProductID = 3 , ProductName = "Sugar", Cost = 300.0},
                new Product{ ProductID = 4 , ProductName = "Soap", Cost = 90.0},
                new Product{ ProductID = 5 , ProductName = "Shampoo", Cost = 175.0}
            };

            foreach(Product p in products )
            {
                context.Products.Add(p);
            }
            context.SaveChanges();
        }

    }
}
