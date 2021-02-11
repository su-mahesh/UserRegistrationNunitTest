using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationNameSpace
{
    public class UserRegistrationException: Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_EMAIL,
            INVALID_PASSWORD,
            INVALID_MOBILE_NUMBER,
            ENTERD_NULL
        }
        public ExceptionType exceptionType;
        public UserRegistrationException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
