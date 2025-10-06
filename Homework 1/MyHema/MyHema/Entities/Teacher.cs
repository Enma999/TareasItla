using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHema.Entities
{
    internal class Teacher
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int TeacherId { get; set; }
        public string Subject { get; set; }
        public int TeacherAge { get; set; } = 0;
        public Teacher(int v) { }
        public Teacher() 
        {
            Name = string.Empty;
            LastName = string.Empty;
            FirstName = string.Empty;
            Subject = string.Empty;
        }
    }
}
