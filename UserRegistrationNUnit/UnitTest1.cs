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
    }
}