namespace EcoTropolis.CommandLogic; 

public class Parser {
    private readonly CommandWords? _commandWords;
    private string _parserType;
    private Game _gameInstance; 
    
    // More efficient would be to use an int or short instead of a string, but we chose a string because it is a small program
    public Parser(string parserType, Game game) {
        _commandWords = new CommandWords(parserType);
        _parserType = parserType;
        _gameInstance = game; 

    } 
    
    
    public Command? GetCommand(string inputLine) {
        if (string.IsNullOrEmpty(inputLine)) {
            return null;
        }
        
        string[] words = inputLine.Split(" ");

        if (!_commandWords.IsValidCommand(words[0])) {
            return null;
        }
        
        if (words.Length > 1) {
            return new Command(_gameInstance, words[0], words[1], commandType: _parserType);
        } 

        return new Command(_gameInstance, words[0], commandType: _parserType);  //TODO: check if that even works, correct syntax?
    }
}
    

