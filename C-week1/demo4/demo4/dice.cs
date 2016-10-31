﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4
{
    public class Dice
    {
        public static Random RandomGenerator { get; set; }
        public int Result { get; set; }
        public int Choice { get; set; }
        public bool Success { get; set; }

        public Dice()
        {
            RandomGenerator = new Random();
        }
        public void Throw()
        {
            Result = RandomGenerator.Next(1, 7);
        }
        public void Check(int Number)
        {
            if (Number == Result)
            {
                Success = true;
            }
            else
            {
                Success = false;
            }
        }
    }
}
