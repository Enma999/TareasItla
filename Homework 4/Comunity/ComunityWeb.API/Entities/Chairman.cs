using System;
using System.Collections.Generic;

namespace ComunityWeb.API.Entities
{
    public class Chairman
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ChairmanId { get; set; }

        public List<Chairman> Chairmen {  get; set; }
        public Chairman()
        {
            
        }
    }
}
