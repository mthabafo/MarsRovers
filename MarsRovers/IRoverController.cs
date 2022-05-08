using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRovers
{
    /// <summary>
    /// Controls the rover movement, by taking and processing input, executing instructions and displaying output
    /// </summary>
    public interface IRoverController
    {
        void ProcessInput();
        Rover ExecuteInstructions(string instruction, Rover rover);
        void DisplayOutput(string initialPosistion, string finalPosition);
    }
}
