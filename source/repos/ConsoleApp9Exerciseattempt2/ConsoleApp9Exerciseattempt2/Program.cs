using System;

namespace ConsoleApp9Exerciseattempt2
{
    public interface Ipayment
    {
        void PayforOrder();

        void CheckPaymentSuccess();
        void ShowPaymentDetails();

    }

    public class TataPay : Ipayment
    {
        private string username;
        private string pwd;
        private int NoOfitems;
        private string choice;
        private int OrderID;
        private DateTime dateTime;
        private double amount;
        public TataPay()
        {
            username = " ";
            pwd = " ";
            NoOfitems = 0;
            choice = " ";
            OrderID = 0;
            //Time = " ";
            amount = 0.0;
            dateTime = DateTime.Now;
        }

        public TataPay(string a, string b, int c,int d,double e)
        {
            username = a;
            pwd = b;
            NoOfitems = d;
            //choice = b;
            OrderID = c;
            //Time = d;
            amount = e;
            dateTime = DateTime.Now;
        }
        public void login()
        {
            Console.WriteLine("welcome to Amazon " + username);
            Console.WriteLine("The number of items in kart are: " + NoOfitems);
            Console.WriteLine(" Redirecting to payment portal");
        }
        public void PayforOrder()
        {
            Console.WriteLine("Click to pay(Y/N) the amount of " + amount + " Order ID " + OrderID );
            choice = Console.ReadLine();

        }

        public void CheckPaymentSuccess()
        {
            if (choice == "Y" || choice == "y")
            {
                Console.WriteLine("Congrats your payment is successful");
            }
            else
            {
                Console.WriteLine("Payment failed");
            }
        }

        public void ShowPaymentDetails()
        {
            Console.WriteLine("the payment details are : ");
            Console.WriteLine(" Username " + username + " at Time: " + dateTime);
            Console.WriteLine("Order ID: " + OrderID + "No. of Items: ");
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Payment Status : ");
            if (choice == "y" || choice == "Y")
            {
                Console.Write(" Success");
            }
            else
                Console.Write(" Failure");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TataPay t1 = new TataPay("abhi21298", "*******", 1, 3, 200.00);

            t1.login();
            t1.PayforOrder();
            t1.CheckPaymentSuccess();
            t1.ShowPaymentDetails();
            //Console.WriteLine("Hello World!");
        }
    }
}
