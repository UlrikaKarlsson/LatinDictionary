using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string userInput = "";
            int[] menu = new int[] { 1, 2 };
            int menuChoice = 0, menu1 = 0, menu2 = 1;
            Dictionary<string, string> latinDictionary = new Dictionary<string, string>();
            Console.WriteLine("**** Latin dictionary ****\n");

            bool quit = false;

            do
            { 
                Console.WriteLine("{0} Insert latin word", menu[menu1]);
                Console.WriteLine("{0} Exit", menu[menu2]);
                Console.Write("Select an option from the meny:" );            
                
               
                userInput = Console.ReadLine();
                menuChoice = int.Parse(userInput);

                if (menuChoice == menu[menu2])
                {
                    quit = true;
                }
                else if (userInput == "new")
                { 

                }
            }
            while (quit != true);
            {
                Console.WriteLine("Have a nice day!");
            }
        }
    }
}
