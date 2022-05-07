using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRovers
{
    public interface ICreate
    {
        void CreatePlateau(int X, int Y, List<Rover> roversInPlateau);
        Rover CreateRover(int X, int Y, string direction);
        bool IsPointInPlateau(int X, int Y);
    }
}
