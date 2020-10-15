using System;

namespace UserRegistrationProblem
{
    public class Program
    {
        public  string firstName;
        public  string lastName;
        public  string emailId;
        public  string mobileNumber;
        public  string password;

        static void Main(string[] args)
        {
            ValidateDetails val = new ValidateDetails();
          
            Console.WriteLine("Enter User First Name=");
            val.firstName = Console.ReadLine();

            var validationKey = "";
            validationKey = val.IsValidFirstName(val.firstName);
            Console.WriteLine(validationKey);

            Console.WriteLine("Enter User Last Name=");
            val.lastName = Console.ReadLine();

            validationKey = val.IsValidLastName(val.lastName);
            Console.WriteLine(validationKey);

            Console.WriteLine("Enter User Email Id=");
            val.emailId = Console.ReadLine();

            validationKey = val.IsValidEmailId(val.emailId);
            Console.WriteLine(validationKey);

            Console.WriteLine("Enter User Mobile Number=");
            val.mobileNumber = Console.ReadLine();

            validationKey = val.IsValidMobileNumber(val.mobileNumber);
            Console.WriteLine(validationKey);

            Console.WriteLine("Enter User Password=");
            val.password = Console.ReadLine();

            validationKey = val.IsValidPassword(val.password);
            Console.WriteLine(validationKey);



            /*  string firstname, lastname, email, MobileNo;
              while (true)
              {
                  Console.WriteLine("Enter your First Name : ");
                  firstname = Console.ReadLine();
                  try
                  {
                      if (!val.FirstNameValidation(firstname))
                      {
                          throw new CustomException("Invalid first name");
                      }
                      break;
                  }
                  catch (CustomException ce)
                  {
                      Console.WriteLine(ce.Message);
                  }

              }

              while (true)
              {
                  Console.WriteLine("Enter your Last Name : ");
                  lastname = Console.ReadLine();
                  try
                  {
                      if (!val.LastNameValidation(lastname))
                      {
                          throw new CustomException("Invalid last name");
                      }
                      break;
                  }
                  catch (CustomException ce)
                  {
                      Console.WriteLine(ce.Message);
                  }

              }

              while (true)
              {
                  Console.WriteLine("Enter your emailId : ");
                  email = Console.ReadLine();
                  try
                  {
                      if (!val.EmailValidation(email))
                      {
                          throw new CustomException("Invalid emailId");
                      }
                      break;
                  }
                  catch (CustomException ce)
                  {
                      Console.WriteLine(ce.Message);
                  }
              }

              while (true)
              {
                  Console.WriteLine("Enter your mobile number : ");
                  MobileNo = Console.ReadLine();
                  try
                  {
                      if (!val.MobileNumberValidation(MobileNo))
                      {
                          throw new CustomException("Invalid mobile number");
                      }
                      break;
                  }

                  catch (CustomException ce)
                  {
                      Console.WriteLine(ce.Message);
                  }
              }

              while (true)
              {
                  Console.WriteLine("Enter a password : ");
                  string password = Console.ReadLine();
                  try
                  {
                      if (!val.Password4Validation(password))
                      {
                          throw new CustomException("Invalid password");
                      }
                      break;
                  }
                  catch (CustomException ce)
                  {
                      Console.WriteLine(ce.Message);
                  }
              }




              //UC1 First Name Validation
              /* Console.WriteLine("Enter the first name of the user");
               String firstName = Console.ReadLine();
               while (!val.FirstNameValidation(firstName))
               {
                   Console.WriteLine("Enter a valid First Name with first letter as Capital");
                   firstName = Console.ReadLine();
               }

            /*  // UC1 First name validation
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

              // UC6 Password validation by rule 2
              Console.WriteLine("Enter the user password :");
              string password2 = Console.ReadLine();
              while (!details.Password2Validation(password2))
              {
                  Console.WriteLine("Enter a valid password : ");
                  password2 = Console.ReadLine();
              }

              // UC7 Password validation by rule 3
              Console.WriteLine("Enter the user password :");
              string password3 = Console.ReadLine();
              while (!details.Password3Validation(password3))
              {
                  Console.WriteLine("Enter a valid password : ");
                  password3 = Console.ReadLine();
              }

              // UC8 Password validation by rule 4
              Console.WriteLine("Enter the user password :");
              string password4 = Console.ReadLine();
              while (!details.Password4Validation(password4))
              {
                  Console.WriteLine("Enter a valid password : ");
                  password4 = Console.ReadLine();
              }

              // UC9 Valid all email sample

              Console.WriteLine("Registration Successful.");
              Console.WriteLine("Name :" + firstName + " " + lastName);
              Console.WriteLine("Email ID : " + emailId);
              Console.WriteLine("Mobile Number : " + mobileNumber);
          }
            */
        }
    }
}
        
    
