using System;

namespace ConsoleApp7
{
    class Program
    {
        //class Department
        //{
        //     public Department()
        //    {
        //        Console.WriteLine("Department created");
        //    }

        //    public void GetDeptName()
        //    {
        //        string ch = Console.ReadLine();
        //        Console.WriteLine("Dept, The dept is {0}", ch);
        //    }
        //    public virtual void GetNumofCourses()
        //    {
        //        int ch1 = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Dept, the number of courses is {0}",ch1);
        //    }
        //    public void DeptStaff()
        //    {
        //        Console.WriteLine("Dept,The number of staff is 32");
        //    }
        //}

        //class Employee : Department
        //{
        //     public Employee()
        //    {
        //        Console.WriteLine("Employee created");
        //    }

        //     public void EmpID()
        //    {
        //        Console.WriteLine("Emp, THe ID is 32");
        //    }
        //     public new void GetDeptName()
        //    {
        //        string ch = Console.ReadLine();
        //        Console.WriteLine("Emp, The dept is {0}", ch);
        //    }
        //     public override void GetNumofCourses()
        //    {
        //        int ch1 = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Emp, the number of courses is {0}", ch1);
        //    }

        //}
        class Example
        {
            public int value { get; set; }
            public Example(int passbyref)
            {
                this.value = passbyref;
            }

        }

        // Pass by value two --------------
        //static void increment(int i)
        //{
        //    i = i + 1;
        //    Console.WriteLine(i);
        //}

        // CONVERTING A VALUE TYPE INTO REF TYPE

        static void increment(ref int i)
        {
            i = i + 1;
            Console.WriteLine(i);
        }
        static void Main(string[] args) 
        {
            //Department dept = new Employee();
            //Console.WriteLine("Dept Name:");
            //dept.GetDeptName();
            //Console.WriteLine("No. of courses:");
            //dept.GetNumofCourses();
            //Console.WriteLine("No. of staff:");
            //dept.DeptStaff();
            //Console.WriteLine("Employee ID:");
            //dept.EmpID();
            //Console.WriteLine("Hello World!");

            // Down BELOW PASS BY REFERENCE------------

            Example v1 = new Example(12);
            Example v2 = new Example(22);
            v2 = v1;
            v1.value = 765;
            v2.value = 44;
            Console.WriteLine(v1.value);
            Console.WriteLine(v2.value);

            // DOWN BELOW PASS BY VALUE-----------------

            //int x1 = 45;
            //int x2 = 32;
            //x2 = x1;
            //x1 = 100;
            //Console.WriteLine(x1);
            //Console.WriteLine(x2);

            // pass by value two---------------------------------
            //int x = 1;
            // Program.increment(x);
            //Console.WriteLine(x);

            // CONVERTING A VALUE TYPE INTO REFERENCE TYPE
            //int x = 1;
            //Program.increment(ref x);
            //Console.WriteLine(x);
        }
    }
}
