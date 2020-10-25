using MarsRover.App.Enums;
using MarsRover.App.Interfaces;
using MarsRover.App.Model;
using NUnit.Framework;

namespace MarsRover.Test
{
    public class MarsRoverTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void initialposition_12N_message_LMLMLMLMM_finalposition_13N()
        {
            Plateau.SetUpperCoordinate(5, 5);
            ISpaceCompany company = new Nasa();
            var rover = new Rover(new Position(1, 2, Direction.N));
            company.Subscribe(rover);
            var message = new Message("LMLMLMLMM");
            rover.Move(message);
            var finalPositionOfRover = rover.GetFinalPosition();
            var expectedResult = "1 3 N";
            Assert.AreEqual(expectedResult, finalPositionOfRover);
        }

        [Test]
        public void initialposition_33E_message_MMRMMRMRRM_finalposition_51E()
        {
            Plateau.SetUpperCoordinate(5, 5);
            ISpaceCompany company = new Nasa();
            var rover = new Rover(new Position(3, 3, Direction.E));
            company.Subscribe(rover);
            var message = new Message("MMRMMRMRRM");
            rover.Move(message);
            var finalPositionOfRover = rover.GetFinalPosition();
            var expectedResult = "5 1 E";
            Assert.AreEqual(expectedResult , finalPositionOfRover);
        }

    }
}