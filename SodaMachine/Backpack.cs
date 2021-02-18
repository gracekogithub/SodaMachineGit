using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Backpack
    {
        //Member Variables (Has A)
        public List<Can> cans;
        public string inTheBackpack;
        //Constructor (Spawner)
        public Backpack()
        {
            cans = new List<Can>();
            inTheBackpack = "empty";
        }

        //Member Methods (Can Do)
        public void PutCanInTheBackpack() 
        {
            Console.WriteLine("I have");
        }

    }
}
