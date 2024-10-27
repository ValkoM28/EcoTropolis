using static WorldOfZuul.Messages.Messages;
namespace WorldOfZuul.Locations;

public class TravelMenu : Location {
    
    public string Description { get; } = ""; 
    public Dictionary<string, Location> Exits { get; }
    
    public TravelMenu() : base("Travel Menu") {
        
    }

    public override void DisplayStartMessage() {
        Console.WriteLine("Welcome to the travel menu: \n" +
                          "Pick the location of your next journey\n" +
                          "Or type \"back\" to go back to your city\n" +
                          "If you want to learn more about the specific location, type \"Look [number]\"\n" +
                          "If you need help, type \"help\"\n" +
                          "1 - Location 1\n" +
                          "2 - Location 1\n" +
                          "3 - Location 1\n" +
                          "4 - Location 1\n" +
                          "5 - Location 1\n" +
                          "6 - Location 1\n" +
                          "0 - Pawn Shop");
    }

    public override void ToMainMenu() {
        throw new NotImplementedException();
    }

    public override void ShowDescription() {
        throw new NotImplementedException();
    }
}