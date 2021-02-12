using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace UserRegistrationNameSpace
{
    public class UserRegistrationRegex
    {
        public Regex FirstNameRegex = new Regex(@"^[A-Z][a-z]{2,}$");
        public Regex LastNameRegex = new Regex(@"^[A-Z][a-zA-Z]{2,}$");
        public Regex EmailAddressRegex = new Regex(@"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,})?$");
        public Regex MobileNumberRegex = new Regex(@"^[0-9]{2,3}\s[1-9][0-9]{9}$");
        public Regex PasswordRegex = new Regex(@"^(?=.{8,20}$)(?=.*[\d])(?=.*[A-Z])[\w]*[\W][\w]*$");

        public bool ValidateFirstName(string FirstName)
        {
            try
            {
                if (FirstName.Equals(string.Empty))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_EMPTY, "first name should not be empty");
                if (FirstName.Any(Char.IsDigit))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_DIGIT_IN_NAME, "first name should not contain digits");
                if (FirstName.Length < 3)
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_LESSTHAN_MINIMUM_LENGTH, "first name should not be less than minimum length");
                return FirstNameRegex.IsMatch(FirstName);

            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_NULL, "first name should not be null");
            }
            
        }
        public bool ValidateLastName(string LastName)
        {
            try
            {
                if (LastName.Equals(string.Empty))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_EMPTY, "last name should not be empty");
                if (LastName.Any(Char.IsDigit))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_DIGIT_IN_NAME, "last name should not contain digits");
                if (LastName.Length < 3)
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_LESSTHAN_MINIMUM_LENGTH, "last name should not be less than minimum length");
                return LastNameRegex.IsMatch(LastName);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_NULL, "last name should not be null");
            }            
        }
        public bool ValidateEmailAddress(string EmailAddress)
        {
            try
            {
                if (EmailAddress.Equals(string.Empty))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_EMPTY, "email address should not be empty");

                string Username = EmailAddress.Substring(0, 1);
                if (Username.Any(Char.IsPunctuation))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_INVALID_EMAIL_USERNAME, "email address username should not start with spacial character");
                 if (EmailAddress.Length < 6)
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_LESSTHAN_MINIMUM_LENGTH, "email address should not be less than minimum lengthe");
                string Country_Tld = EmailAddress.Substring(EmailAddress.LastIndexOf(".") + 1);
                if (Country_Tld.Any(Char.IsDigit))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_DIGIT_IN_COUNTRY_TLD, "email address country tld should not contain spacial characters");

                string tld = EmailAddress.Substring(EmailAddress.LastIndexOf("@") + 1, EmailAddress.Substring(EmailAddress.LastIndexOf("@") + 1).IndexOf("."));
                if (tld.Any(Char.IsPunctuation))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_INVALID_EMAIL_TLD, "email address tld should not be contain special characters");
                return EmailAddressRegex.IsMatch(EmailAddress);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_NULL, "email address should not be null");
            }
        }
        public bool ValidateMobileNumber(string MobileNumber)
        {
            try
            {
                if (MobileNumber.Length.Equals(0))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_EMPTY, "mobile number should not be empty");
                if (MobileNumber.Length < 13)
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_LESSTHAN_MINIMUM_LENGTH, "mobile number should not be less than minimum length");
                return LastNameRegex.IsMatch(MobileNumber);
            }
            catch (NullReferenceException)
            { 
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_NULL, "mobile number should not be null");
            }
        }
        public bool ValidatePassword(string Password)
        {
            try
            {
                if (Password.Length.Equals(0))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_EMPTY, "password should not be empty");
                if (Password.Length < 8)
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_LESSTHAN_MINIMUM_LENGTH, "password should not be less than minimum lengthe");
                return LastNameRegex.IsMatch(Password);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERED_NULL, "password should not be null");
            }           
        }
    }
}
