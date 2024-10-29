namespace EcoTropolis.CommandLogic; 

public class Parser {
    private readonly string[] _commandWords;
    private string _parserType;
    private Game _gameInstance; 
    
    // More efficient would be to use an int or short instead of a string, but we chose a string because it is a small program
    public Parser(string[] commandWords, Game game) {
        _commandWords = commandWords;
        _gameInstance = game; 

    } 
    
    
    public Command? GetCommand(string inputLine) {
        if (string.IsNullOrEmpty(inputLine)) {
            return null;
        }
        
        string[] words = inputLine.Split(" ");

        if (IsValidCommand(words[0])) {
            return null;
        }
        
        if (words.Length > 1) {
            return new Command(_gameInstance, words[0], words[1], commandType: _parserType);
        } 

        return new Command(_gameInstance, words[0], commandType: _parserType);  //TODO: check if that even works, correct syntax?
    }

    public bool IsValidCommand(string input)
    {
        return _commandWords.Contains(input); 
    }
}
    

