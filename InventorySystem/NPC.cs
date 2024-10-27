namespace WorldOfZuul.InventorySystem;

public class NPC : Item {
                                                
    //rather implement NPCs as a completely separate class, because this looks weird
    public NPC(string name, string desription, string usage) : base(name, desription, usage) {
    }

    public override bool Use()
    {
        throw new NotImplementedException(); 
    }

    public override void Sell()
    {
        throw new NotImplementedException(); 
    } 
} 