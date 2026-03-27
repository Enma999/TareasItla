using System;
using System.Collections.Generic;
using System.Text;

namespace ComunityWeb.Application.DTOs.Enums
{
    public class CoordinatorDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Sector { get; set; }
        public string CommitteeName { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public CoordinatorDTO()
        {
            
        }
    }
}
