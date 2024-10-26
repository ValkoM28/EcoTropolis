namespace WorldOfZuul.InventorySystem;

public class Inventory {
    public Dictionary<Item, int> Items = new Dictionary<Item, int>();

    public Inventory()
    {
        InventoryItem item = new InventoryItem("Showel", "Nice showel", "dig a hole");
        Items.Add(item, 1);
    }

    public void Show() {
        foreach (var item in Items) {
            Console.WriteLine(item.Key.Name + item.Value.ToString());
        }
        
        
    }
    
    
}