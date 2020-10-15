using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.ExceptionServices;

namespace UserRegistrationProblem
{
     public class UserRegistrationCustomException :ApplicationException
    {
        public enum ExceptionType
        {
            WRONG_FIRSTNAME,WRONG_LASTNAME,WRONG_EMAIL,WRONG_MOBILENUMBER,WRONG_PASSWORD
        }
        private readonly ExceptionType type;
        public UserRegistrationCustomException(ExceptionType type, string message):base(message)
        {
            this.type = type;
        }
    }
}
