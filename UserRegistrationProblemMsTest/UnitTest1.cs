using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;

namespace UserRegistrationProblemMsTest
{
    [TestClass]
    public class UnitTest1
    {
        // UC1 Valid first name
        [TestMethod]
        public void TestFirstName()
        {
            // Arrange
            string message = "Dheer";
            bool expected = true;
            ValidateDetails validatePattern = new ValidateDetails();
            // Act 
            bool result = validatePattern.FirstNameValidation(message);
            // Assert
            Assert.AreEqual(expected, result);
        }

        // UC2 valid last name.
        [TestMethod]
        public void TestLastName()
        {
            // Arrange
            string message = "Singh";
            bool expected = true;
            ValidateDetails validatePattern = new ValidateDetails();
            // Act 
            bool result = validatePattern.FirstNameValidation(message);
            // Assert
            Assert.AreEqual(expected, result);
        }

        // UC3 Email Id validation
        [TestMethod]
        public void TestEmail()
        {
            // Arrange
            string message = "abc.xyz@gmail.com";
            bool expected = true;
            ValidateDetails validatePattern = new ValidateDetails();
            // Act 
            bool result = validatePattern.EmailValidation(message);
            // Assert
            Assert.AreEqual(expected, result);
        }

        // UC4 Mobile number validation
        [TestMethod]
        public void TestMobileNumber()
        {
            // Arrange
            string message = "91 1122334455";
            bool expected = true;
            ValidateDetails validatePattern = new ValidateDetails();
            // Act 
            bool result = validatePattern.MobileNumberValidation(message);
            // Assert
            Assert.AreEqual(expected, result);   
        }

        // UC5 Password validation by rule 1
        [TestMethod]
        public void TestPasswordByRule1()
        {
            // Arrange
            string message = "abcdefghi";
            bool expected = true;
            ValidateDetails validatePattern = new ValidateDetails();
            // Act 
            bool result = validatePattern.Password1Validation(message);
            // Assert
            Assert.AreEqual(expected, result);
        }

        // UC6 Password validation by rule 2
        [TestMethod]
        public void TestPasswordByRule2()
        {
            // Arrange
            string message = "ABHJhddaf";
            bool expected = true;
            ValidateDetails validatePattern = new ValidateDetails();
            // Act 
            bool result = validatePattern.Password2Validation(message);
            // Assert
            Assert.AreEqual(expected, result);
        }

        // UC7 Password validation by rule 3
        [TestMethod]
        public void TestPasswordByRule3()
        {
            // Arrange
            string message = "ABH95ddaf";
            bool expected = true;
            ValidateDetails validatePattern = new ValidateDetails();
            // Act 
            bool result = validatePattern.Password3Validation(message);
            // Assert
            Assert.AreEqual(expected, result);
        }

        // UC8 Password validation by rule 4
        [TestMethod]
        public void TestPasswordByRule4()
        {
            // Arrange
            string message = "Asd9@ghh";
            bool expected = true;
            ValidateDetails validatePattern = new ValidateDetails();
            // Act 
            bool result = validatePattern.Password4Validation(message);
            // Assert
            Assert.AreEqual(expected, result);
        }

        // UC9 Valid all email samples
        [TestMethod]
        [DataRow("dheer@gmail.com", true)]
        [DataRow("dheer-1999@gmail.com", true)]
        [DataRow("dheer@.com.in", false)]
        public void TestEmails(string message, bool expected)
        {
            //Arrange
            ValidateDetails validatePattern = new ValidateDetails();

            //Act
            bool result = validatePattern.ValidateEmailSet(message);
            //Assert
            Assert.AreEqual(expected, result);
        }

        //UC11 Test For Multiple Entry
        [TestMethod]
        [DataRow("dheer@gmail.com")]
        [DataRow("dheer1999@gmail.com")]
        [DataRow("dheer@gmail.com")]
        public void TestMultipleEntry(string email)
        {
            //Arrange
            ValidateDetails validatePattern = new ValidateDetails();
            bool expected = true;

            //Act
            bool result = validatePattern.EmailValidation(email);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
