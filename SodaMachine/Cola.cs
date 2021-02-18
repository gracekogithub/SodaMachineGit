using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Cola : Can
    {
        //Member Variables (Has A)

        //Constructor (Spawner)
        public Cola(string Name, double price) : base(Name, price)
        {
            Name = "Cola";
            price = 0.50;
        }

        //Member Methods (Can Do)
    }
}
