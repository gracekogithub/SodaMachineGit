using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Coin
    {
        //Member Variables (Has A)
        protected double value;
        public string Name;
        
        
        public double Value
        {
            get
            {
                return value;
            }
            
        }
        //Constructor (Spawner)
        public Coin(string Name, double value)
        {
            this.Name = Name;
            this.value = value;
            
            
        }
        //Member Methods (Can Do)
        
    }
}
