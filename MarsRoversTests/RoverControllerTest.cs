using MarsRovers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRoversTests
{
    public class RoverControllerTest
    {
        private Rover _initalRoverPosition = new Rover();
        private Rover _finalRoverPosition = new Rover();
        private RoverController _roverController = new RoverController();

        [Fact]
        public void MoveRover_InitialPositonAndInstruction_FinalPosition() 
        {
            // arrange
            Plateau.X = 5;
            Plateau.Y = 5;
            Plateau.RoverOnPlateau = new List<Rover>();
            _initalRoverPosition.X = 1;
            _initalRoverPosition.Y = 2;
            _initalRoverPosition.Direction = "N";
            Rover newRoverPosition = new Rover();

            _finalRoverPosition.X = 1;
            _finalRoverPosition.Y = 3;
            _finalRoverPosition.Direction = "N";

            string instruction = "LMLMLMLMM";

            // act
            newRoverPosition = _roverController.MoveRover(instruction, _initalRoverPosition);

            // assert
            Assert.Equal(_finalRoverPosition.X, newRoverPosition.X);
            Assert.Equal(_finalRoverPosition.Y, newRoverPosition.Y);
            Assert.Equal(_finalRoverPosition.Direction, newRoverPosition.Direction);
        }
    }
}
