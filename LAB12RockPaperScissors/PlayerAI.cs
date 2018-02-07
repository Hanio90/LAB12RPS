using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB12RockPaperScissors
{
    class PlayerAI : Player
    {
        
        public PlayerAI()
        {
            Name = "Random Randy";
            RoshamboValue = GenerateRoshambo(); // called the GenerateRoshambo method to give me a random value. RoshamboValue  is coming from the player class.(Setting the name)
        }

        Random rnd = new Random(); //Object

        public override Roshambo GenerateRoshambo()
        {
            int Ai = rnd.Next(1, 4);
            return (Roshambo)Ai;
        
        }
    }
}
