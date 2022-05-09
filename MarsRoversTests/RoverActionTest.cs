using MarsRovers;
using System;
using Xunit;

namespace MarsRoversTests
{
    public class RoverActionTest
    {
        private Rover _rover = new Rover();
        private MarsRovers.RoverActions _roverAction = new MarsRovers.RoverActions();

        [Fact]
        public void RotateLeft_InitialDirection_FinalDirection()
        {
            // arrange
            _rover.X = 1;
            _rover.Y = 2;
            _rover.Direction = "N";

            // act           
            _roverAction.RotateLeft(_rover);

            // assert
            Assert.Equal("W", _rover.Direction);
        }

        [Fact]
        public void RotateRight_InitialDirection_FinalDirection()
        {
            // arrange
            _rover.X = 1;
            _rover.Y = 2;
            _rover.Direction = "N";

            // act
            _roverAction.RotateRight(_rover);

            // assert
            Assert.Equal("E", _rover.Direction);
        }

        [Fact]
        public void MoveForward_InitialPosition_FinalPosition()
        {
            // arrange
            _rover.X = 1;
            _rover.Y = 2;
            _rover.Direction = "N";

            // act
            _roverAction.MoveForward(_rover);

            // assert
            Assert.Equal(3, _rover.Y);
        }
    }
}
