using System;
using System.Collections.Generic;
using System.Text;

namespace SnackLadderGame
{
    internal class PlayerPositionTill_100
    {

        public void Position100(ref int DiceUsed, ref int Position)
        {
          for( int i= 0;i <1;i++ )
           { 
            //int a = 1;
            if (Position < 100)
            {
                //a++;
                Random Play = new Random(); 
                int Temp = 1;
                int GenNumber = Play.Next(1, 7);
                DiceUsed++;
                Console.WriteLine("\nGenerated number: " + GenNumber);
                int Temporary= GenNumber;
                int CheckNum = Play.Next(0, 3);
                Console.WriteLine("\nYou got Checking option number: " + CheckNum);
            
            switch (CheckNum)
            {
                case 0:
                    Console.WriteLine("No Play");
                        Console.WriteLine("Your position is still in: " + Position);
                        break;
                case 1:
                    Position += GenNumber;
                        if (Position > 100)
                        {
                            Position -= GenNumber;
                            Temp = 0;
                            Console.WriteLine("Going ahead by Ladder:" + Position);

                        }
                        else
                        {
                            Console.WriteLine("Going ahead by Ladder:" + Position);
                        }
                        break;
                default:
                    Position -= GenNumber;
                        if (Position < 0)
                        {
                            Position = 0;
                        }
                        Console.WriteLine("Snake bites and your position:" + Position);
                    break;
                


            }
            if(Temp == 0)
            break;
            }

           if (Position == 100)

                {
                    //Console.WriteLine("a is used {0} times:", a);
                    Console.WriteLine("Die is used {0} times:", DiceUsed);
                    Console.WriteLine("Congratulation! You WON");

                }

           
          }     
        }
    }
}
