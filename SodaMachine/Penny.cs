﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Penny:Coin
    {
        //Member Variables (Has A)

        //Constructor (Spawner)
        public Penny(string Name, double value) : base(Name, value)
        {
            Name = "Penny";
            value = 0.01;
        }
        //Member Methods (Can Do)
    }
}
