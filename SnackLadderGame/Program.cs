using System;

namespace SnackLadderGame
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to snake and ladder problem");
            //SnakeAndLadder starting_Point = new SnakeAndLadder();
            //int Player1Position = starting_Point.StartPlay();
            //int Player2Position = starting_Point.StartPlay();
            //RollingDie rollingDie = new RollingDie();
            //int DiceNum = rollingDie.NumGenerator();
            //int DiceUsed = 1;

            //CheckForOptioncs checkForOptioncs = new CheckForOptioncs();
            //checkForOptioncs.CheckingOption(ref DiceUsed, ref Position);

            //PositionAndDiceNumFirstTime firstTime = new PositionAndDiceNumFirstTime();
            //firstTime.CheckPositionDiceNum();
            //Console.WriteLine("DIE is used {0} times:", DiceUsed);
            //PlayerPositionTill_100 position100 = new PlayerPositionTill_100();
            //Console.WriteLine("DIE is used {0} times:", DiceUsed);
            //position100.Position100(ref DiceUsed, ref Position);

            int DiceUsed1 = 0; 
            int Position1 = 0;
            int DiceUsed2 = 0;
            int Position2 = 0;
            PositionAndDiceNumFirstTime player1= new PositionAndDiceNumFirstTime();
            PositionAndDiceNumFirstTime player2 = new PositionAndDiceNumFirstTime();
            for (int i = 0; i < 1; i++)
            {
                player1.CheckPositionDiceNum(ref DiceUsed1, ref Position1);
                player2.CheckPositionDiceNum(ref DiceUsed2, ref Position2);
            }
            Console.WriteLine("Position1 :" + Position1);
            Console.WriteLine("Position2 :" + Position2);

            while (Position1 != 100 && Position2 != 100)
            {   
                Console.WriteLine("player:1-----------------------------------------------");
                Player1Performs player_1 = new Player1Performs();
                Player2Performs player_2 = new Player2Performs();
                player_1.Player1(ref DiceUsed1, ref Position1);
                Console.WriteLine("Player1 used Dice {0} times", DiceUsed1);
                Console.WriteLine("Player1 position:" +Position1);
                Console.WriteLine("Player:2...............................................");
                player_2.Player2(ref DiceUsed2, ref Position2);
                Console.WriteLine("Player2 used Dice {0} times", DiceUsed2);
                Console.WriteLine("Player2 position:" +Position2);


            }
            if ( Position1>Position2)
            {
                Console.WriteLine("\nPlayer1 used Dice {0} times", DiceUsed1);
                Console.WriteLine("Player2 used Dice {0} times", DiceUsed2);
                Console.WriteLine("Player1 won the Game");

            }
            else if ( Position2>Position1)
            {
                Console.WriteLine("\nPlayer1 used Dice {0} times", DiceUsed1);
                Console.WriteLine("Player2 used Dice {0} times", DiceUsed2);
                Console.WriteLine("Player2 won the Game");


            }
            
        }


    }
}

