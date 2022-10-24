using System;
using System.Collections.Generic;
namespace ConsoleApp11Exercise
{
    abstract class Employee
    {
        private string type;
        private double HRA;
        private double MI;
        private double basicSal;
        private double HI;
        protected double finalSal;

        public Employee()
        {
            type = " ";
            
            basicSal = 25000;
            HRA = 0.15*basicSal;
            MI = 0.1*basicSal;
            HI = 0.1*basicSal;
            finalSal = 0.0;
        }
        public void GetSalary(string P)
        {
            //Console.WriteLine("Enter the type of employee:(P - Permanent Employee ");
            type = P;
            //Console.WriteLine("Enter the basic Salary: ");
            //finalSal = Convert.ToDouble(Console.ReadLine());
            if (type == "P" || type == "p")
            {
                finalSal = basicSal + HI + MI + HRA;
            }
            else
            {
                finalSal = basicSal;
            }
        }

        public abstract void GetDetails();


        public abstract void TechStack();
    }

    class PermanentEmployee : Employee
    {
        private string Name;
        private string EmpID;
        private string Designation;
        private string Techlevel; 
        public override void GetDetails()
        {
            Console.WriteLine("enter the name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your id: ");
            EmpID = Console.ReadLine();
            Console.WriteLine("Enter your designation: ");
            Designation = Console.ReadLine();
        }

        public override void TechStack()
        {
            Console.WriteLine("Enter your tech stack level");
            Techlevel = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Employee ID " + EmpID);
            Console.WriteLine("Designation " + Designation);
            Console.WriteLine("TechStack" + Techlevel);
            Console.WriteLine("Salary: " + finalSal);
        }
    }

    class ContractEmployee : Employee
    {
        private string Name;
        private string EmpID;
        private string Designation;
        private string TermofHire;
        private string Techlevel;
        public override void GetDetails()
        {
            Console.WriteLine("enter the name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your id: " );
            EmpID = Console.ReadLine();
            Console.WriteLine("Enter your designation: ");
            Designation = Console.ReadLine();
            Console.WriteLine("Enter your Term of Hire in years");
            TermofHire = Console.ReadLine();
        }

        public override void TechStack()
        {
            Console.WriteLine("Enter your tech stack level");
            Techlevel = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Employee ID " + EmpID);
            Console.WriteLine("Designation " + Designation);
            Console.WriteLine("TechStack" + Techlevel);
            Console.WriteLine("Term of Hire : " + TermofHire);
            Console.WriteLine("Salary: " + finalSal);
        }
    }

    class ListofEmp
    {
        public List<PermanentEmployee> PE = new List<PermanentEmployee>();
        public List<ContractEmployee> CE = new List<ContractEmployee>();

        public void AddEmp(PermanentEmployee pe)
        {
            PE.Add(pe);
        }

        public void AddEmp(ContractEmployee ce)
        {
            CE.Add(ce);
        }
        
        public void disp()
        {
            Console.WriteLine("List of Permanent Employees-----");
            foreach (var B in PE)
                B.Display();
            Console.WriteLine("List of Contract Employees------");
            foreach (var B in CE)
                B.Display();
            
        }
        
    }

    class Subtract
    {
        public int number;

        public Subtract()
        {
            number = 0;
        }
        public Subtract(int a)
        {
            number = a;
        }

        public static Subtract operator -(Subtract s1,Subtract s2)
        {
            Subtract s3 = new Subtract(0);
            s3.number = s1.number - s2.number;
            return s3;
        }
    }
    class Program
    {   
        // Using <T> for functions
        public static T Add<T>(ref T a,ref T b)
        {
            dynamic temp = a;
            temp += b;
            return temp;
            //Console.WriteLine(temp);
        }
        
        static void Main(string[] args)
        {
            //PermanentEmployee p1 = new PermanentEmployee();
            //p1.GetSalary("P");
            //p1.GetDetails();
            //p1.TechStack();

            //ContractEmployee p = new ContractEmployee();
            //p.GetSalary("C");
            //p.GetDetails();
            //p.TechStack();

            //p1.Display();
            //p.Display();

            // ABSTRACT CLASSES EXERCISE

            //string choice = "Y";
            //string type;
            //ListofEmp newlist = new ListofEmp();
            //do
            //{
            //    Console.WriteLine("Enter the type of employee type details you want to add");
            //    type = Console.ReadLine();
            //    if (type == "P")
            //    {
            //        PermanentEmployee p1 = new PermanentEmployee();
            //        p1.GetSalary("P");
            //        p1.GetDetails();
            //        p1.TechStack();
            //        newlist.AddEmp(p1);
            //    }
            //    else
            //    {
            //        ContractEmployee p = new ContractEmployee();
            //        p.GetSalary("C");
            //        p.GetDetails();
            //        p.TechStack();
            //        newlist.AddEmp(p);
            //    }
            //    Console.WriteLine("Do you want to add more employees? ");
            //    choice = Console.ReadLine();
            //} while (choice == "Y");

            //Console.WriteLine("The list of both kind of employees are: ");
            //newlist.disp();

            // OPERATOR OVERLOADING EXERCISE
            //Subtract s1 = new Subtract(20);
            //Subtract s2 = new Subtract(40);
            //Subtract s3 = s1 - s2;
            //Console.Write(s3.number);

            //Using <T> for Functions
            int a=10, b=20;
            double c=10.0, d=20.0;

            Console.WriteLine(Add(ref a, ref b));
            Console.WriteLine(Add(ref c, ref d));



            //Console.WriteLine("Hello World!");
        }
    }
}
