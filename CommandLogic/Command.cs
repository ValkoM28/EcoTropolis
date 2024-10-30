using EcoTropolis.Locations;

namespace EcoTropolis.CommandLogic; 

public class Command {
    public Game GameInstance;
    public string Name { get; }
    public string? SecondWord { get; } // this might be used for future expansions, such as "take apple".
    public Location CommandLocation { get;  }
    //public string CommandType;
    
    
    public Command(Game game, Location location, string name, string? secondWord = null) {
        GameInstance = game; 
        Name = name;
        SecondWord = secondWord;
        CommandLocation = location;
    }
}

