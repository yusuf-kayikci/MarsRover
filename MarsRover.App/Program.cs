using MarsRover.App.Commands;
using MarsRover.App.Enums;
using MarsRover.App.Interfaces;
using MarsRover.App.Model;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace MarsRover.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddSingleton<ISpaceCompany, Nasa>();

            var serviceProvider = services.BuildServiceProvider();

            //Create space company
            var spaceCompany = serviceProvider.GetService<ISpaceCompany>();


            //Set plateau upper border
            Plateau.SetUpperCoordinate(5, 5);

            var position1 = new Position(1, 2, Direction.N);
            var position2 = new Position(3, 3, Direction.E);
            //Create rovers
            var rover1 = new Rover(position1);
            var rover2 = new Rover(position2);


            //Create messages
            var message1 = new Message("LMLMLMLMM");
            var message2 = new Message("MMRMMRMRRM");



            //Company start to listen for rover final position            
            spaceCompany.Subscribe(rover1);
            spaceCompany.Subscribe(rover2);

            //Rover start to move with inputs
            rover1.Move(message1);
            rover2.Move(message2);

            Console.ReadLine();
        }
    }
}
