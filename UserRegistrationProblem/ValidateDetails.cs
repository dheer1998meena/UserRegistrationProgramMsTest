using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class ValidateDetails
    {
        public Boolean FirstNameValidation(string firstName)
        {
            Regex regex = new Regex("^[A-Z][a-z]{2,}$");
            if (regex.IsMatch(firstName))
                return true;
            else
                return false;
        }
    }
}

