using System;
using System.Collections.Generic;
using System.Text;

namespace ComunityWeb.Application.DTOs.CreateDTO
{
    public class MemberCDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PhoneNumber { get; set; }
        public MemberCDTO()
        {
            
        }
    }
}
