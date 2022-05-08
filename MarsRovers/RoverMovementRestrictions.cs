using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRovers
{
    /// <summary>
    /// Restricts rover from movement.
    /// </summary>
    public class RoverMovementRestrictions : IRoverMovementRestrictions
    {
        /// <summary>
        /// Checks if the rover can move or not provided the instruction given
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="rover"> Rover object </param>
        /// <returns> True if rover can move and false if it can not </returns>
        public bool CanRoverMove(int x, int y, Rover rover)
        {
            if (IsNextGridOccupied(x, y, rover) || IsRoverInBorder(rover))
                return false;
            return true;
        }

        /// <summary>
        /// Checks if the next grid the current rover is intending move to is occupied by another rover or not.
        /// </summary>
        /// <param name="x"> x coordinate of the current rover </param>
        /// <param name="y"> y coordinate of the current rover </param>
        /// <param name="rover"> rover </param>
        /// <returns> True if grid is occupied and false if not. </returns>
        public bool IsNextGridOccupied(int x, int y, Rover rover)
        {
            if (Plateau.RoverOnPlateau.Count == 0)
                return false;

            switch (rover.Direction)
            {
                case "N":
                    y += 1;
                    break;
                case "E":
                    x += 1;
                    break;
                case "S":
                    y -= 1;
                    break;
                case "W":
                    x -= 1;
                    break;
                default:
                    throw new ArgumentException("The argument " + rover.Direction + " is not a valid direction");
            }

            foreach (Rover roverInPlateau in Plateau.RoverOnPlateau)
            {
                if (roverInPlateau.X == x && roverInPlateau.Y == y)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Checks rover position, if it's at the border of the plateau and facing a direction in which it can't move
        /// </summary>
        /// <param name="rover"> Rover object</param>
        /// <returns> True if rover can't move and false if it can move </returns>
        public bool IsRoverInBorder(Rover rover)
        {
            if (rover.X == Plateau.X && rover.Direction == "E")  // Rover is at the right border and facing right and cannot move forward
                return true;
            else if (rover.X == 0 && rover.Direction == "W") // Rover is at the left border and facing left and cannot move forward
                return true;
            else if (rover.Y == Plateau.Y && rover.Direction == "N") // Rover is at the top border and facing top and cannot move forward
                return true;
            else if (rover.Y == 0 && rover.Direction == "S") // Rover is at the top border and facing top and cannot move forward
                return true;
            else
                return false;
        }
    }
}
