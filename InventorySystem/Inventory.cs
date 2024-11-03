namespace EcoTropolis.InventorySystem;

public class Inventory {
    /*
     * Welcome to the Inventory class. This class for now does not take any values to be instantiated.
     * Inventory is closely tied to the Player object, which might change in the future, because the Player class in its
     * current state just implements the Inventory class.
     *
     * public Dictionary<Item, int> Items = new Dictionary<Item, int>(); -> the storage of the player,
     * it includes objects such as the game currency and other Location-specific objects of class InventoryItem
     *
     * public Dictionary<string, Item> References = new Dictionary<string, Item>(); -> stores the references to items in
     * string form
     * It is easier for other parts of the program to work with build-in types
     *
     * private Game _gameInstance; -> stores the instance of main class of the game, so that it can access and modify
     * the values in the main game loop
     * TODO: Consider managing items using UniqueIDs (UUID) instead of strings
     */
    public Dictionary<Item, short> Items = new Dictionary<Item, short>();
    public Dictionary<string, Item> References = new Dictionary<string, Item>();
    private Game _gameInstance;
    
    /*
     * TODO: Remove the test garbage from the constructor
     * Instantiating of Item objects in the inventory:
     * Item item = new Item(name:string, description:string, usage:string, price:short, sellable:bool[default true])
     */
    public Inventory(Game game) {
        _gameInstance = game;
        Item item = new Item("Showel", "Nice showel", "dig a hole", 500);
        Items.Add(item, 1);
        References.Add("showel", item);
        Item susDollars = new Item("Sus$",
            "Currency to make in-game purchases",
            "Currency to make in-game purchases", price:0, sellable:false);
        Items.Add(susDollars, 5000); 
        References.Add("money", susDollars);
    }

    /*
     * This method lists all items in the inventory to the screen.
     * TODO: Formatting of the output is terrible, implement something better.
     */
    public void Show() {
        foreach (var item in Items) {
            Console.WriteLine(item.Key.Name + " " + item.Value);
        }
    }
    /*
     * This method is used to add items to player's inventory from other parts of code. 
     */
    public void AddItem(Item item, short number = 1) {
        Items.Add(item, number);
        References.Add(item.Name, item);
    }
    
    public bool BuyItem(Item item, short price) {
        if (CurrencySubtract(price)) {
            AddItem(item);
            return true; 
        }
        return false; 
    }
    
    public bool CurrencySubtract(short money) {
        short currentMoney = Items[References["money"]]; 
        
        if (currentMoney >= money) {
            currentMoney -= money;
            Items[References["money"]] = currentMoney; 
            return true; 
        }
        return false; 
    }

    public void CurrencyAdd(short money) {
        Items[References["money"]] += money; 
    }

    public void SellItem(Item item, short price) {
        if (item.Sellable) {
            Items.Remove(item); 
            CurrencyAdd(price);
        }
    }

    public void SellItemByReference(string reference) {
        if (References[reference].Sellable) {
            CurrencyAdd(References[reference].Price);
            Items.Remove(References[reference]);
        }
    }




}