using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.ExceptionServices;

namespace UserRegistrationProblem
{
    class CustomException : ApplicationException
    {
        public CustomException(string message) : base(message)
        {

        }
    }
}
