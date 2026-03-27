using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunityWeb.Infraestructure.Exceptions
{
    public class MemberException : Exception
    {
        public MemberException()
        {
            
        }
        public MemberException(string message) : base(message)
        {

        }
    }
}
