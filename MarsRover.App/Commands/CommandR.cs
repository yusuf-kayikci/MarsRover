using MarsRover.App.Extentions;
using MarsRover.App.Interfaces;
using MarsRover.App.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.App.Commands
{
    public class CommandR : ICommand
    {
        public void UpdatePosition(Position position)
        {
            position.Direction = position.Direction.GetNext();
        }
    }
}
