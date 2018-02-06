using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12RockPaperScissors
{
    class PlayerRock : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
