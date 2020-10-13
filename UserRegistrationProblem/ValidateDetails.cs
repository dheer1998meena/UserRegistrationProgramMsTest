using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class ValidateDetails
    {
        // First name validation
        public Boolean FirstNameValidation(string firstName)
        {
            Regex regex = new Regex("^[A-Z][a-z]{2,}$");
            if (regex.IsMatch(firstName))
                return true;
            else
                return false;
        }

        // Last name validation
        public Boolean LastNameValidation(string lastName)
        {
            Regex regex = new Regex("^[A-Z][a-z]{2,}$");
            if (regex.IsMatch(lastName))
                return true;
            else
                return false;
        }

        // Email Id validation
        public Boolean EmailValidation(string emailId)
        {
            Regex regex = new Regex("^[a-zA-Z]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})?$");
            if (regex.IsMatch(emailId))
                return true;
            else
                return false;
        }

        // UC4 Mobile number validation
        public Boolean MobileNumberValidation(string mobileNumber)
        {
            Regex regex = new Regex("^[0-9]{2}[ ][0-9]{10}$");
            if (regex.IsMatch(mobileNumber))
                return true;
            else
                return false;
        }

        // UC5 Password validation by rule 1
        public Boolean Password1Validation(string password)
        {
            Regex regex = new Regex("^[a-zA-Z]{8,}$");
            if (regex.IsMatch(password))
                return true;
            else
                return false;
        }

        // UC6 Password validation by rule 2
        public Boolean Password2Validation(string password2)
        {
            Regex regex = new Regex("^(=?.*[A-Z]).{8,}$");
            if (regex.IsMatch(password2))
                return true;
            else
                return false;
        }

        // UC7 Password validation by rule 3
        public Boolean Password3Validation(string password3)
        {
            Regex regex = new Regex("^(?=.*[A-Z])(?=.*[0-9]).{8,}$");
            if (regex.IsMatch(password3))
                return true;
            else
                return false;
        }
    }
}

