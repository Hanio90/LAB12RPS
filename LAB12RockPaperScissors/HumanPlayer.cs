using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12RockPaperScissors
{
    class HumanPlayer : Player
    {

        public HumanPlayer(string name)
        {
            Name = name;
        }
        

        public override Roshambo GenerateRoshambo()
        {

            Console.WriteLine("Do you want [1]Rock,[2]Paper,[3]Scissors");
            var userInput = (Roshambo)Enum.Parse(typeof(Roshambo), Console.ReadLine());

            
            //(Roshambo)int.Parse(Console.ReadLine());
            return userInput;

        }
    }
}
