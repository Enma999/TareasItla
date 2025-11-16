using System;
using System.Collections.Generic;
using System.Text;

namespace ComunityWeb.Application.DTOs.Enums
{
    public class MemberDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }

        public MemberDTO()
        {
            
        }
    }
}
