using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfZuul.CommandLogic
{
    public class Command
    {
        public string Name { get; }
        public string? SecondWord { get; } // this might be used for future expansions, such as "take apple".
        public string CommandType; 
        
        public Command(string name, string? secondWord = null, string commandType = null) 
        {
            Name = name;
            SecondWord = secondWord;
            CommandType = commandType;
        }
    }
}
