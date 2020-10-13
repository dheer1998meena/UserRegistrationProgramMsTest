using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;

namespace UserRegistrationProblemMsTest
{
    [TestClass]
    public class UnitTest1
    {
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
    }
}
