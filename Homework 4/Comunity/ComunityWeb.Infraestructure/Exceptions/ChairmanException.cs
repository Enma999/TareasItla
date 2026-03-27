using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunityWeb.Infraestructure.Exceptions
{
    public class ChairmanException : Exception
    {
        public ChairmanException()
        {
            
        }
        public ChairmanException(string message) : base(message)
        {
        }
    }
}
