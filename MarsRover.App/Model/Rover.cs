using MarsRover.App.Commands;
using MarsRover.App.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.App.Model
{
    public class Rover
    {
        private Position _position;

        public Rover(Position position)
        {
            _position = position;
        }

        public delegate void Notify(Position position);

        public event Notify OnStop;


        public void Move(Message m)
        {
            for (int i = 0; i < m.CommandCount; i++)
            {
                m.SetNextLetter();
                CommandFactory.Create(m.nextMovement).UpdatePosition(_position);
            }
            OnStop(_position);

        }

        public string GetFinalPosition()
        {
            return $"{_position.X} {_position.Y} {_position.Direction}";
        }





    }
}
