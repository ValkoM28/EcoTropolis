using EcoTropolis.Locations;

namespace EcoTropolis.CommandLogic; 

public class Parser {
    private readonly string[] _commandWords;
    private string _parserType;
    private Game _gameInstance;
    private Location _location; 
    
    // More efficient would be to use an int or short instead of a string, but we chose a string because it is a small program
    public Parser(string[] commandWords, Game game, Location location) {
        _commandWords = commandWords;
        _gameInstance = game;
        _location = location; 
    } 
    
    
    public Command? GetCommand(string inputLine) {
        if (string.IsNullOrEmpty(inputLine)) {
            return null;
        }
        
        string[] words = inputLine.Split(" ");

        if (!IsValidCommand(words[0])) {
            return null;
        }
        
        if (words.Length > 1) {
            return new Command(_gameInstance, _location, words[0], words[1]);
        } 

        return new Command(_gameInstance, _location, words[0]);  //TODO: check if that even works, correct syntax?
    }

    public bool IsValidCommand(string input) {
        Console.WriteLine(input);
        Console.WriteLine(_commandWords);
        return _commandWords.Contains(input); 
    }
}
    

