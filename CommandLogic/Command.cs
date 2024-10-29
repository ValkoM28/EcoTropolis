namespace EcoTropolis.CommandLogic; 

public class Command {
    public Game GameInstance;
    public string Name { get; }
    public string? SecondWord { get; } // this might be used for future expansions, such as "take apple".
    public string CommandType;
    
    
    public Command(Game game, string name, string? secondWord = null, string commandType = null)
    {
        GameInstance = game; 
        Name = name;
        SecondWord = secondWord;
        CommandType = commandType;
        
    }
}

