using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHema.Entities
{
    internal class Student
    {
        public int StudentId { get; set; }
        public int StudentNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Carrier { get; set; }
        public int Course { get; set; } = 0;
        public int StudentAge { get; set; } = 0;
        public int StudentTuition { get; set; }
        public string Major { get; internal set; }
        public Student()
        {
            Name = string.Empty;
            LastName = string.Empty;
            Major = string.Empty;
        }
    }
}