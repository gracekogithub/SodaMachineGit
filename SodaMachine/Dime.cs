﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Dime : Coin
    {
        //Member Variables (Has A)

        //Constructor (Spawner)
        public Dime(string Name, double value) : base (Name, value)
        {
            Name = "Dime";
            value = 0.10;
        }

        //Member Methods (Can Do)
    }
}
