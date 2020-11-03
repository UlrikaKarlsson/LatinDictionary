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
            string[] word = { "vidare-se", "pater-far", "arbor-träd", "luna-måne", "movere-flytta", "urbs-stad" };
            string[] menuArray = { "Show list", "Look up word in latin", "Exit" };            
            int menuChoice = 0;
            int[] menu = new int[] { 1, 2, 3 };          
            Dictionary<string, string> latinDictionary = new Dictionary<string, string>();
            Console.WriteLine("**** Latin dictionary ****\n");
            bool quit = false;
            do
            {
                Console.WriteLine();
                for(int i = 0; i < 3; i++)
                { 
                    Console.WriteLine("{0}. {1}", menu[i], menuArray[i]);
                }             
                Console.Write("\nSelect an option from the meny:" );                           
                userInput = Console.ReadLine();
                menuChoice = int.Parse(userInput);
                
                if (menuChoice == 3)
                {
                    quit = true;
                }         
                else if (menuChoice == 1)
                {         
                    for (int i = 0; i < word.Length; i++)
                    {
                        Console.WriteLine(word[i]);
                    }               
                }
                else if (menuChoice == 2)
                {
                    Console.Write("What latin word do you want to translate into swedish? ");
                    userInput = Console.ReadLine();
                    for (int i = 0; i < word.Length; i++)
                    {
                        string wordInArray = word[i];
                        string[] splitWord = wordInArray.Split('-');
                        if (splitWord[0] == userInput)
                        {
                            Console.WriteLine("The translation of the word " + userInput + " is " + splitWord[1] + " in swedish");
                        }
                    }
                }
            }
            while (quit != true);
            {
                Console.WriteLine("Have a nice day!");
            }
        }
    }
}
