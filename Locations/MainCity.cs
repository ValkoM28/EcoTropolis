using static EcoTropolis.Messages.Messages;

namespace EcoTropolis.Locations;

public class MainCity : Location {
    public Dictionary<string, Location> Exits { get; }
    
    public MainCity(string name) : base(name){
        
    }



    public override void DisplayStartMessage()
    {
        Console.WriteLine("You are now in your own city. \n" +
                          "Type \"Look\" to see the details of the city.\n" +
                          "Type \"Help\" to see additional commands ");
    }

    public override void ShowDescription() {
        DisplayMessage("main_city");
    }

    public void ListBuildings() {
        throw new NotImplementedException(); 
    } 
    
    


}