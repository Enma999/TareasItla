using System;
using System.Collections.Generic;
using System.Text;

namespace ComunityWeb.Application.DTOs.Enums
{
    public class ActivistDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public string Cedula { get; set; }
        public string Zone { get; set; }
        public string Level { get; set; }
        public string Phone {  get; set; }

        public ActivistDTO()
        {
            
        }
    }
}
