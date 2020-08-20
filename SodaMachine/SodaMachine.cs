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
            inventory = new List<Can>();
        }



        //member methods
        public void StartingCoins()
        {
            for (int i = 0; i < 20; i++)
            {
                AddQuarterToSodaMachine();
            }

            for (int i = 0; i < 10; i++)
            {
                AddDimeToSodaMachine();
            }

            for (int i = 0; i < 20; i++)
            {
                AddNickelToSodaMachine();
            }

            for (int i = 0; i < 50; i++)
            {
                AddPennytoSodaMachine();
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

        public void AddQuarterToSodaMachine()
        {
            Quarter quarter = new Quarter();
            register.Add(quarter);
        }

        public void AddDimeToSodaMachine()
        {
            Dime dime = new Dime();
            register.Add(dime);
        }

        public void AddNickelToSodaMachine()
        {
            Nickel nickel = new Nickel();
            register.Add(nickel);
        }

        public void AddPennytoSodaMachine()
        {
            Penny penny = new Penny();
            register.Add(penny);
        }
    }
}
