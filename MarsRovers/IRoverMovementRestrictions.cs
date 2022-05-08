using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRovers
{
    public interface IRoverMovementRestrictions
    {
        bool IsRoverInBorder(Rover rover);
        bool IsNextGridOccupied(int x, int y, Rover rover);
        bool CanRoverMove(int x, int y, Rover rover);
    }
}
