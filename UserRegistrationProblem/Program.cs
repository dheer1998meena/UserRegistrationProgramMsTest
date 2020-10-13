using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateDetails details = new ValidateDetails();
            Console.WriteLine("Enter the user first name :");
            string firstName = Console.ReadLine();
            while (!details.FirstNameValidation(firstName))
            {
                Console.WriteLine("Enter a valid first name : ");
                firstName = Console.ReadLine();
            }

            Console.WriteLine("Enter the user last name :");
            string lastName = Console.ReadLine();
            while (!details.LastNameValidation(lastName))
            {
                Console.WriteLine("Enter a valid last name : ");
                lastName = Console.ReadLine();
            }
        }
    }
}
