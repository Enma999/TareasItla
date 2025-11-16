using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunityWeb.Domain.Entities
{
    public class Chairman
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ChairmanId { get; set; }
        public Chairman()
        {
            
        }
    }
}
