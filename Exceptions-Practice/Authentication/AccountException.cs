using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions_Practice.Authentication
{
    public class AccountException : Exception
    {
        public AccountException(string message) : base(message)
        {

        }
    }
}
