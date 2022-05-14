using System;
using System.Collections.Generic;
using System.Text;

namespace SnackLadderGame
{
    internal class Player2Performs
    {
        public void Player2(ref int DiceUsed2, ref int Position2)
        {

            for (int i = 0; i < 1; i++)
            {
                int LadderNum = 1;
                //int a = 1;
                if (Position2 < 100)
                {
                    //a++;
                    Random Play = new Random();
                    int Temp = 1;
                    int GenNumber = Play.Next(1, 7);
                    DiceUsed2++;
                    Console.WriteLine("Generated number: " + GenNumber);
                    int Temporary = GenNumber;
                    int CheckNum = Play.Next(0, 3);
                    Console.WriteLine("You got Checking option number: " + CheckNum);

                    switch (CheckNum)
                    {
                        case 0:
                            Console.WriteLine("No Play");
                            Console.WriteLine("Your position is still in: " + Position2);
                            break;
                        case 1:
                            Position2 += GenNumber;
                            if (Position2 > 100)
                            {
                                Position2 -= GenNumber;
                                Temp = 0;
                                Console.WriteLine("Going ahead by Ladder:" + Position2);

                            }
                            else
                            {
                                Console.WriteLine("Going ahead by Ladder:" + Position2);
                            }
                            break;
                        default:
                            Position2 -= GenNumber;
                            if (Position2 < 0)
                            {
                                Position2 = 0;
                            }
                            Console.WriteLine("Snake bites and your position:" + Position2);
                            break;
                    }
                    if (LadderNum == GenNumber )
                    {
                        int GenNumber1 = Play.Next(1, 7);
                        DiceUsed2++;
                        Console.WriteLine("Generated number due to LADDER: " + GenNumber1);
                        int CheckNum2 = Play.Next(0, 3);
                        Console.WriteLine("You got Checking option number: " + CheckNum2);
                        Console.WriteLine("You got a LADDER number and generates a number: " + CheckNum2);


                        switch (CheckNum2)
                        {
                            case 0:
                                Console.WriteLine("No Play");
                                Console.WriteLine("Your position is still in: " + Position2);
                                break;
                            case 1:
                                Position2 += GenNumber;
                                if (Position2 > 100)
                                {
                                    Position2 -= GenNumber;
                                    Temp = 0;
                                    Console.WriteLine("Going ahead by Ladder:" + Position2);

                                }
                                else
                                {
                                    Console.WriteLine("Going ahead by Ladder:" + Position2);
                                }
                                break;
                            default:
                                Position2 -= GenNumber;
                                if (Position2 < 0)
                                {
                                    Position2 = 0;
                                }
                                Console.WriteLine("Snake bites and your position:" + Position2);
                                break;
                        }

                    }
                    if (Temp == 0)
                        break;
                }
                if (Position2 == 100)

                {
                    //Console.WriteLine("a is used {0} times:", a);
                    Console.WriteLine("Die is used {0} times:", DiceUsed2);
                    Console.WriteLine("Congratulation! You WON");

                }
            }
        }
    }
}