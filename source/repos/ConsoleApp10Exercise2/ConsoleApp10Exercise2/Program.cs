using System;

namespace ConsoleApp10Exercise2
{
    public class AprrovalEx: Exception
    {
        public AprrovalEx(string message) : base(message)
        {

        }
    }

    public class LoanApproval
    {
        private double loanamt;
        private double balance;
        public LoanApproval(double a, double b)
        {
            loanamt = a;
            balance = b;
        }

        public void LoanCheck()
        {
            if(loanamt/balance >=4)
            {
                throw (new AprrovalEx("Loan approval is rejected"));
            }
            else
            {
                Console.WriteLine("Loan is approved");
            }
        }
    }
    public interface AmazonPay
    {
        void MakePaymentUsingNumber();
        void IsPaymentSuccessful();
        void OrderDetails();
    }

    public class ICICIBank : AmazonPay
    {
        private int k;
        private string ch;
        private string CardHolderName;
        private string CardNumber;
        private string ExpiryDate;
        private string CVV;
        private double balance;
        private double amount;
        private DateTime datetime;
        //private 
        public ICICIBank()
        {
            
            k = 0;
            ch = " ";
            CardHolderName = " ";
            CardNumber = " ";
            ExpiryDate = " ";
            CVV = " ";
            amount = 0.0;
            balance = 400000.0;
        }

        public ICICIBank(double a)
        {
            k = 0;
            ch = " ";
            CardHolderName = " ";
            CardNumber = " ";
            ExpiryDate = " ";
            CVV = " ";
            amount = a;
            balance = 400000.0;
        }

        public void MakePaymentUsingNumber()
        {
            Console.WriteLine("---------Payment Gateway----------");
            Console.WriteLine("Do you want to proceed with the payment");
            ch = Console.ReadLine();
            if(ch == "y" || ch == "Y")
            {
                Console.WriteLine("Enter the Cardholder details: ");
                CardHolderName = Console.ReadLine();
                Console.WriteLine("Enter the 16 digit card number: ");
                CardNumber = Console.ReadLine();
                Console.WriteLine("Enter the Expiry Date: ");
                ExpiryDate = Console.ReadLine();
                Console.WriteLine("Enter the CVV");
                CVV = Console.ReadLine();
                Console.WriteLine("The amount to be paid for purchase" + amount);
                datetime = DateTime.Now;

            }
        }

        public void IsPaymentSuccessful()
        {

            if (balance - amount <  0)
                Console.WriteLine("transaction failed");
            else
            {
                datetime = DateTime.Now;
                k = 1;
                balance = balance - amount;
                Console.WriteLine("Transaction successful, order confirmed");
                
            }

        }

        public void OrderDetails()
        {
            Console.WriteLine("Here are the Cardholder details: " + CardHolderName);
            Console.WriteLine("Time of transaction: " + datetime);
            if(k==1)
            {
                Console.WriteLine("Amount deducted: " + amount);
                Console.WriteLine("Current Balance of account:" + balance);
            }
            else
            {
                Console.WriteLine("Please try and pay again");
            }
            k = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ICICIBank pay = new ICICIBank(3500.0);
            //pay.MakePaymentUsingNumber();
            //pay.IsPaymentSuccessful();
            //pay.OrderDetails();
            //Console.WriteLine("Hello World!");

            LoanApproval li = new LoanApproval(4000000.0, 200000.0);
            try
            {
                li.LoanCheck();
            }
            catch(AprrovalEx e)
            {
                Console.WriteLine("Exception caught" + e);
            }
        }
    }
}
