using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SodaMachine
{
    class Simulation
    {
        //member variables
        public SodaMachine sodaMachine;
        public Customer customer;


        //constructor
        public Simulation()
        {

        }


        //member methods

        public void RunSodaMachine()
        {
            SimulationSetup();
            //stock coins in the soda machine
            //stock cans in the soda machine
            //stock coins into the wallet
            //Display welcome to the user
            //Give the user the soda options
            //User picks the soda he wants
            //user picks what coins he wants to pay with
            //

        }

        public void CheckingUserInput()
        {
          while (Userinterface.userCoins != "F")
            {
                if (Userinterface.userCoins == "Q")
                {

                }
                else if (Userinterface.userCoins == "D")
                {

                }
                else if (Userinterface.userCoins == "N")
                {

                }
                else
                {

                }
            }  
        }

        public void SimulationSetup()
        {
            sodaMachine.StartingCoins();
            sodaMachine.StartingCans();
            customer.wallet.StartingWallet();
        }





    }
}
