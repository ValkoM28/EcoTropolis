using EcoTropolis.InventorySystem;
using EcoTropolis.Locations;

namespace EcoTropolis;
using EcoTropolis.InventorySystem;

public class Player {
    public Inventory Inventory { get; private set; }
    
    
    public Player(Inventory inventory) {
        Inventory = inventory;
    }

    public void ShowInventory() {
        Inventory.Show(); 
    }

}