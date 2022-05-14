using System;

namespace SnackLadderGame
{
    internal class Program
    {
       
            static void Main(string[] args)
            {

                Console.WriteLine("Welcome to snake and ladder problem");
                SnakeAndLadder srating_Point = new SnakeAndLadder();
                int StartPoint = srating_Point.StartPlay();
                RollingDie rollingDie = new RollingDie();
                int DiceNum=rollingDie.NumGenerator();
                CheckForOptioncs checkForOptioncs = new CheckForOptioncs();
                checkForOptioncs.CheckingOption(DiceNum,StartPoint);
            }

    }
}

