namespace WorldOfZuul.InventorySystem;

public class ShopItem : Item
{
    public ShopItem(string name, string description, string usage) : base(name, description, usage) {
        
    }
    
    
    public override bool Use() {
        throw new NotImplementedException(); 
    }
    
    
    public override void Sell() {
        throw new NotImplementedException(); 
    }
}