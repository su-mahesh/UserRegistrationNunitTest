using System;
using System.Text.RegularExpressions;

namespace UserRegistrationNameSpace
{
    public class UserRegistrationRegex
    {
        public Regex FirstNameRegex = new Regex(@"^[A-Z][a-z]{2,}$");

        public bool ValidateFirstName(string FirstName)
        {
            return FirstNameRegex.IsMatch(FirstName);
        }

    }
}
