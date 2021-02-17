using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Can
    {
        //Member Variables (Has A)
        protected double price;
        public string Name;

        public double Price
        { 
            get 
            {
                return price;
            }
        }
        
        //Constructor (Spawner)
        public Can(string name, double price)
        {
            Name = name;
            this.price = price;
        }
        //Member Methods (Can Do)
    }
}
