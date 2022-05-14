using System;
using System.Collections.Generic;
using System.Text;

namespace SnackLadderGame
{
    internal class PositionAndDiceNumFirstTime
    {
        public void CheckPositionDiceNum(ref int DiceUsed, ref int Position)
        {


            SnakeAndLadder starting_Point = new SnakeAndLadder();
            Position = starting_Point.StartPlay();
            RollingDie rollingDie = new RollingDie();
            int DiceNum = rollingDie.NumGenerator();
            DiceUsed = 1;

            CheckForOptioncs checkForOptioncs = new CheckForOptioncs();
            checkForOptioncs.CheckingOption(ref DiceUsed, ref Position);
        }
    }
}
