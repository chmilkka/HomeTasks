using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask13
{
    internal class DeniedOperationException : Exception
    {
        public DeniedOperationException(string message) : base(message) { }

                       
    }
}
