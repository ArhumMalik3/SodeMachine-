using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {
        //member variables
        public Wallet wallet;
        public Backpack backpack;
        public List<Coin> selectedCoins;
        public List<Can> selectedCans;
        public double customerTotal;
        public double totalBill;
        

        //constructor
        public Customer()
        {
            selectedCoins = new List<Coin>();
            selectedCans = new List<Can>();
            customerTotal = 0;
            totalBill = 0;
        }


        //member methods
        public void SelectedUserCoins()
        {
            while (Userinterface.userCoins != "F")
            {
                if (Userinterface.userCoins == "Q")
                {
                    customerTotal += .25;
                    AddQuarterToSelectedCoins();
                }
                else if (Userinterface.userCoins == "D")
                {
                    customerTotal += .10;
                    AddDimeToSelectedCoins();
                }
                else if (Userinterface.userCoins == "N")
                {
                    customerTotal += .05;
                    AddNickelToSelectedCoins();
                }
                else
                {
                    customerTotal += .01;
                    AddPennytoSelectedCoins();
                }
            }
        }

        public void RemoveCoinsFromWallet()
        {
            wallet.coins.RemoveAt(0);
            wallet.coins.RemoveAt(11);
            wallet.coins.RemoveAt(21);
            wallet.coins.RemoveAt(41);
        }

        public void SodaChoice(string sodaChoice)
        {
            switch (sodaChoice)
            {
                case "R":
                    AddRootBeerToSelectedCans();
                    
                    break;

                case "C":
                    AddColaToSelectedCans();
                    break;

                case "O":
                    AddOrangeToSelectedCans();
                    break;

                 
            }
        }

       


        public void AddQuarterToSelectedCoins()
        {
            Quarter quarter = new Quarter();
            selectedCoins.Add(quarter);
        }

        public void AddDimeToSelectedCoins()
        {
            Dime dime = new Dime();
            selectedCoins.Add(dime);
        }

        public void AddNickelToSelectedCoins()
        {
            Nickel nickel = new Nickel();
            selectedCoins.Add(nickel);
        }

        public void AddPennytoSelectedCoins()
        {
            Penny penny = new Penny();
            selectedCoins.Add(penny);
        }
        //cans
        public void AddRootBeerToSelectedCans()
        {
            RootBeer rootbeer = new RootBeer();
            selectedCans.Add(rootbeer);
            totalBill += rootbeer.Cost;
        }

        public void AddColaToSelectedCans()
        {
            Cola cola = new Cola();
            selectedCans.Add(cola);
            totalBill += cola.Cost;

        }

        public void AddOrangeToSelectedCans()
        {
            OrangeSoda orange = new OrangeSoda();
            selectedCans.Add(orange);
            totalBill += orange.Cost;
        }

    }
}
