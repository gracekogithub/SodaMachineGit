using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Nickel:Coin
    {
        //Member Variables (Has A)

        //Constructor (Spawner)
        public Nickel(string Name, double value) :base (Name, value)
        {
            Name = "Nickel";
            value = 0.05;
        }
        //Member Methods (Can Do)
    }
}
