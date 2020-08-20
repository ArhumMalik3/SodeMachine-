using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public static class Userinterface
    {

        //member variables
        public static string userChoice;
        public static string userCoins;


        //properties

        //constructor


        //member methods
        public static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Soda Machine");
        }

        public static void DisplaySodaOptions()
        {
            Console.WriteLine("RootBeer: $.60 \n" +
                "Cola: $.35\n" +
                "Orange Soda: $.06");
            Console.WriteLine(" ");
        }

        public static void ChooseSoda()
        {
            Console.WriteLine("What Soda would you like? ");
            userChoice = Console.ReadLine();

        }

        public static void DisplaySelectigCoins()
        {
            Console.WriteLine("Select the coins you want to pay with.\n" +
                " Type Q for quarter, D for dime, N for nickel, P for penny, and F for finished: ");
            Console.WriteLine(" ");
            
        }

        public static void SelectCoins()
        {
            Console.WriteLine("Select a coin");
            userCoins = Console.ReadLine();

        }
    }
}
