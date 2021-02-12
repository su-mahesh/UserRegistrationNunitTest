using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using UserRegistrationNameSpace;

namespace UserRegistrationNUnit
{
    class EmailAddressTest
    {
        UserRegistrationRegex userRegistration;
        [SetUp]
        public void Setup()
        {
            userRegistration = new UserRegistrationRegex();
        }

        [TestCase("abc@yahoo.com", true)]
        [TestCase("abc-100@yahoo.com", true)]
        [TestCase("abc.100@yahoo.com", true)]
        [TestCase("abc111@abc.com", true)]
        [TestCase("abc-100@abc.net", true)]
        [TestCase("abc.100@abc.com.au", true)]
        [TestCase("abc@1.com", true)]
        [TestCase("abc@gmail.com.com", true)]
        [TestCase("abc+100@gmail.com", true)]
       

        [TestCase("abc123@.com.com", false)]
        [TestCase("abc()*@gmail.com", false)]        
        [TestCase("abc..2002@gmail.coma", false)]
        [TestCase("abc.@gmail.com", false)]
        [TestCase("abc@abc@gmail.com", false)]
        [TestCase("abc@gmail.com.aa.au", false)]
        public void GivenParameterizedEmailAddress_WhenInvalidOrValid_ShouldReturnExpected(String email, bool expected)
        {           
                bool result = userRegistration.ValidateEmailAddress(email);
                Assert.AreEqual(expected, result);                                 
        }

        [TestCase("abc", UserRegistrationException.ExceptionType.ENTERED_LESSTHAN_MINIMUM_LENGTH)]
        public void GivenEmailAddress_WhenLessThanMinimumLength_ShouldThrowCustomException(String email, UserRegistrationException.ExceptionType expected)
        {
            try
            {
                bool result = userRegistration.ValidateEmailAddress("m@.co");
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(expected, exception.exceptionType);
            }
        }

        [TestCase("abc@%*.comy", UserRegistrationException.ExceptionType.ENTERED_INVALID_EMAIL_TLD)]
        public void GivenEmailAddress_WhenTldContainsSpecialChar_ShouldThrowCustomException(String email, UserRegistrationException.ExceptionType expected)
        {
            try
            {
                bool result = userRegistration.ValidateEmailAddress(email);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(expected, exception.exceptionType);
            }
        }

        [TestCase(".abc@abc.com", UserRegistrationException.ExceptionType.ENTERED_INVALID_EMAIL_USERNAME)]
        public void GivenEmailAddress_WhenUsernameStartWithSpecialChar_ShouldThrowCustomException(String email, UserRegistrationException.ExceptionType expected)
        {
            try
            {
                bool result = userRegistration.ValidateEmailAddress(email);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(expected, exception.exceptionType);
            }
        }

        [TestCase("abc@gmail.com.1a", UserRegistrationException.ExceptionType.ENTERED_DIGIT_IN_COUNTRY_TLD)]
        public void GivenEmailAddress_WhenTldContainsDigit_ShouldThrowCustomException(String email, UserRegistrationException.ExceptionType expected)
        {
            try
            {
                bool result = userRegistration.ValidateEmailAddress(email);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual(expected, exception.exceptionType);
            }
        }
    }
}
