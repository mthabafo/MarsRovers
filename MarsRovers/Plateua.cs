using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRovers
{
    /// <summary>
    /// Creates a plateau with cartesian coordinates and list of rovers on the plateau
    /// </summary>
    public static class Plateua
    {
        public static int X { get; set; }
        public static int Y { get; set; }
        public static List<Rover> RoverOnPlateau { get; set; }
    }
}
