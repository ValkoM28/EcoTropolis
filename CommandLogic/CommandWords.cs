using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfZuul.CommandLogic
{
    public class CommandWords
    {
        
        private string[] validCommandsCity { get; } = ["travel", "build", "help", "menu", "quit", "look", "inventory"];
        private string[] validCommandsTravel { get; } = [ "0", "1", "2", "3", "4", "5", "6", "7", "back" ];

        public string[] ValidCommands; 
        //public List<string> ValidCommandsRole { get; } = new List<string> { };
        // "inspect" - inspect a building in the main city - 2nd iteration probably
        public CommandWords(string whichList)
        {
            switch (whichList)
            {
                case "main":
                    ValidCommands = validCommandsCity;
                    break;
                case "travel":
                    ValidCommands = validCommandsTravel;
                    break;
                default:
                    ValidCommands = null;
                    break; //TODO: do not keep it like this
            }
        }

        public bool IsValidCommand(string command) {
            return ValidCommands.Contains(command);
        }
    }

}
