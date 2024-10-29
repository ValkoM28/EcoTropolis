using EcoTropolis.InventorySystem;

namespace EcoTropolis.Locations;

public class PawnShop : Location {
    private List<Item> itemsAvailable;
    public Dictionary<Item, int> PriceList { get; private set; }
    
    public PawnShop() : base("Pawn Shop") {
        
    }

    
    public override void DisplayStartMessage() {
        
    }

    public override void ShowDescription()
    {
        throw new NotImplementedException();
    }

    public bool BuyItem(string numberString, Player player)
    {
        short numberShort;
        Int16.TryParse(numberString, out numberShort);
        Item toBuy = itemsAvailable[numberShort];

        if (player.Inventory.BuyItem(toBuy, PriceList[toBuy])) {
            return true; 
        }
        return false; 
    }
    
}