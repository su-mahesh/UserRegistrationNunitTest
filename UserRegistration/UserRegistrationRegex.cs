using System;
using System.Text.RegularExpressions;

namespace UserRegistrationNameSpace
{
    public class UserRegistrationRegex
    {
        public Regex FirstNameRegex = new Regex(@"^[A-Z][a-z]{2,}$");
        public Regex LastNameRegex = new Regex(@"^[A-Z][a-zA-Z]{2,}$");
        public Regex EmailAddressRegex = new Regex(@"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,})?$");

        public bool ValidateFirstName(string FirstName)
        {
            return FirstNameRegex.IsMatch(FirstName);
        }
        public bool ValidateLastName(string LastName)
        {
            return LastNameRegex.IsMatch(LastName);
        }
        public bool ValidateEmailAddress(string EmailAddress)
        {
            return EmailAddressRegex.IsMatch(EmailAddress);
        }

    }
}
