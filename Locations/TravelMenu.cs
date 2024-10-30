using static EcoTropolis.Messages.Messages;
namespace EcoTropolis.Locations;

public class TravelMenu : Location {
    
    public string Description { get; } = ""; 
    public Dictionary<string, Location> Exits { get; }
    
    public TravelMenu() : base("Travel Menu") {
        
    }

    public override void DisplayStartMessage() {
        

        string welcome = """
                         Welcome to the travel menu:  
                         Pick the location of your next journey
                         1 - Los Angeles
                         2 - Barcelona
                         3 - Tokyo
                         4 - Sao Paulo
                         5 - Amsterdam
                         6 - Manila
                         """;
        
        Console.WriteLine(welcome);
    }
    

    public override void ShowDescription() {
        throw new NotImplementedException();
    }
}