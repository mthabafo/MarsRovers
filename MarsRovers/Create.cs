using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRovers
{
    /// <summary>
    /// Create a new plateau and rover based on the input provided
    /// </summary>
    public class Create : ICreate
    {
        public void CreatePlateau(int X, int Y, List<Rover> roversInPlateau)
        {
            Plateau.X = X;
            Plateau.Y = Y;
            Plateau.RoverOnPlateau = roversInPlateau;
        }

        /// <summary>
        /// Creates a new rover
        /// </summary>
        /// <param name="X">X coordinate</param>
        /// <param name="Y">Y coordinate</param>
        /// <param name="direction"> Cardinal direction</param>
        /// <returns> a newly created rover object</returns>
        public Rover CreateRover(int X, int Y, string direction)
        {
            Rover rover = new Rover();

            if (IsPointInPlateau(X, Y))
            {
                rover.X = X;
                rover.Y = Y;
                rover.Direction = direction;

                return rover;
            }
            else
                throw new ArgumentException("The Points are out of range of the current plateau");

           // (X, Y) => { X >= 0 && X <= Plateua.X && Y >= 0 && Y <= Plateua.Y }
        }

        /// <summary>
        /// Checks if the points provided are within the Plateau
        /// </summary>
        /// <param name="X"> Point X</param>
        /// <param name="Y"> Point Y</param>
        /// <returns> True if the point is within the plateau or flase if not</returns>
        public bool IsPointInPlateau(int X, int Y)
        {
            if ((X >= 0 && X <= Plateau.X) && Y >= 0 && Y <= Plateau.Y)
                return true;
            return false;
        }
    }
}
