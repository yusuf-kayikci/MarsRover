using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.App.Exceptions
{
    public class PlateauBorderOverflowException : Exception
    {
        private static string exceptionMessage = "Invalid command.Plateau border overflow."; 
        public PlateauBorderOverflowException() : base(exceptionMessage)
        {
        }
    }
}
