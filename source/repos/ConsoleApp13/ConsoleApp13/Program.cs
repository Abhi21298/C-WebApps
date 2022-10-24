using System;
using System.Collections.Generic;

namespace ConsoleApp13
{   
    // ABSTRACT CLASS HOSPITAL

    public abstract class Hospital
    {
        private string name;
        protected int age;
        private string ailments;
        public void GEtPAtientDetails()
        {
            Console.WriteLine("Enter the Patient details");
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age: ");
            age = Convert.ToInt32(Console.ReadLine());

        }
        public abstract void ISeligibleforhealthinsurance();
        public void  PreviousAilments()
        {
            Console.WriteLine("Enter medical history: ");
            ailments = Console.ReadLine();
        }
    }

    public class CitizenBelow55 : Hospital
    {
       public override void ISeligibleforhealthinsurance()
        {
            Console.WriteLine("Yes, eligible for health insurance");
        }


    }

    public class SeniorCitizen : Hospital
    {
        public override void ISeligibleforhealthinsurance()
        {
            Console.WriteLine("Not eligible for health insurance");
        }
    }

    // INTERFACE

    public interface Student
    {
        void GetStudentDetails();

        void GetStudentMarks();

        void GetStudentSubjects();


    } 
    
    class SSK : Student
    {
        private string StudName;
        private int StudID;
        private int[] marks = new int[4];
        private string[] subjects = new string[4];

        public void GetStudentDetails()
        {
            Console.WriteLine("Enter the name");
            StudName = Console.ReadLine();
            Console.WriteLine("Enter the Stduent ID");
            StudID = Convert.ToInt32(Console.ReadLine());

        }

        public void GetStudentSubjects()
        {
            Console.WriteLine("Enter the 4 subjects of the student");
            for (int i = 0; i < 4; i++)
            {
                subjects[i]= (Console.ReadLine());
            }
        }

