using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRovers
{
    public interface IRoverActions
    {
        void RotateLeft(Rover rover);
        void RotateRight(Rover rover);
        void MoveForward(Rover rover);
    }
}
