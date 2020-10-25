using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.App.Exceptions
{
    public class InvalidMovementException : Exception
    {
        private const string exceptionMessage = "Invalid command.Comamnd letter must be L,R or M";
        public InvalidMovementException() : base(exceptionMessage)
        {
        }
    }
}
