using MarsRover.App.Enums;
using MarsRover.App.Exceptions;
using MarsRover.App.Interfaces;
using MarsRover.App.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.App.Commands
{
    public class CommandM : ICommand
    {
        public void UpdatePosition(Position position)
        {
            switch (position.Direction)
            {
                case Direction.N:
                    if (position.Y == Plateau.UY) throw new PlateauBorderOverflowException();
                    position.Y += 1;
                    break;
                case Direction.E:
                    if (position.X == Plateau.UX) throw new PlateauBorderOverflowException();
                    position.X += 1;
                    break;
                case Direction.S:
                    if (position.Y == Plateau.LY) throw new PlateauBorderOverflowException();
                    position.Y -= 1;
                    break;
                case Direction.W:
                    if (position.X == Plateau.LX) throw new PlateauBorderOverflowException();
                    position.X -= 1;
                    break;
                default:
                    break;
            }
        }
    }
}
