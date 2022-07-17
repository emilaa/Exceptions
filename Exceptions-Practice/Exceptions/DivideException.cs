using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions_Practice.Exceptions
{
    public class DivideException : Exception
    {
        public DivideException(string message) : base(message)
        {

        }
    }
}
