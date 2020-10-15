using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class ValidateDetails
    {
        public string firstName;
        public string lastName;
        public string mobileNumber;
        public string emailId;
        public string password;

        public static string FIRSTNAME_REGEX = "^[A-Z][a-z]{2,}$";
        public static string LASTNAME_REGEX = "^[A-Z][a-z]{2,}$";
        public static string EMAIL_REGEX = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
        public static string MOBILENUMBER_REGEX = "^[0-9]{2}[ ][0-9]{10}$";
        public static string PASSWORD_REGEX = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";

        // First name validation
        public string IsValidFirstName(string firstName)
        {
            try
            {
                if (Regex.IsMatch(firstName, FIRSTNAME_REGEX))
                    return "Correct Entry";
                else
                    throw new Exception();
            }
            catch
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.WRONG_FIRSTNAME, "invalid first name");

            }
        }

        // Last name validation
        public string IsValidLastName(string lastName)
        {
            try
            {
                if (Regex.IsMatch(lastName, LASTNAME_REGEX))
                    return "Correct Entry";
                else
                    throw new Exception();
            }
            catch
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.WRONG_LASTNAME, "invalid last name");

            }
        }

        // Email Id validation
        public string IsValidEmailId(string emailId)
        {
            try
            {
                if (Regex.IsMatch(emailId, EMAIL_REGEX))
                    return "Correct Entry";
                else
                    throw new Exception();
            }
            catch
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.WRONG_EMAIL, "invalid email Id");

            }
        }

        // UC4 Mobile number validation
        public string IsValidMobileNumber(string mobileNumber)
        {
            try
            {
                if (Regex.IsMatch(mobileNumber, MOBILENUMBER_REGEX))
                    return "Correct Entry";
                else
                    throw new Exception();
            }
            catch
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.WRONG_MOBILENUMBER, "invalid mobile number");

            }
        }
        // UC5 Password validation by rule 1
        public string IsValidPassword(string password)
        {
            try
            {
                if (Regex.IsMatch(password, PASSWORD_REGEX))
                    return "Correct Entry";
                else
                    throw new Exception();
            }
            catch
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.WRONG_PASSWORD, "invalid password");

            }
        }

    }
}
