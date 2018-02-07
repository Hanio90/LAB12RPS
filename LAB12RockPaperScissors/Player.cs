using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12RockPaperScissors
{
    public enum Roshambo
    {
        rock = 1,
        paper,
        scissors,
    }
    public enum Outcome
    {
        win,
        lose,
        tie,
    }
    

    abstract class Player
    {
        
        //Properties
        public string Name
        {
            get;
            set;
        }

        public Roshambo RoshamboValue
        {
            get;
            set;
        }

        public abstract Roshambo GenerateRoshambo(); //Method 
        

        
        

        


    }
}
