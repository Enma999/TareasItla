using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunityWeb.Infraestructure.Models
{
    public class ChairmanModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string HairmanName { get; set; }
        public string HairmanDescription { get; set; }
        public int HairmanId { get; set; }
        public ChairmanModel()
        {
            
        }
    }
}
