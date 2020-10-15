using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;

namespace UserRegistrationProblemMsTest
{
    [TestClass]
    public class UnitTest1
    {
        public static bool actual = true;

        // To test first name
        [TestCategory("firstName")]
        [TestMethod]
        public void TestInputForFirstName()
        {
            // Arrange
            ValidateDetails validate = new ValidateDetails();
            try
            {
                // Act 
                string expected = validate.IsValidFirstName("Dheer");
            }
            catch (UserRegistrationCustomException ex)
            {
                // Assert
                Assert.AreEqual("Invalid first name", ex.Message);
            }
        }

        // To test last name.
        [TestCategory("lasttName")]
        [TestMethod]
        public void TestInputForLastName()
        {
            // Arrange
            ValidateDetails validate = new ValidateDetails();
            try
            {
                // Act 
                string expected = validate.IsValidLastName("Singh");
            }
            catch (UserRegistrationCustomException ex)
            {
                // Assert
                Assert.AreEqual("Invalid last name", ex.Message);
            }
        }

        // To test Email Id validation
        [TestCategory("emailId")]
        [TestMethod]
        public void TestInputForEmailId()
        {
            // Arrange
            ValidateDetails validate = new ValidateDetails();
            try
            {
                // Act 
                string expected = validate.IsValidEmailId("xyz.abc@gamil.com");
            }
            catch (UserRegistrationCustomException ex)
            {
                // Assert
                Assert.AreEqual("Invailid eamil Id", ex.Message);
            }
        }

        // To test mobile number 
        [TestCategory("mobileNumber")]
        [TestMethod]
        public void TestInputForMobileNumber()
        {
            // Arrange
            ValidateDetails validate = new ValidateDetails();
            try
            {
                // Act 
                string expected = validate.IsValidMobileNumber("91 1236459871");
            }
            catch (UserRegistrationCustomException ex)
            {
                // Assert
                Assert.AreEqual("Invailid mobile number", ex.Message);
            }
        }

        // To test Password validation 
        [TestCategory("password")]
        [TestMethod]
        public void TestInputForPassword()
        {
            // Arrange
            ValidateDetails validate = new ValidateDetails();
            try
            {
                // Act 
                string expected = validate.IsValidPassword("Djj@1998");
            }
            catch (UserRegistrationCustomException ex)
            {
                // Assert
                Assert.AreEqual("Invalid password", ex.Message);
            }
        }

        // To Test Case For Multiple Email Entries

        [DataRow("dheerh@gmail.co.in")]
        [DataRow("dheer-singh@gmail.co.in")]
        [DataRow("dheersingh@gmail.co.us")]
        [TestCategory("Validate Multiple E-Mail")]
        [TestMethod]
        public void TestingInputForMultipleEmailId(string emailId)
        {
            //Arrange
            ValidateDetails validate = new ValidateDetails();
            try
            {
                string expected = validate.IsValidEmailId(emailId);
            }
            catch (UserRegistrationCustomException ex)
            {
                //Assert
                Assert.AreEqual("Invaild  eamil Id", ex.Message);
            }
        }

    }
}
