using System.Net.NetworkInformation;
using WorldOfZuul.InventorySystem;

namespace WorldOfZuul.Locations;

public class SampleSpecificLocation : Location
{
    private Player _player; 
    //public Dictionary<string, Location> Exits { get; }
    
    public SampleSpecificLocation(string name, Player player) : base(name)
    {
        _player = player; 
        
    }

    public override void DisplayStartMessage()
    {
        
    }
    public override void ToMainMenu()
    {
        throw new NotImplementedException(); 
    }
    public override void ShowDescription() {
        throw new NotImplementedException(); 
    }
    
}