using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Backpack
    {
        //member variables
        public List<Can> cans;
        
        
        //constructor
        public Backpack()
        {
            cans = new List<Can>();
        }


        //member methods
        public void AddRootBeerToBackpack()
        {
            RootBeer rootBeer = new RootBeer();
            cans.Add(rootBeer);
        }

        public void AddColaToBackpack()
        {
            Cola cola = new Cola();
            cans.Add(cola);
        }

        public void AddOrangeToBackpack()
        {
            OrangeSoda orangeSoda = new OrangeSoda();
            cans.Add(orangeSoda);
        }

    }
}
