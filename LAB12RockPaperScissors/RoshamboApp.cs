using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LAB12RockPaperScissors
{
    public class RoshamboApp //TODO: Keep track of wins and losses and ties 
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine();
            bool CONT = true;
            string userName = "";
            string opponent = "";
            int wins = 0;
            int loss = 0;
            int tie = 0;

            userName = Validation.validateString(userName);

            while (CONT)
            {
                opponent = Validation.validateAI(opponent);

                HumanPlayer user = new HumanPlayer(userName);
                var userInput = user.GenerateRoshambo();

                //int wins;


                if (opponent.ToLower() == "brock")
                {
                    PlayerRock brock = new PlayerRock();

                    Console.WriteLine($"{brock.Name.ToUpper()} Chose {brock.GenerateRoshambo()}");
                    Console.WriteLine($"{user.Name.ToUpper()} chose {userInput}");

                    CalculateResults(userInput.ToString(), brock.RoshamboValue.ToString(), user.Name, brock.Name);


                }
                else
                {
                    PlayerAI randomrandy = new PlayerAI();

                    Console.WriteLine($"{randomrandy.Name} Chose {randomrandy.RoshamboValue}");
                    Console.WriteLine($"{user.Name} chose {userInput}");

                    CalculateResults(userInput.ToString(), randomrandy.RoshamboValue.ToString(), user.Name, randomrandy.Name);

                }

                Console.WriteLine("\nWould you like to run this program again? Y/N");
                string cont = Console.ReadLine().ToLower();

                while (cont != "y" && cont != "n")
                {
                    Console.WriteLine("Please Enter Y or N!");
                    cont = Console.ReadLine().ToLower();
                }

                CONT = Validation.validateRunAgain(cont);
                if (CONT == true)
                {
                    continue;
                }
                else if (CONT == false)
                {
                    break;
                }

                void CalculateResults(string humanChoice, string aiChoice, string username, string aiName)
                {
                    

                    //rock
                    if ((humanChoice.ToLower() == "rock") == (aiChoice.ToLower() == "rock"))// encapsulation!
                    {
                        Console.WriteLine("It is a TIE");
                        tie++;
                        Console.WriteLine(DisplayStats.Stats(wins, loss, tie));
                        Console.ReadLine();
                    }
                    else if (humanChoice.ToLower() == "rock" && aiChoice.ToLower() == "scissors")
                    {
                        Console.WriteLine($"{username} WINS!");
                        wins++;
                        Console.ReadLine();
                    }
                    else if (humanChoice.ToLower() == "rock" && aiChoice.ToLower() == "paper")
                    {
                        Console.WriteLine($"{aiName} WINS!");
                        loss++;
                        Console.ReadLine();
                    }


                    //Scissors
                    else if (humanChoice.ToLower() == "scissors" && aiChoice.ToLower() == "rock")
                    {
                        Console.WriteLine($"{aiName} WINS!");
                        Console.ReadLine();
                    }
                    else if (humanChoice.ToLower() == "scissors" && aiChoice.ToLower() == "scissors")
                    {
                        Console.WriteLine("It is a TIE!");
                        Console.ReadLine();
                    }
                    else if (humanChoice.ToLower() == "scissors" && aiChoice.ToLower() == "paper")
                    {
                        Console.WriteLine($"{username} WINS!");
                        Console.ReadLine();
                    }

                    //Paper
                    else if (humanChoice.ToLower() == "paper" && aiChoice.ToLower() == "rock")
                    {
                        Console.WriteLine($"{username} WINS!");
                        Console.ReadLine();
                    }
                    else if (humanChoice.ToLower() == "paper" && aiChoice.ToLower() == "scissors")
                    {
                        Console.WriteLine($"{aiName} WINS!");
                        Console.ReadLine();
                    }
                    else if (humanChoice.ToLower() == "paper" && aiChoice.ToLower() == "paper")
                    {
                        Console.WriteLine("It is a TIE!");
                        Console.ReadLine();
                    }
                }
            }
        }



    }
}
