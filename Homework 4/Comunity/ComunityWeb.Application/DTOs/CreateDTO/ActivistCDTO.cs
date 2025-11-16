using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComunityWeb.Application.DTOs.CreateDTO
{
    public class ActivistCDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public ActivistCDTO()
        {
            
        }
    }
}
