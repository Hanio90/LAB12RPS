using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LAB12RockPaperScissors
{
    class Validation
    {

        public static string validateAI(string tempname)
        {
            Console.WriteLine("Would you like to play against Brock or Random Randy? :");
            while (true)
            {
                string opponent = Console.ReadLine();

                if (opponent.ToLower() == "brock" || opponent.ToLower() == "random randy")
                {
                    return opponent;
                }


                Console.WriteLine("Please enter a valid pponent");

            }
        }

        public static string validateString(string tempname)
        {
            Console.WriteLine("Please enter your name:");
            while (true)
            {
                string userName = Console.ReadLine();

                if (Regex.IsMatch(userName, "([A-Za-z])"))
                {

                    return userName;
                }
                Console.WriteLine("Please enter a valid name");

            }

        }

        public static bool validateRunAgain(string temp)
        {

            while (true)
            {
                if (temp == "y")
                {

                    bool choice = true;
                    Console.Clear();
                    return choice;
                }
                else if (temp == "n")
                {
                    Console.WriteLine("GOODBYE");
                    bool choice = false;
                    return choice;
                }
            }
        }
    }
}
