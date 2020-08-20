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
                AddQuarterToWallet();

            }

            for (int i = 0; i < 10; i++)
            {
                AddDimeToWallet();
            }

            for (int i = 0; i < 20; i++)
            {
                AddNickelToWallet();
            }

            for (int i = 0; i < 25; i++)
            {
                AddPennytoWallet();
            }

        }

        public void AddQuarterToWallet()
        {
            Quarter quarter = new Quarter();
            coins.Add(quarter);
        }

        public void AddDimeToWallet()
        {
            Dime dime = new Dime();
            coins.Add(dime);
        }

        public void AddNickelToWallet()
        {
            Nickel nickel = new Nickel();
            coins.Add(nickel);
        }

        public void AddPennytoWallet()
        {
            Penny penny = new Penny();
            coins.Add(penny);
        }

        public void RemoveQuarterFromWallet()
        {
            
        }
    }
}
