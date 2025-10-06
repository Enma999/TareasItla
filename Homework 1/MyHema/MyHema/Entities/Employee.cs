using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHema.Entities
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public int EmployeeAge { get; set; } = 0;
        public Employee()
        {
            Name = string.Empty;
            LastName = string.Empty;
            FirstName = string.Empty;
            Position = string.Empty;
        }
    }
}
