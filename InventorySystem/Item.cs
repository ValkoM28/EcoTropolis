namespace EcoTropolis.InventorySystem;

public class Item {
    public string Name { get; private set; }
    public string Desription { get; private set; }
    public string Usage { get; private set;  }  //Maybe not necessary, we might use that field to
                                                //display a message guiding the player how to use the item
    public short Price { get; private set; }  
    public bool Sellable { get; private set;  }
    
    public Item(string name, string desription, string usage, short price, bool sellable = true) {
        Name = name;
        Desription = desription;
        Usage = usage;
        Price = price;
        Sellable = sellable; 
    }

}

