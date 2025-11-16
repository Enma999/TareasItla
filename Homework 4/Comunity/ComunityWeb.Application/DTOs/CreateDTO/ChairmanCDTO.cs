using System;
using System.Collections.Generic;
using System.Text;

namespace ComunityWeb.Application.DTOs.CreateDTO
{
    public class ChairmanCDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phones { get; set; }
        public int ChairmanID { get; set; }
        public ChairmanCDTO()
        {
            
        }
    }
}
