using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class College
    {
        List<Student> students;
        public College()
        {
            students = new List<Student>();
        }

        public string AddStudent(Student student)
        {
            students.Add(student);
            return "Student added successfully";
        }

       public List<Student> GetStudent()
        {
            return students;
        }
    }
}
