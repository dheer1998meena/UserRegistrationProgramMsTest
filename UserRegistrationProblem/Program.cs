﻿using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateDetails details = new ValidateDetails();
            
            // UC1 First name validation
            Console.WriteLine("Enter the user first name :");
            string firstName = Console.ReadLine();
            while (!details.FirstNameValidation(firstName))
            {
                Console.WriteLine("Enter a valid first name : ");
                firstName = Console.ReadLine();
            }

            // UC2 Last name validation
            Console.WriteLine("Enter the user last name :");
            string lastName = Console.ReadLine();
            while (!details.LastNameValidation(lastName))
            {
                Console.WriteLine("Enter a valid last name : ");
                lastName = Console.ReadLine();
            }

            // UC3 Email Id validation
            Console.WriteLine("Enter the user Email Id :");
            string emailId = Console.ReadLine();
            while (!details.EmailValidation(emailId))
            {
                Console.WriteLine("Enter a valid Email Id : ");
                emailId = Console.ReadLine();
            }

            // UC4 Mobile number validation
            Console.WriteLine("Enter the user mobile number :");
            string mobileNumber = Console.ReadLine();
            while (!details.MobileNumberValidation(mobileNumber))
            {
                Console.WriteLine("Enter a valid mobile number : ");
                mobileNumber = Console.ReadLine();
            }

            // UC5 Password validation by rule 1
            Console.WriteLine("Enter the user password :");
            string password1 = Console.ReadLine();
            while (!details.Password1Validation(password1))
            {
                Console.WriteLine("Enter a valid password : ");
                password1 = Console.ReadLine();
            }
        }
    }
}
