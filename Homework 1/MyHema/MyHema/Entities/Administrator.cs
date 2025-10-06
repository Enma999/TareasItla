using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHema.Entities
{
    internal class Administrator
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int AdminId { get; set; } = 0;
        public string Role { get; set; }
        public string AdminDepartment { get; set; }
        public int AdminAge { get; set; } = 0;
        public Administrator()
        {
            Name = string.Empty;
            LastName = string.Empty;
            FirstName = string.Empty;
            Role = string.Empty;
            AdminDepartment = string.Empty;
        }
    }
    }
