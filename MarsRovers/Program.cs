using System;

namespace MarsRovers
{
    public class Program
    {
        static void Main(string[] args)
        {
            RoverController roverController = new RoverController();
            roverController.ProcessInput();
        }
    }
}
