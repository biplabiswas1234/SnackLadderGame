using System;

namespace SnackLadderGame
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to snake and ladder problem");
            SnakeAndLadder srating_Point = new SnakeAndLadder();
            int Position = srating_Point.StartPlay();
            RollingDie rollingDie = new RollingDie();
            int DiceNum = rollingDie.NumGenerator();
            int DiceUsed = 1;

            CheckForOptioncs checkForOptioncs = new CheckForOptioncs();
            checkForOptioncs.CheckingOption(ref DiceUsed, ref Position);
            Console.WriteLine("DIE is used {0} times:", DiceUsed);
            PlayerPositionTill_100 position100 = new PlayerPositionTill_100();
            Console.WriteLine("DIE is used {0} times:", DiceUsed);
            position100.Position100(ref DiceUsed, ref Position);
        }


    }
}

