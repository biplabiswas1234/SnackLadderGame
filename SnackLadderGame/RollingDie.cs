﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnackLadderGame
{
    internal class RollingDie
    {
        public int NumGenerator()
        {
            Random LudoNum = new Random();  
            int Num = LudoNum.Next(1,7);
            Console.WriteLine("\nYou got Die number: " +Num);
            return Num;
        }
    }
}
