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
            string[] menu = {"1. New latin word", "2. Quit"};

            Dictionary<string, string> latinDictionary = new Dictionary<string, string>();
            Console.WriteLine("**** Latin dictionary ****\n");

            bool quit = false;

            do
            {
                foreach(string s in menu)
                {
                    Console.WriteLine(s);
                }
                Console.Write("Select an option from the meny: ");

                userInput = Console.ReadLine();
                if (userInput == "quit")
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
