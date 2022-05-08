using MarsRovers;
using System;
using System.Collections.Generic;
using Xunit;

namespace MarsRoversTests
{
    public class CreateTest
    {
        private int _x;
        private int _y;
        private string _direction;
        private Create _create = new Create();
        private List<Rover> roversInPlateau;

        [Fact]
        public void CreatePlateau()
        {
            // arrange
            this._x = 6;
            this._y = 8;
            this.roversInPlateau = new List<Rover>();

            // act           
            _create.CreatePlateau(_x, _y, roversInPlateau);

            // assert
            Assert.Equal(6, Plateau.X);
            Assert.Equal(8, Plateau.Y);
            Assert.Empty(Plateau.RoverOnPlateau);
        }

        [Fact]
        public void CreateRover() 
        {
            // arrange
            this._x = 2;
            this._y = 3;
            this._direction = "N";
            Rover rover = new Rover();

            // act           
             rover = _create.CreateRover(_x, _y, _direction);

            // assert
            Assert.Equal(2, rover.X);
            Assert.Equal(3, rover.Y);
            Assert.Equal("N", rover.Direction);

        }

      //  public void IsPointInPlateau(int X, int Y) { }
    }
}
