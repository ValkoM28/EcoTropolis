using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfZuul
{
    public class Parser
    {
        private readonly CommandWords commandWords; 
        
        // More efficient would be to use an int or short instead of a string, but we chose a string because it is a small program
        public Parser(string parserType) {
            commandWords = new CommandWords(parserType);
        } 
        
        
        public Command? GetCommand(string inputLine)
        {
            string[] words = inputLine.Split();

            if (words.Length == 0 || !commandWords.IsValidCommand(words[0]))
            {
                return null;
            }

            if (words.Length > 1)
            {
                return new Command(words[0], words[1]);
            }

            return new Command(words[0]);
        }
    }
    
}
