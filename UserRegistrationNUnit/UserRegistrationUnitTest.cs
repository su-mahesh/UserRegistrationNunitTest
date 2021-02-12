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
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_LESSTHAN_MINIMUM_LENGTH, exception.exceptionType);
            }
        }

        [Test]
        public void GivenLastName_WhenValid_ShouldReturnTrue()
        {
            bool result = userRegistration.ValidateLastName("Kangude");
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenEmailAddress_WhenValid_ShouldReturnTrue()
        {
            bool result = userRegistration.ValidateEmailAddress("abc.100@yahoo.com");
            Assert.IsTrue(result);
        }

        // TEST CASES : TEST NULL INPUT
        [Test]
        public void GivenFirstName_WhenNull_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidateFirstName(null);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_NULL, exception.exceptionType);
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
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_NULL, exception.exceptionType);
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
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_NULL, exception.exceptionType);
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
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_NULL, exception.exceptionType);
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
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_NULL, exception.exceptionType);
            }
        }

        // TEST CASES : TEST EMPTY FIELD
        [Test]
        public void GivenFirstName_WhenEmpty_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidateFirstName("");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_EMPTY, exception.exceptionType);
            }
        }

        [Test]
        public void GivenLastName_WhenEmpty_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidateLastName("");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_EMPTY, exception.exceptionType);
            }
        }

        [Test]
        public void GivenEmailAddress_WhenEmpty_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidateEmailAddress("");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_EMPTY, exception.exceptionType);
            }
        }

        [Test]
        public void GivenMobileNumber_WhenEmpty_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidateMobileNumber("");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_EMPTY, exception.exceptionType);
            }
        }

        [Test]
        public void GivenPassword_WhenEmpty_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidatePassword("");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_EMPTY, exception.exceptionType);
            }
        }


        // TEST CASES : TEST LESS THAN MINIMUM LENGTH

        [Test]
        public void GivenFirstName_WhenLessThanMinimumLength_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidateFirstName("Ma");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_LESSTHAN_MINIMUM_LENGTH, exception.exceptionType);
            }
        }

        [Test]
        public void GivenLastName_WhenLessThanMinimumLength_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidateLastName("Ka");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_LESSTHAN_MINIMUM_LENGTH, exception.exceptionType);
            }
        }

        [Test]
        public void GivenEmailAddress_WhenLessThanMinimumLength_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidateEmailAddress("m@.co");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_LESSTHAN_MINIMUM_LENGTH, exception.exceptionType);
            }
        }

        [Test]
        public void GivenMobileNumber_WhenLessThanMinimumLength_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidateMobileNumber("91 123456789");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_LESSTHAN_MINIMUM_LENGTH, exception.exceptionType);
            }
        }

        [Test]
        public void GivenPassword_WhenLessThanMinimumLength_ShouldThrowCustomException()
        {
            try
            {
                bool result = userRegistration.ValidatePassword("b$vh7VK");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(UserRegistrationException.ExceptionType.ENTERED_LESSTHAN_MINIMUM_LENGTH, exception.exceptionType);
            }
        }
    }
}