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
            Assert.Equal(_finalRoverPosition, newRoverPosition);
        }
    }
}
