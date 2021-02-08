using System;
using System.Text.RegularExpressions;

namespace UserRegistrationNameSpace
{
    public class UserRegistrationRegex
    {
        public Regex FirstNameRegex = new Regex(@"^[A-Z][a-z]{2,}$");
        public Regex LastNameRegex = new Regex(@"^[A-Z][a-zA-Z]{2,}$");
        public Regex EmailAddressRegex = new Regex(@"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,})?$");
        public Regex MobileNumberRegex = new Regex(@"^[0-9]{2,3}\s[1-9][0-9]{9}$");
        public Regex PasswordRegex = new Regex(@"^(?=.*[A-Z])(?=.*[0-9]).{8,}$");

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
        public bool ValidateMobileNumber(string MobileNumber)
        {
            return MobileNumberRegex.IsMatch(MobileNumber);
        }

        public bool ValidatePassword(string Password)
        {
            return PasswordRegex.IsMatch(Password);
        }
    }
}
