using NUnit.Framework;
using UserRegistrationNameSpace;

namespace UserRegistrationNUnit
{
    public class UserRegistratioinTests
    {
        UserRegistrationRegex userRegistration;
        [SetUp]
        public void Setup()
        {
            userRegistration = new UserRegistrationRegex();
        }

        [Test]
        public void GivenFirstName_WhenValid_ShouldReturnTrue()
        {
            bool result = userRegistration.ValidateFirstName("Mahesh");
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenFirstName_WhenInvalid_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidateFirstName("kangude");
            }
            catch(UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.INVALID_FIRST_NAME, exception.exceptionType);
            }           
        }

        [Test]
        public void GivenLastName_WhenValid_ShouldReturnTrue()
        {
            bool result = userRegistration.ValidateLastName("Kangude");
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenLastName_WhenInvalid_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidateLastName("kangude");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.INVALID_LAST_NAME, exception.exceptionType);
            }
        }

        [Test]
        public void GivenEmailAddress_WhenValid_ShouldReturnTrue()
        {
            bool result = userRegistration.ValidateEmailAddress("abc.100@yahoo.com");
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenEmailAddress_WhenInvalid_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidateEmailAddress("abc.100.@yahoo.com");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.INVALID_EMAIL, exception.exceptionType);
            }
        }

        [Test]
        public void GivenMobileNumber_WhenValid_ShouldReturnTrue()
        {
            bool result = userRegistration.ValidateMobileNumber("91 4959399432");
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenMobileNumber_WhenInvalid_ShouldThrowCustomException()
        {            
            try
            {
                bool result = userRegistration.ValidateMobileNumber("914959399432");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.INVALID_MOBILE_NUMBER, exception.exceptionType);
            }
        }

        [Test]
        public void GivenPassword_WhenValid_ShouldReturnTrue()
        {
            bool result = userRegistration.ValidatePassword("hvjh8vJ&Jbkbk");
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenPassword_WhenInvalid_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidatePassword("ffwefH(*HKkwnfw");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.INVALID_PASSWORD, exception.exceptionType);
            }
        }

        [Test]
        public void GivenFirstName_WhenNull_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidateFirstName(null);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERD_NULL, exception.exceptionType);
            }
        }

        [Test]
        public void GivenLastName_WhenNull_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidateLastName(null);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERD_NULL, exception.exceptionType);
            }
        }

        [Test]
        public void GivenEmailAddress_WhenNull_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidateEmailAddress(null);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERD_NULL, exception.exceptionType);
            }
        }

        [Test]
        public void GivenMobileNumber_WhenNull_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidateMobileNumber(null);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERD_NULL, exception.exceptionType);
            }
        }

        [Test]
        public void GivenPassword_WhenNull_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidatePassword(null);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERD_NULL, exception.exceptionType);
            }
        }
    }
}