using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12RockPaperScissors
{
    public class DisplayStats
    {
        public static string Stats(int win, int loss, int tie)
        {

            return ($"Stats : Wins: {win}, Losses: {loss},Ties : {tie}");
        }
           
    }
}
