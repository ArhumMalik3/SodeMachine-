using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        //member variables
        public List<Coin> register;
        public List<Can> inventory;


        //constructor
        public SodaMachine()
        {
            register = new List<Coin>();
        }



        //member methods
        public void StartingCoins()
        {
            register.Add(Quarter quarter);
        }

    }
}
