namespace EcoTropolis.InventorySystem;

public class Inventory {
    /*
     * Welcome to the Inventory class. This class for now does not take any values to be instantiated.
     * Inventory is closely tied to the Player object, which might change in the future, because the Player class in its current state just implements the Inventory class.
     * 
     * public Dictionary<Item, int> Items = new Dictionary<Item, int>(); -> the storage of the player,
     * it includes objects such as the game currency and other Location-specific objects of class InventoryItem
     */
    public Dictionary<Item, int> Items = new Dictionary<Item, int>();
    public Dictionary<string, Item> References = new Dictionary<string, Item>();
    private Game _gameInstance;
    
    public Inventory(Game game)
    {
        _gameInstance = game;
        Item item = new Item("Showel", "Nice showel", "dig a hole");
        Items.Add(item, 1);
        References.Add("showel", item);
        Item susDollars = new Item("Sus$",
            "Currency to make in-game purchases",
            "Currency to make in-game purchases");
        Items.Add(susDollars, 500); 
        References.Add("money", item);
        
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
    
    public bool CurrencySubtract(int money) {
        if (Items[References["money"]] >= money) {
            Items[References["money"]] -= money;
            return true; 
        }
        return false; 
    }

    public void CurrencyAdd(int money) {
        Items[References["money"]] += money; 
    }

    public void SellItem(Item item, int price) {
        Items.Remove(item); 
        CurrencyAdd(price);
    }

    public void SellItemByReference(string reference, int price) {
        Items.Remove(References["reference"]);
        CurrencyAdd(price);
    }

    public bool BuyItem(Item item, int price) {
        if (CurrencySubtract(price)) {
            Items.Add(item, 1);
            References.Add(item.Name, item);
            return true; 
        }

        return false; 
    }


}