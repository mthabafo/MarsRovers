using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRovers
{
    /// <summary>
    /// A rover has on plateau has (x, y) coordinates as well as cardinal direction
    /// </summary>
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Direction { get; set; }

        public Rover() 
        {
            X = 0;
            Y = 0;
            Direction = "N";
        }
    }
}
