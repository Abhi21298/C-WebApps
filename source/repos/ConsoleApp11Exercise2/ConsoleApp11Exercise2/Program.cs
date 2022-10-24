using System;

namespace ConsoleApp11Exercise2
{
    abstract class Banking
    {
        protected double balance;
        public abstract void eligibleforLoan(double a);


        public void GetBalance()
        {
            balance = 250000.0;
            Console.WriteLine("the account balance is " + balance);
        }

        public abstract void getIncometaxReport();
    }

    class CorporateBanking : Banking
    {
        private double loanamount = 0.0;
        private double salary = 0.0;
        public override void eligibleforLoan(double a)
        {
            Console.WriteLine("Enter your salary per month amount ");
            salary = Convert.ToDouble(Console.ReadLine());
            loanamount = a;
            if (loanamount > 15 * (balance + salary))
                Console.WriteLine("Loan is not approved, Amount is too high");
            else
                Console.WriteLine("Congrats your loan is approved");
            //throw new NotImplementedException();
        }

        public override void getIncometaxReport()
        {
            Console.WriteLine("Your income tax report is: ");
            Console.WriteLine(0.3 * salary + "is the amount deducted from your salary monthly");
            //throw new NotImplementedException();
        }
    }

    class GeneralBanking : Banking
    {
        private double loanamount = 0.0;
        public override void eligibleforLoan(double a)
        {
            loanamount = a;
            if (loanamount > (5 * balance))
                Console.WriteLine("Your loan is not approved");
            else
                Console.WriteLine("Your loan is approved");
        }

        public override void getIncometaxReport()
        {
            Console.WriteLine("You are not charged with income tax as this is not a corporate account");
        }
    }

    class Employee
    {
        public double salary = 0.0;

        public Employee(double a)
        {
            salary = a;
        }

        public static double operator >(Employee e1, Employee e2)
        {
            if (e1.salary > e2.salary)
            { 
                Console.WriteLine("The first employee's salary is greater than the second by" + (e1.salary - e2.salary)); 
                return e1.salary; 
            }
            else
            { 
                Console.WriteLine("The second employee's salary is greater than the first by" + (e2.salary - e1.salary));
                return e2.salary; 
            }
        }

        public static double operator <(Employee e1, Employee e2)
        {
            if (e1.salary < e2.salary)
            { 
                Console.WriteLine("The second employee's salary is greater than the first by" + (e2.salary - e1.salary)); 
                return e2.salary; 
            }
            else
            { 
                Console.WriteLine("The first employee's salary is greater than the second by" + (e1.salary - e2.salary)); 
                return e1.salary; 
            }
        }
    }
    class Program
    {   
        public static void CheckType<T>(ref T a)
        {
            dynamic D = a;
            Console.WriteLine("The type of " + D + " is  ");
            Console.WriteLine(D.GetType().ToString());
        }
        static void Main(string[] args)
        {
            // ABSTRACT CLASSES
            CorporateBanking C = new CorporateBanking();
            C.GetBalance();
            C.eligibleforLoan(1400000.0);
            C.getIncometaxReport();

            GeneralBanking G = new GeneralBanking();
            G.GetBalance();
            G.eligibleforLoan(1400000.0);
            G.getIncometaxReport();


            //OPERATOR OVERLOADING
            Employee e1 = new Employee(25000.0);
            Employee e2 = new Employee(40000.0);
            double highestsal = e1 > e2;
            Console.WriteLine("The bigger salary is " + highestsal);

            // USING <T> IN FUNCTIONS
            char a = 'F';
            int b = 0;
            float c = 0;
            CheckType(ref a);
            CheckType(ref b);
            CheckType(ref c);
            //Console.WriteLine("Hello World!");
        }
    }
}
