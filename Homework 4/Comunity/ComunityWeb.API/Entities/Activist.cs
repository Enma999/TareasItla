using System;
using System.Collections.Generic;

namespace ComunityWeb.API.Entities
{
    public class Activist
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactInfo { get; set; }
        public string Type { get; set; }
        public string TypeCode { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public List<Coordinator> Activists { get; set; }
        public Activist()
        {
            
        }
    }
}
