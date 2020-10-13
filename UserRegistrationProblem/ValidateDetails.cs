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
        public Boolean LastNameValidation(string lastName)
        {
            Regex regex = new Regex("^[A-Z][a-z]{2,}$");
            if (regex.IsMatch(lastName))
                return true;
            else
                return false;
        }
        public Boolean EmailValidation(string emailId)
        {
            Regex regex = new Regex("^[a-zA-Z]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})?$");
            if (regex.IsMatch(emailId))
                return true;
            else
                return false;
        }
        public Boolean MobileNumberValidation(string mobileNumber)
        {
            Regex regex = new Regex("^[0-9]{2}[ ][0-9]{10}$");
            if (regex.IsMatch(mobileNumber))
                return true;
            else
                return false;
        }
        public Boolean Password1Validation(string password)
        {
            Regex regex = new Regex("^[a-zA-Z]{8,}$");
            if (regex.IsMatch(password))
                return true;
            else
                return false;
        }
    }
}

