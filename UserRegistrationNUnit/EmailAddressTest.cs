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

        [TestCase("abc", false)]
        [TestCase("abc@.com.my", false)]
        [TestCase("abc", false)]
        [TestCase("abc123@.com.com", false)]
        [TestCase(".abc@abc.com", false)]
        [TestCase("abc()*@gmail.com", false)]
        [TestCase("abc@%*.comy", false)]
        [TestCase("abc..2002@gmail.coma", false)]
        [TestCase("abc.@gmail.com", false)]
        [TestCase("abc@abc@gmail.com", false)]
        [TestCase("abc@gmail.com.1a", false)]
        [TestCase("abc@gmail.com.aa.au", false)]

        public void GivenParameterizedEmailAddress_WhenInvalidOrValid_ShouldReturnExpected(String email, bool expected)
        {
            bool result = userRegistration.ValidateEmailAddress(email);
            Assert.AreEqual(expected, result);
        }
    }
}
