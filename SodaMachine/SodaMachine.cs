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
            for (int i = 0; i < 20; i++)
            {
                Quarter quarter = new Quarter();
                register.Add(quarter);
                
            }

            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                register.Add(dime);
            }

            for (int i = 0; i < 20; i++)
            {
                Nickel nickel = new Nickel();
                register.Add(nickel);
            }

            for (int i = 0; i < 50; i++)
            {
                Penny penny = new Penny();
                register.Add(penny);
            }
                

        }

        //Soda machine starts with 20 of each kind of soda

        public void StartingCans()
        {
            for (int i = 0; i < 20; i++)
            {
                Cola cola = new Cola();
                OrangeSoda orangeSoda = new OrangeSoda();
                RootBeer rootBeer = new RootBeer();
                inventory.Add(cola);
                inventory.Add(orangeSoda);
                inventory.Add(rootBeer);
            }
        }
    }
}
