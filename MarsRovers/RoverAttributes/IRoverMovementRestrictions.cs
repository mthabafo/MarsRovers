using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRovers
{
    public interface IRoverMovementRestrictions
    {
        bool IsRoverInBoundary(Rover rover);
        bool IsNextGridOccupied(int x, int y, Rover rover);
        bool CanRoverMove(int x, int y, Rover rover);
    }
}
