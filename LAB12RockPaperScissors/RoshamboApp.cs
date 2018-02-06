using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12RockPaperScissors
{
    class RoshamboApp
    {
        static void Main(string[] args)
        {
            Dictionary<Roshambo, Roshambo> Winners = new Dictionary<Roshambo, Roshambo>
            {
                 { Roshambo.rock,Roshambo.scissors },
                 { Roshambo.scissors,Roshambo.paper },
                 { Roshambo.paper,Roshambo.rock }

            };
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine();
            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();

            Console.WriteLine("Would you like to play against TheJets or Thesharks(J/S)? :");
            string playAgainst = Console.ReadLine();
            if (playAgainst.ToLower() == "J" )
            {

            }


        }
    }
}
