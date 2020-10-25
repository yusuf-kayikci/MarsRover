using MarsRover.App.Enums;
using MarsRover.App.Extentions;
using MarsRover.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.App.Model
{
    public class Position
    {
        public int X { get; internal set; }
        public int Y { get; internal set; }
        public Direction Direction { get;internal set; }
        public Position(int x ,int y , Direction direction)
        {
            X = x;
            Y = y;
            Direction = direction;

        }
    }
}
