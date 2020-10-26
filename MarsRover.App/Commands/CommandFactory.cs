using MarsRover.App.Enums;
using MarsRover.App.Exceptions;
using MarsRover.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.App.Commands
{
    public class CommandFactory
    {
        public static ICommand Create(MovementType movementType)
        {
            switch (movementType)
            {                
                case MovementType.L:
                    return new CommandL();
                case MovementType.R:
                    return new CommandR();
                case MovementType.M:
                    return new CommandM();
                default:
                    throw new InvalidMovementException();
            }
        }
    }
}
