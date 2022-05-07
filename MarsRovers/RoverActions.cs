using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRovers
{
    /// <summary>
    /// Defines the actions of a rover, every rover must be able to perform these actions
    /// </summary>
    public class RoverActions : IRoverActions
    {
        /// <summary>
        /// Turns a rover 90 degrees left
        /// </summary>
        /// <param name="rover">Rover object</param>
        public void RotateLeft(Rover rover)
        {
            switch (rover.Direction)
            {
                case "N":
                    rover.Direction = "W";
                    break;
                case "E":
                    rover.Direction = "N";
                    break;
                case "S":
                    rover.Direction = "E";
                    break;
                case "W":
                    rover.Direction = "S";
                    break;
                default:
                    throw new ArgumentException("The argument " + rover.Direction + " is not a valid direction");
            }
        }

        /// <summary>
        /// Turns a rover 90 degrees right
        /// </summary>
        /// <param name="rover">Rover object</param>
        public void RotateRight(Rover rover)
        {
            switch (rover.Direction)
            {
                case "N":
                    rover.Direction = "E";
                    break;
                case "E":
                    rover.Direction = "S";
                    break;
                case "S":
                    rover.Direction = "W";
                    break;
                case "W":
                    rover.Direction = "N";
                    break;
                default:
                    throw new ArgumentException("The argument " + rover.Direction + " is not a valid direction");
            }
        }

        /// <summary>
        /// Moves a rover a rover to the next grid it is facing
        /// </summary>
        /// <param name="rover">Rover object</param>
        public void MoveForward(Rover rover)
        {
            switch (rover.Direction)
            {
                case "N":
                    rover.Y += 1;
                    break;
                case "E":
                    rover.X += 1;
                    break;
                case "S":
                    rover.Y -= 1;
                    break;
                case "W":
                    rover.X -= 1;
                    break;
                default:
                    throw new ArgumentException("The argument " + rover.Direction + " is not a valid direction");
            }
        }
    }
}
