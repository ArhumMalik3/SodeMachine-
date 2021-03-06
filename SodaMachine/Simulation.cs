﻿using System;
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
            Userinterface.DisplayWelcome();
            Userinterface.DisplaySodaOptions();
            Userinterface.ChooseSoda();
            Userinterface.DisplaySelectigCoins();
            Userinterface.SelectCoins();
            
            customer.SodaChoice(Userinterface.userChoice);
            customer.SelectedUserCoins();
            CheckPayment();
        }


        public void CheckPayment()
        {

            if (customer.totalBill > customer.customerTotal)
            {
                //return money back
                TransactionDenied();
            }
            else if (customer.totalBill == customer.customerTotal)
            {
                //accept payment
                AcceptPayment();
                //dispense a soda instance that gets saved in my backpack
                DispenseSoda();
            }
            else
            {
                //accept payment
                AcceptPayment();
                //return change as a list of coins from internal
                //dispense a soda instance that gets saved in my backpack
                DispenseSoda();
            }

        }

        public void TransactionDenied()
        {
            customer.selectedCoins.Clear();
            customer.selectedCans.Clear();
        }

        public void AcceptPayment()
        {
            //remove coins from the wallet
            MoveSelectedCoinsToRegister();
        }

        public void DispenseSoda()
        {
            customer.backpack.cans = customer.backpack.cans.Concat(customer.selectedCans).ToList();
            customer.selectedCans.Clear();
        }

        public void MoveSelectedCoinsToRegister()
        {
            sodaMachine.register = sodaMachine.register.Concat(customer.selectedCoins).ToList();
            customer.selectedCoins.Clear();
        }

       

        public void SimulationSetup()
        {
            sodaMachine.StartingCoins();
            sodaMachine.StartingCans();
            customer.wallet.StartingWallet();
        }

         




    }
}
