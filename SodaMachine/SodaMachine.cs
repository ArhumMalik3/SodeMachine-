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
        public Quarter quarter = new Quarter();
        public Dime dime = new Dime();
        public Nickel nickel = new Nickel();
        public Penny penny = new Penny();
        public Cola cola = new Cola();
        public OrangeSoda orangeSoda = new OrangeSoda();
        public RootBeer rootBeer = new RootBeer();



        //constructor
        public SodaMachine()
        {
            register = new List<Coin>();
        }



        //member methods
        public void StartingCoins()
        {
            for (int i = 0; i < 20; i++)
            {
                register.Add(quarter);
            }

            for (int i = 0; i < 10; i++)
            {
                register.Add(dime);
            }

            for (int i = 0; i < 20; i++)
            {
                register.Add(nickel);
            }

            for (int i = 0; i < 50; i++)
            {
                register.Add(penny);
            }
                

        }


        public void StartingCans()
        {
            for (int i = 0; i < 20; i++)
            {
                inventory.Add(cola);
                inventory.Add(orangeSoda);
                inventory.Add(rootBeer);
            }
        }
    }
}
