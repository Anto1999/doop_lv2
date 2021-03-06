﻿using System;

namespace doop_lv2_
{
    class Die
    {
        private int sidesCount;
        private Random random;
        public Die(int sidesCount)
        {
            this.sidesCount = sidesCount;
            random = new Random();
        }
        public int Roll(int sidesCount)
        {
            return random.Next(1, sidesCount + 1);
        }
        static void Main(string[] args)
        {
            DiceRoller roller = new DiceRoller();
            Die dice = new Die(6);
            for (int i = 0; i < 20; i++)
            {
                roller.InsertDie(dice);
                dice.Roll(6);
                Console.Write(dice.Roll(6) + " ");
            }
        }
    }
}
