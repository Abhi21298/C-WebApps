using System;

namespace ConsoleApp9
{
   
        public interface ITransaction
        {
            void displayTransaction();

            double getSalary();
        }


    public class Transaction : ITransaction
    {
        private string id;
        private string transDate;
        private double amount;

        public Transaction()
        {
            id = " ";
            transDate = " ";
            amount = 0.0;
        }

        public Transaction(string c, string d, double a)
        {
            id = c;
            transDate = d;
            amount = a;
        }

        public double getSalary()
        {
            return amount;
        }

        public void displayTransaction()
        {
            Console.WriteLine("Transaction : {0}", id);
            Console.WriteLine("Date : {0}", transDate);
            Console.WriteLine("Amount : {0}", getSalary());
        }


        //Console.WriteLine("Hello World!");
    }
        class Program
    {
        static void Main()
        {
            Transaction t1 = new Transaction("001", "3rd Jan", 60.00);
            Transaction t2 = new Transaction("002", "4th Jan", 160.00);

            t1.displayTransaction();
            t2.displayTransaction();

        }
    }


 }

