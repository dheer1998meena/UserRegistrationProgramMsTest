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
        }
    }
}
