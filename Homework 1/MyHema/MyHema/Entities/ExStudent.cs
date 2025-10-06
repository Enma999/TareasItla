using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHema.Entities
{
    internal class ExStudent
    {
        public int ExStudentId { get; set; } = 0;
        public int ExStudentTuition { get; set; } = 0;
        public string Name { get; set; }
        public string LastName { get; set; }
        public int ExStudentAge { get; set; } = 0;
        public string PreviousCarrier { get; set; }
        public int GraduationYear { get; set; } = 0;
        public int GraduationMonth { get; set; } = 0;
        public int GraduationDay { get; set; } = 0;
        public ExStudent()
        {
            Name = string.Empty;
            LastName = string.Empty;
            PreviousCarrier = string.Empty;
        }
    }
}
