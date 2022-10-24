using System;
using System.Collections.Generic;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Student stud = new Student();
            stud.FirstName = "Abhi";
            stud.LastName = "rao";
            stud.Location = "Chennai";
            stud.StudentID = 1998;
            Student stud2 = new Student()
            {
                FirstName = "Shek",
                LastName = "S",
                StudentID = 23,
                Location = "Chen"
            };

            College col = new College();
            col.AddStudent(stud);
            col.AddStudent(stud2);

            List<Student> studlist = col.GetStudent();
            foreach (var B in studlist)
                Console.WriteLine(B.FirstName);

        }
    }
}
