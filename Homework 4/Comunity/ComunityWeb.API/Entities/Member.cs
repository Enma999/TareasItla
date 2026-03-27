using System;
using System.Collections.Generic;

namespace ComunityWeb.API.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }

        public List<Member> Members { get; set; }
        public Member()
        {
            
        }
    }
}
