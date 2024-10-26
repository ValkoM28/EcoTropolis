using WorldOfZuul.Locations;

namespace WorldOfZuul;
using WorldOfZuul.InventorySystem;

public class Player {
    public Inventory Inventory { get; private set; }
    public MainCity MainCity { get; private set; }
    
    
    public Player(Inventory inventory, MainCity mainCity) {
        Inventory = inventory;
        MainCity = mainCity; 
    }

    public void ShowInventory() {
        Inventory.Show(); 
    }

}