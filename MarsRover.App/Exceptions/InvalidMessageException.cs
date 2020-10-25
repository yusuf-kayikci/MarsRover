using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.App.Exceptions
{
    public class InvalidMessageException : Exception
    {
        private const string exceptionMessage = "Invalid message";
        public InvalidMessageException(Exception innerException) : base(exceptionMessage, innerException)
        {
        }
    }
}
