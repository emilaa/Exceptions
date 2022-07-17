using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions_Practice.Exceptions
{
    public class FindNameException : Exception
    {
        public FindNameException(string message) : base(message)
        {

        }
    }
}
