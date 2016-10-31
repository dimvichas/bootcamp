﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    public class Dice
    {
        public Random r { get; set; }
        public int Result { get; set; }
        public int Choice { get; set; }
        public bool Success { get; set; }

        public Dice()
        {
            r = new Random();
        }
        public void Throw(int Number)
        {
            Choice = Number;
            Result = r.Next(1, 7);
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
