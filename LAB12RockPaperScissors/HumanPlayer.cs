using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12RockPaperScissors
{
    class HumanPlayer : Player
    {

        

        public override Roshambo GenerateRoshambo()
        {
            Console.WriteLine("Do you want [1]Rock,[2]Paper,[3]Scissors");
            Roshambo input = (Roshambo)Enum.Parse(typeof(Roshambo), Console.ReadLine());
            return input;


            //int input = int.Parse(Console.ReadLine());
            //Roshambo output = (Roshambo)input; 
            //return output;
        }
    }
}
