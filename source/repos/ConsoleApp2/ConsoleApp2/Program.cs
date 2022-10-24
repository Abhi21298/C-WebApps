using System;
using System.Collections.Generic;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //int b;
            //a = 3;
            //b = 7;
            //int c = a + b;

            //Console.WriteLine("Hello World!");
            //string name;
            //Console.WriteLine("Hello: {0}", name = Console.ReadLine());
            //Console.WriteLine("how many hours of sleep did you get:");

            //int hours = Convert.ToInt32(Console.ReadLine());
            //if (hours > 8)
            //    Console.WriteLine("Hello {0}, you seem to be well rested", name);
            //else
            //    Console.WriteLine("Hello {0}, you must be very tired", name);
            //Console.WriteLine("Please enter a number");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //if (Number > 20)
            //    Console.WriteLine("The value is greater than 20");
            //else
            //    Console.WriteLine("the value is lesser than 20");
            //Console.WriteLine("The number is {0}", Number);
            //Console.ReadLine();
            //Console.WriteLine("Please enter a number");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a == 20)
            //    Console.WriteLine("The value of a is 20");
            //else if (a == 30)
            //    Console.WriteLine("The value of a is 30");
            //else if (a == 40)
            //    Console.WriteLine("The value of a is 40");
            //else
            //    Console.WriteLine("None of the valuesmatch");
            //Console.WriteLine("THe value of a is {0}", a);
            //Console.ReadLine();
            //int Num1, Num2;
            //string Op;
            //Console.WriteLine("Enter the numbers");
            //Num1 = Convert.ToInt32(Console.ReadLine());
            //Num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the operation type:");
            //Op = Console.ReadLine();
            //if (Op.Equals("Add"))
            //    Console.WriteLine("The addition of two numbers is {0}", Num1 + Num2);
            //else if (Op.Equals("Sub"))
            //    Console.WriteLine("The subtraction of two numbers is {0}", Num1 - Num2);
            //else if (Op.Equals("Mul"))
            //    Console.WriteLine("The multiplication of two numbers is {0}", Num1 * Num2);
            //else if (Op.Equals("Divide") && Num2 != 0)
            //    Console.WriteLine("The division of two numbers is {0}", Convert.ToDouble(Num1 / Num2));
            //else
            //    Console.WriteLine("Operation type invalid");
            //int a = 1;
            //int b = 3;
            //if (!(a == 1 && b == 2))
            //    Console.WriteLine(true);
            //if (a != 1 || b != 2)
            //    Console.WriteLine(true);
            Student student = new Student();
            student.StudentID = 24;
            student.FirstName = "Abhi";
            student.LastName = "Rao";
            student.Location = "Chennai";

            College college = new College();
            string text = college.AddStudent(student);      
            List<Student> students = college.GetStudents();

            Console.WriteLine(text);
            foreach (var D in students)
            {
                Console.WriteLine(D.FirstName);
                Console.WriteLine(D.LastName);
                Console.WriteLine(D.StudentID);
                Console.WriteLine(D.Location);
            }
        }
    }
}