        public void GetStudentMarks()
        {
            Console.WriteLine("Enter the 4 marks of the student");
            for (int i = 0; i < 4; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void display()
        {
            Console.WriteLine("the name is" + StudName);
            Console.WriteLine("THe ID is " + StudID);
            Console.WriteLine("THe subjects and marks are");
            for(int i=0;i<4;i++)
            {
                Console.WriteLine(subjects[i] + " :" + marks[i]);
            }
        }
    }
    
    // EMPLOYEE AND DEPARTMENT
    class Department
    {
        protected string DeptName;
        protected int DeptCode;

        public Department()
        {
            DeptName = " ";
            DeptCode = 0;
        }
        public virtual void GetDetails()
        {
            Console.WriteLine("Enter the Dept Details");
            DeptName = Console.ReadLine();
            Console.WriteLine("enter the Dept Code");
            DeptCode = Convert.ToInt32(Console.ReadLine()); 

            
        }

        public void Disp()
        {
            Console.WriteLine(" the Dept name : " + DeptName);
            Console.WriteLine(" the Dept Code : " + DeptCode);
        }
    }
    class Employee : Department
    {
        private string EmpName;
        private int EmpID;

        public override void GetDetails()
        {
            Console.WriteLine("Enter the Dept name");
            DeptName = Console.ReadLine();
            Console.WriteLine("enter the Dept Code");
            DeptCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Emp name");
            EmpName = Console.ReadLine();
            Console.WriteLine("enter the Emp Code");
            EmpID = Convert.ToInt32(Console.ReadLine());
        }

        public new void Disp()
        {
            Console.WriteLine(" the Dept name : " + DeptName);
            Console.WriteLine(" the Dept Code : " + DeptCode);
            Console.WriteLine("THe employee name " + EmpName);
            Console.WriteLine("The employee Code " + EmpID);
        }
    }
    // ADD ACCOUNT CLASS
    public class Account
    {
        private string AccID;
        private string Name;
        private double balance;

        public void GetDetails()
        {
            Console.WriteLine("enter the acc name ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Acc ID ");
            AccID = Console.ReadLine();
            Console.WriteLine("Enter the balance ");
            balance = Convert.ToDouble(Console.ReadLine());
        }

        public void Disp()
        {
            Console.WriteLine(" Name : " + Name);
            Console.WriteLine("AccID " + AccID);
            Console.WriteLine("Balance " + balance);
        }
    }

    class ListofEmp
    {
        private List<Account> LA = new List<Account>();

       public void AddEmp(Account e)
        {
            LA.Add(e);
        }

       public void Display()
        {
            foreach (var B in LA)
                B.Disp();
        }
    }

    class Program
    {   // METHOD OVERLOADING

        public static int ADD(int a,int b)
        {
            return a + b;
        }

        public static int ADD(int a, int b,int c)
        {
            return a + b + c;
        }

        public static int ADD(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        public static int SUB(int a, int b)
        {
            return a - b;
        }

        public static int SUB(int a, int b, int c)
        {
            return a - b - c;
        }

        public static int SUB(int a, int b, int c, int d)
        {
            return a - b - c -d;
        }

        public static int MUL(int a, int b)
        {
            return a * b;
        }

        public static int MUL(int a, int b, int c)
        {
            return a * b * c;
        }

        public static int MUL(int a, int b, int c, int d)
        {
            return a * b * c * d;
        }

        public static int DIV(int a, int b)
        {
            int Z = 0;
            try
            {
                Z = a / b;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Z;
        }

        public static int DIV(int a, int b, int c)
        {
            int Z = 0;
            try
            {
                Z = (a / b) / c;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Z;
        }

        public static int DIV(int a, int b, int c, int d)
        {
            int Z = 0;
            try
            {
                Z = ((a / b) / c) / d;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Z;
        }
        static int PaldCheck(string s)
        {
            int a = 0;
            char[] c = s.ToCharArray();
            for(int i =0;i<s.Length;i++)
            {
                if(c[i]!=c[(s.Length)-1-i])
                {
                    Console.WriteLine("The string is not a palindrome");
                    a = 1;
                    return a;
                }
            }
            return a;
        }

        static void DeleteNames(ref List<string> C)
        {
            string A;
            Console.WriteLine("Enter the person name who you wanna delete:");
            A = Console.ReadLine();
            foreach (var D in C)
                if (D.Equals(A))
                {
                    int c =C.IndexOf(D);
                    C.RemoveAt(c);
                    break;
                }
        }
        static void Main(string[] args)
        {
            // 
            
            //STRING PALINDROME CHECK
            //string s;
            //Console.WriteLine("Enter the string ");
            //s = Console.ReadLine();
            //int b = PaldCheck(s);
            //if (b == 0)
            //Console.WriteLine("The string is a palindrome");

            // SQUARE OF AN ARRAY

            //int[] d = new int[4];
            //Console.WriteLine("enter the array elements");
            //for(int i = 0; i< 4; i++)
            //{
            //    d[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("The squares of " + d[i] + " is " + (d[i] * d[i]));
            //}


            // Deleting a selected Names
            //List<string> name = new List<string> { "John", "Luke", "Mark", "Adam", "Noah" };
            //Console.WriteLine("Displaying names, decide what to delete");
            //foreach (var B in name)
            //    Console.WriteLine(B);
            //DeleteNames(ref name);
            //foreach (var B in name)
            //    Console.WriteLine(B);


            // ADD ACCOUNTS IN A LIST
            //ListofEmp l1 = new ListofEmp();
            //Account a1 = new Account();
            //a1.GetDetails();
            //l1.AddEmp(a1);
            //Account a2 = new Account();
            //a2.GetDetails();
            //l1.AddEmp(a2);
            //l1.Display();

            // EMPLOYEE AND DEPARTMENT

            //Department d = new Department();
            //d.GetDetails();
            //d.Disp();

            // STUDENTS : SSK
            SSK s1 = new SSK();
            s1.GetStudentDetails();
            s1.GetStudentSubjects();
            s1.GetStudentMarks();
            s1.display();

            // HOSPITAL ABSTRACT

            CitizenBelow55 a = new CitizenBelow55();
            a.GEtPAtientDetails();
            a.PreviousAilments();
            a.ISeligibleforhealthinsurance();

            SeniorCitizen b = new SeniorCitizen();
            b.GEtPAtientDetails();
            b.PreviousAilments();
            b.ISeligibleforhealthinsurance();

            //METHOD OVERLOADING
            Console.WriteLine(ADD(1, 2));
            Console.WriteLine(ADD(1, 2, 3));
            Console.WriteLine(ADD(1, 2, 3, 4));

            Console.WriteLine(SUB(1, 2));
            Console.WriteLine(SUB(1, 2, 3));
            Console.WriteLine(SUB(1, 2, 3, 4));

            Console.WriteLine(MUL(1, 2));
            Console.WriteLine(MUL(1, 2, 3));
            Console.WriteLine(MUL(1, 2, 3, 4));

            Console.WriteLine(DIV(8, 4));
            Console.WriteLine(DIV(8, 4, 2));
            Console.WriteLine(DIV(1, 2, 3, 4));

            //Console.WriteLine("Hello World!");
        }
    }
}
