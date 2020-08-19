using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    abstract class Can
    {
        //member variable
        protected double cost;

        //properties
        public double Cost
        {
            get
            {
                return cost;
            }

            set
            {
                cost = value;
            }
        }
        public string name;
    }
}
