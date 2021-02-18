using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class RootBeer:Can
    {
        //Member Variables (Has A)

        //Constructor (Spawner)
        public RootBeer(string Name, double price) : base(Name, price)
        {
            Name = "Root Beer";
            price = 0.30;
        }
        //Member Methods (Can Do)
    }
}
