using EcoTropolis.InventorySystem;
using static EcoTropolis.Messages.Messages;


namespace EcoTropolis.Locations;

public abstract class Location {
    public string Name { get; }
    public HappinessIndicator HappinessIndicator;
    public NPC npc; 
    
    
    //public Dictionary<string, Location> Exits { get; }
    
    protected Location(string name) {
        Name = name;
    }

    public abstract void DisplayStartMessage(); 
    public abstract void ShowDescription(); 

    

}