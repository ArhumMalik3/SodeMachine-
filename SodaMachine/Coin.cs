using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    abstract class Coin
    {
        protected double value;

        //property
        public double Value
        {
            get
            {
                return value;
            }
        }
        public string name;

        public Coin()
        {

        }
    }
}
