using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        //member variables
        public List<Coin> coins;
        public Card card;
        public SodaMachine sodaMachine;



        //constructor
        public Wallet()
        {
            coins = new List<Coin>();
        }


        //memeber methods
        public void StartingWallet()
        {
            coins.Add(sodaMachine.quarter);
        }

    }
}
