﻿using System;
using System.Text.RegularExpressions;

namespace UserRegistrationNameSpace
{
    public class UserRegistrationRegex
    {
        public static Regex FirstNameRegex = new Regex(@"^[A-Z][a-z]{2,}$");
        public static Regex LastNameRegex = new Regex(@"^[A-Z][a-zA-Z]{2,}$");
        public static Regex EmailAddressRegex = new Regex(@"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,})?$");
        public static Regex MobileNumberRegex = new Regex(@"^[0-9]{2,3}\s[1-9][0-9]{9}$");
        public static Regex PasswordRegex = new Regex(@"^(?=.{8,20}$)(?=.*[\d])(?=.*[A-Z])[\w]*[\W][\w]*$");

        Func<string, Regex, bool> IsValid = (field, reg) => reg.IsMatch(field);

        public bool ValidateFirstName(string FirstName)
        {
            try
            {
                if (!IsValid(FirstName, FirstNameRegex))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRST_NAME, "invalid first name");
                return FirstNameRegex.IsMatch(FirstName);

            }
            catch (ArgumentNullException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERD_NULL, "entered null");
            }
            
        }
        public bool ValidateLastName(string LastName)
        {
            try
            {
                if (!IsValid(LastName, LastNameRegex))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LAST_NAME, "invalid last name");
                return LastNameRegex.IsMatch(LastName);
            }
            catch (ArgumentNullException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERD_NULL, "entered null");
            }
            
        }
        public bool ValidateEmailAddress(string EmailAddress)
        {
            try
            {
                if (!IsValid(EmailAddress, EmailAddressRegex))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "invalid email");
                return EmailAddressRegex.IsMatch(EmailAddress);

            }
            catch (ArgumentNullException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERD_NULL, "entered null");
            }
          
        }
        public bool ValidateMobileNumber(string MobileNumber)
        {
            try
            {
                if (!IsValid(MobileNumber, MobileNumberRegex))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILE_NUMBER, "invalid mobile number");
                return MobileNumberRegex.IsMatch(MobileNumber);
            }
            catch (ArgumentNullException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERD_NULL, "entered null");
            }

        }
        public bool ValidatePassword(string Password)
        {
            try
            {
                if (!IsValid(Password, PasswordRegex))
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "invalid password");
                return PasswordRegex.IsMatch(Password);
            }
            catch (ArgumentNullException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.ENTERD_NULL, "entered null");
            }            
        }
    }
}
