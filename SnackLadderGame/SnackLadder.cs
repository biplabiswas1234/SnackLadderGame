using System;
using System.Collections.Generic;
using System.Text;

namespace SnackLadderGame
{

    internal class SnakeAndLadder
    {
        public int StartingPoint = 0;
        public int StartPlay()
        {

            Console.WriteLine("Starting Position: " + StartingPoint);
            return StartingPoint;
        }
    }

}