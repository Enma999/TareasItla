using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHema.Entities
{
    public class CommunityMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; } = 0;
        public string Email { get; set; }
        public string Role { get; set; }
        public int Phone { get; set; } = 0;
        public string Address { get; set; } 
        public int MemberId { get; set; } = 0;
        public int MemberAge { get; set; } = 0;
        public CommunityMember()
        {
            Name = string.Empty;
            LastName = string.Empty;
            FirstName = string.Empty;
            Email = string.Empty;
            Role = string.Empty;
            Address = string.Empty;
        }
    }
}
