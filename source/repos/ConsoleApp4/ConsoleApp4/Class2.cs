using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Store
    {
        List<Product> prods;

        public Store()
        {
            prods = new List<Product>();
        }

        public void AddProducts(Product product)
        {
            prods.Add(product);
            Console.WriteLine("Prodcut added successfully");
        }

        public void ViewProducts()
        {
            foreach(var B in prods)
            {
                Console.WriteLine("Product ID is {0}",B.ProductID);
                Console.WriteLine("Product Name is {0}", B.ProductName);
                Console.WriteLine("Product Manufacturer is {0}", B.ManufacturerName);
                Console.WriteLine("Product Expiry Date is {0}", B.Expirydate);
                Console.WriteLine("Product Price is {0}", B.Price);
                Console.WriteLine();
            }
        }
    }
}
