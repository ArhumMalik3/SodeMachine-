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
            customer.SodaChoice(Userinterface.userChoice);
        }


        public void CheckPayment()
        {

            if (customer.totalBill > customer.customerTotal)
            {
                //return money back
            }
            else if (customer.totalBill == customer.customerTotal)
            {
                //accept payment
                //dispense a soda instance that gets saved in my backpack
            }
            else
            {
                //accept payment
                //return change as a list of coins from internal
                //dispense a soda instance that gets saved in my backpack
            }

        }

        public void CustomerTotal()
        {

        }

        

        public void CheckingUserSodaSelection()
        {


        }

        public void SimulationSetup()
        {
            sodaMachine.StartingCoins();
            sodaMachine.StartingCans();
            customer.wallet.StartingWallet();
        }

         




    }
}
