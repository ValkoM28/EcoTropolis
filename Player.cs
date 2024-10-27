using WorldOfZuul.Locations;

namespace WorldOfZuul;
using WorldOfZuul.InventorySystem;

public class Player {
    public Inventory Inventory { get; private set; }
    
    
    public Player(Inventory inventory) {
        Inventory = inventory;
    }

    public void ShowInventory() {
        Inventory.Show(); 
    }

}