using WorldOfZuul.InventorySystem;

namespace WorldOfZuul.Locations;

public class PawnShop : Location {
    private List<ShopItem> itemsAvailable;  
    //public Dictionary<string, Location> Exits { get; }
    
    public PawnShop(string name) : base(name) {
    }


    public override void ToMainMenu()
    {
        throw new NotImplementedException();
    }

    public override void ShowDescription()
    {
        throw new NotImplementedException();
    } 
    
}