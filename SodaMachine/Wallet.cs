using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        //member variables
        public List<Coin> coins;
        public Card card;
        



        //constructor
        public Wallet()
        {
            coins = new List<Coin>();
        }


        //memeber methods
        //5 dollars in mixed change
        public void StartingWallet()
        {
            for (int i = 0; i < 11; i++)
            {
                Quarter quarter = new Quarter();
                coins.Add(quarter);

            }

            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                coins.Add(dime);
            }

            for (int i = 0; i < 20; i++)
            {
                Nickel nickel = new Nickel();
                coins.Add(nickel);
            }

            for (int i = 0; i < 25; i++)
            {
                Penny penny = new Penny();
                coins.Add(penny);
            }

        }

    }
}
