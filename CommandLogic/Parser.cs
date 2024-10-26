using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfZuul.CommandLogic; 

public class Parser {
    private readonly CommandWords commandWords;
    private string _parserType; 
    
    // More efficient would be to use an int or short instead of a string, but we chose a string because it is a small program
    public Parser(string parserType) {
        commandWords = new CommandWords(parserType);
        _parserType = parserType;
        
    } 
    
    
    public Command? GetCommand(string inputLine) {
        if (string.IsNullOrEmpty(inputLine)) {
            return null;
        }
        
        string[] words = inputLine.Split(" ");
        Console.WriteLine(words);

        if (!commandWords.IsValidCommand(words[0])) {
            return null;
        }
        
        if (words.Length > 1) {
            return new Command(words[0], words[1], commandType: _parserType);
        } 

        return new Command(words[0], commandType: _parserType);  //TODO: check if that even works, correct syntax?
    }
}
    

