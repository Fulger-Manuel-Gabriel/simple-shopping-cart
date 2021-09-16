using System;

namespace SchoolOf.Common.Exceptions
{
    public class InvalidParameterException : Exception
    {
        public InvalidParameterException(string message) : base(message)
        {

        }
    }
}
