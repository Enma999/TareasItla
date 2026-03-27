using System;
using System.Collections.Generic;
using System.Text;

namespace ComunityWeb.Application.DTOs.Enums
{
    public class ChairmanDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
        public object CommunityName { get; internal set; }

        public ChairmanDTO()
        {
            
        }
    }
}
