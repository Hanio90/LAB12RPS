using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12RockPaperScissors
{
    class PlayerRock : Player
    {

        public PlayerRock()
        {
            Name = "Brock";            // Name is coming from the player abstract class properties.
            RoshamboValue = Roshambo.rock;
            
        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
