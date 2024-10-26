using static WorldOfZuul.Messages.Messages;

namespace WorldOfZuul.InventorySystem;

public class HappinessIndicator {
    public double HappinessLevel { get; private set; }
    
    public HappinessIndicator(double hapinessLevel) {
        HappinessLevel = hapinessLevel; 
    }

    public void DisplayHappiness() {
        DisplayHappinessLevel(this);
    }
}