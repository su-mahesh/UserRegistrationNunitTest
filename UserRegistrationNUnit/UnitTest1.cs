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
        public void GivenFirstName_WhenProper_ShouldReturnTrue()
        {
            bool result = userRegistration.ValidateFirstName("Mahesh");
            Assert.IsTrue(result);
        }
    }
}