using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MarsRovers
{
    /// <summary>
    /// Controls the rover movement, by taking and processing input, executing instructions and displaying output.
    /// </summary>
    public class RoverController : IRoverController
    {
        private Create _create = new Create();
        private Rover _rover;


        /// <summary>
        /// Reads input from a text file and controls the rover movement using helper functions 
        /// </summary>
        public void ProcessInput()
        {
             string textFile = @"C:\MarsRoversInstructions\Instructions.txt";

            if (File.Exists(textFile))
            {
                string[] lines = File.ReadAllLines(textFile);
                int roverNumber = 0;

                for (int i = 0; i < lines.Length; i++)
                {
                    if (i == 0) // The first line of input is Plateau coordinates
                    {
                        int x = int.Parse(lines[i].Split(" ")[0]);
                        int y = int.Parse(lines[i].Split(" ")[1]);

                        _create.CreatePlateau(x, y, new List<Rover>());
                    }
                    else if (i != 0 && i % 2 == 1) // Every odd line of input is Rover coordinates
                    {
                        int x = int.Parse(lines[i].Split(" ")[0]);
                        int y = int.Parse(lines[i].Split(" ")[1]);
                        string direction = lines[i].Split(" ")[2];

                        _rover = _create.CreateRover(x, y, direction);
                    }
                    else if(i % 2 == 0) // Every even line of input is execution of instructions
                    { 
                        string instruction = lines[i].ToString();

                        Console.WriteLine(String.Format("Rover {0}", ++roverNumber));
                        Console.WriteLine(String.Format("Initial position: {0} {1} {2}", _rover.X, _rover.Y, _rover.Direction));

                        Rover newRoverPosition = ExecuteInstructions(instruction, _rover);
                       
                        Console.WriteLine(String.Format("Final position: {0} {1} {2}", newRoverPosition.X, newRoverPosition.Y, newRoverPosition.Direction));

                        Plateau.RoverOnPlateau.Add(newRoverPosition);
                    }
                }
            }
            else
                throw new FileLoadException();
        }

        /// <summary>
        /// Moves the rover 
        /// </summary>
        /// <param name="instruction"> Instruction to control the rover </param>
        /// <param name="rover"> Initial position of the rover</param>
        /// <returns> Final position of the rover </returns>
        public Rover ExecuteInstructions(string instruction, Rover rover)
        {
            RoverActions roverActions = new RoverActions();
            RoverMovementRestrictions roverMovementRestrictions = new RoverMovementRestrictions();
            
            char[] commands = instruction.ToCharArray();
          
            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case 'L':
                        roverActions.RotateLeft(rover);
                        break;
                    case 'R':
                        roverActions.RotateRight(rover);
                        break;
                    case 'M':
                        if (roverMovementRestrictions.CanRoverMove(rover.X, rover.Y, rover))
                            roverActions.MoveForward(rover);
                        break;
                    default:
                        break;
                }
            }

            return rover;        
        }
 
        public void DisplayOutput(string initialPosistion, string finalPosition)
        {
            throw new NotImplementedException();
        }


    }
}
