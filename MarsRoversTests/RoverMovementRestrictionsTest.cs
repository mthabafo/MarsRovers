using MarsRovers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRoversTests
{
    public class RoverMovementRestrictionsTest
    {
        private Rover _rover;
        private Rover _roverInPlateau;
        private RoverMovementRestrictions _roverMovementRestrictions = new RoverMovementRestrictions();
        private List<Rover> _roversInPlateau;

        [Fact]
        public void IsRoverInBorder() 
        {
            // arrange 
            _rover = new Rover();
            Plateau.X = 3;
            Plateau.Y = 2;
            _rover.X = 3;
            _rover.Y = 1;
            _rover.Direction = "E";

            // act
            bool isInBorder = _roverMovementRestrictions.IsRoverInBorder(_rover);

            // assert
            Assert.True(isInBorder);
        }

        [Fact]
        public void IsNextGridOccupied() 
        {
            // arrange

            _roversInPlateau = new List<Rover>();
            Rover rover = new Rover();
            _roverInPlateau = new Rover();

            _roverInPlateau.X = 2;
            _roverInPlateau.Y = 1;
            _roverInPlateau.Direction = "N";
            _roversInPlateau.Add(_roverInPlateau);

            rover.X = 1;
            rover.Y = 1;
            rover.Direction = "E";

            // act
            bool gridOccupied = _roverMovementRestrictions.IsNextGridOccupied(rover.X, rover.Y, rover);

            // assert
            Assert.True(gridOccupied);
        }
      
        [Fact]
        public void CanRoverMove() 
        {
        }
    }
}
