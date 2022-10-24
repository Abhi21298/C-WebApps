using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3Exercise.Models
{
    public class Studentslist
    {
        public int StudID { get; set; }
        public string StudName { get; set; }

        public int StudAge { get; set; }

        //public List<Studentslist> GetStudents()
        //{
        //    List<Studentslist> l1 = new List<Studentslist>();
        //    l1.Add(new Studentslist { StudID = 1, StudName = "Abhi", StudAge = 17 });

        //    l1.Add(new Studentslist { StudID = 2, StudName = "Shek", StudAge = 18 });

        //    l1.Add(new Studentslist { StudID = 3, StudName = "Adi", StudAge = 19 });

        //    return l1;
        //}
    }

    
}