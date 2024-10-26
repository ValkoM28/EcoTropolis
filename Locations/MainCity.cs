using System.ComponentModel;
using static WorldOfZuul.Messages.Messages;

namespace WorldOfZuul.Locations;

public class MainCity : Location {
    public string Name { get; }
    public string Description { get; }
    public Dictionary<string, Location> Exits { get; }
    
    public MainCity(string name) : base(name){
        
    }



    public override void ToMainMenu() {
        throw new System.NotImplementedException();
        
    }

    public override void ShowDescription() {
        DisplayMessage("main_city");
    }

    public void ListBuildings() {
        throw new NotImplementedException(); 
    } 
    
    


}