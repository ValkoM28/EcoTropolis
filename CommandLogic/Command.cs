using EcoTropolis.Locations;

namespace EcoTropolis.CommandLogic; 

public class Command {
    private Game _game;
    public string Name { get; }
    public string? SecondWord { get; } // this might be used for future expansions, such as "take apple".
    public Location CommandLocation { get;  }
    //public string CommandType;
    
    
    public Command(Game game, Location location, string name, string? secondWord = null) {
        _game = game; 
        Name = name;
        SecondWord = secondWord;
        CommandLocation = location;
    }
}

