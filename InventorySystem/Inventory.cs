namespace WorldOfZuul.InventorySystem;

public class Inventory {
    /*
     * Welcome to the Inventory class. This class for now does not take any values to be instantiated.
     * Inventory is closely tied to the Player object, which might change in the future, because the Player class in its current state just implements the Inventory class.
     * 
     * public Dictionary<Item, int> Items = new Dictionary<Item, int>(); -> the storage of the player,
     * it includes objects such as the game currency and other Location-specific objects of class InventoryItem
     */
    public Dictionary<Item, int> Items = new Dictionary<Item, int>();

    public Inventory() {
        InventoryItem item = new InventoryItem("Showel", "Nice showel", "dig a hole");
        Items.Add(item, 1);
    }

    /*
     * This method lists all items in the inventory to the screen.
     * TODO: Formatting of the output is terrible, implement something better.
     */
    public void Show() {
        foreach (var item in Items) {
            Console.WriteLine(item.Key.Name + item.Value.ToString());
        }
    }
}