using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Product product1 = new Product() { ProductID = 1, ProductName = "Tea", ManufacturerName = "Tata", Expirydate = "Jan 2022", Price = 120.32 };
            //Product product2 = new Product() { ProductID = 2, ProductName = "coffee", ManufacturerName = "Nescafe", Expirydate = "Nov 2022", Price = 100.32 };
            Store SevenEleven = new Store();
            char ch;
            Console.WriteLine("Do you want to add a product?");
            ch = Convert.ToChar(Console.ReadLine());
            while (ch == 'Y' || ch == 'y')
            {
                Product prod1 = new Product();
                prod1.ProductID = Convert.ToInt32(Console.ReadLine());
                prod1.ProductName = Console.ReadLine();
                prod1.ManufacturerName = Console.ReadLine();
                prod1.Expirydate = Console.ReadLine();
                prod1.Price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                SevenEleven.AddProducts(prod1);
                Console.WriteLine("Do you want to add more products?(Y/N)");
                ch = Convert.ToChar(Console.ReadLine());

            }
           
            
            

            SevenEleven.ViewProducts();
        }
    }
}
