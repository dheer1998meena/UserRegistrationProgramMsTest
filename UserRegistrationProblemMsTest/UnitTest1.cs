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
    }
}
