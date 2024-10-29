namespace EcoTropolis.InventorySystem;

public class Item {
    public string Name { get; private set; }
    public string Desription { get; private set; }
    public string Usage { get; private set;  }  //Maybe not necessary, we might use that field to
                                                //display a message guiding the player how to use the item
                                                
    
    public Item(string name, string desription, string usage) {
        Name = name;
        Desription = desription;
        Usage = usage; 
    }

}