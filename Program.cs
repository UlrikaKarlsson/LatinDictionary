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
            Dictionary<string, string> latinDictionary = new Dictionary<string, string>();
            Console.WriteLine("**** Latin dictionary, write quit to exit ****");
            bool quit = false;

            do
            {
                Console.Write("Insert new latin word: ");
                userInput = Console.ReadLine();
            }
            while (quit != true);
            {

            }
        }
    }
}
