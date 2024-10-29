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
                         Or type "back" to go back to your city
                         If you want to learn more about the specific location, type "Look [number]"
                         If you need help, type "help"
                         1 - Location 1
                         2 - Location 1
                         3 - Location 1
                         4 - Location 1
                         5 - Location 1
                         6 - Location 1
                         0 - Pawn Shop
                         """;
        
        Console.WriteLine(welcome);
    }
    

    public override void ShowDescription() {
        throw new NotImplementedException();
    }
}