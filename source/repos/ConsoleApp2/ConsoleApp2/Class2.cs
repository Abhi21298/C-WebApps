using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class College
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

        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
