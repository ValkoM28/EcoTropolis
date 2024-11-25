using EcoTropolis.Locations;

namespace EcoTropolis.CommandLogic; 

public class Command {
    public string Name { get; }
    public string? SecondWord { get; } // this might be used for future expansions, such as "take apple".
    public Location CommandLocation { get;  }
    
    
    public Command(Location location, string name, string? secondWord = null) {
        Name = name;
        SecondWord = secondWord;
        CommandLocation = location;
    }
}

