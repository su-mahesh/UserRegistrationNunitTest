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
        public void GivenFirstName_WhenInvalid_ShouldReturnFalse()
        {
            bool result = userRegistration.ValidateFirstName("MAHESH");
            Assert.IsFalse(result);
        }

        [Test]
        public void GivenLastName_WhenValid_ShouldReturnTrue()
        {
            bool result = userRegistration.ValidateLastName("Kangude");
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenLastName_WhenInvalid_ShouldReturnFalse()
        {
            bool result = userRegistration.ValidateLastName("kangude");
            Assert.IsFalse(result);
        }

        [Test]
        public void GivenEmailAddress_WhenValid_ShouldReturnTrue()
        {
            bool result = userRegistration.ValidateEmailAddress("abc.100@yahoo.com");
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenEmailAddress_WhenInvalid_ShouldReturnFalse()
        {
            bool result = userRegistration.ValidateEmailAddress("abc.100.@yahoo.com");
            Assert.IsFalse(result);
        }

        [Test]
        public void GivenMobileNumber_WhenValid_ShouldReturnTrue()
        {
            bool result = userRegistration.ValidateMobileNumber("91 4959399432");
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenMobileNumber_WhenInvalid_ShouldReturnFalse()
        {
            bool result = userRegistration.ValidateMobileNumber("914959399432");
            Assert.IsFalse(result);
        }

        [Test]
        public void GivenPassword_WhenValid_ShouldReturnTrue()
        {
            bool result = userRegistration.ValidatePassword("hvjh8vJJbkbk");
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenPassword_WhenInvalid_ShouldReturnTrue()
        {
            bool result = userRegistration.ValidatePassword("ffwefHHKkwnfw");
            Assert.IsFalse(result);
        }
    }
}