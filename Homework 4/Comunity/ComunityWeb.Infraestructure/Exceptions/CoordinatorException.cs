using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunityWeb.Infraestructure.Exceptions
{
    public class CoordinatorException : Exception
    {
        public CoordinatorException()
        {
            
        }
        public CoordinatorException(string message) : base(message)
        { 
        }
    }
}
