using MarsRover.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.App.Model
{
    public class Nasa : ISpaceCompany
    {

        public void Subscribe(Rover rover)
        {
            rover.OnStop += Rover_OnStop;
        }

        private void Rover_OnStop(Position position)
        {
            Console.WriteLine($"{position.X} {position.Y} {position.Direction}");
        }
    }
}
