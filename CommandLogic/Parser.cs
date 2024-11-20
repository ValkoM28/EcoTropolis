using EcoTropolis.Locations;

namespace EcoTropolis.CommandLogic; 

public class Parser {
    private Game _game;
    private Location _location; 
    
    // More efficient would be to use an int or short instead of a string, but we chose a string because it is a small program
    public Parser(Game game, Location location) {
        _game = game;
        _location = location; 
    } 
    
    public Command? GetCommand(string inputLine, string[] commandWords) {
        if (string.IsNullOrEmpty(inputLine)) {
            return null;
        }
        
        string[] words = inputLine.Split(" ");

        if (!IsValidCommand(words[0], commandWords)) {
            return null;
        }
        
        if (words.Length > 1) {
            return new Command(_game, _location, words[0], words[1]);
        } 

        return new Command(_game, _location, words[0]);  //TODO: check if that even works, correct syntax?
    }

    public bool IsValidCommand(string input, string[] commandWords) {
        return commandWords.Contains(input); 
    }
}
    

