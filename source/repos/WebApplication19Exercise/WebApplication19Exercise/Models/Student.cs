using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication19Exercise.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateofBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
    }
}
