using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Cola:Can
    {
        //Member Variables (Has A)

        //Constructor (Spawner)
        public Cola(string name, double value) :base(name, value)
        {
            Name = "Cola";
            price = 0.50;
        }

        //Member Methods (Can Do)
    }
}
