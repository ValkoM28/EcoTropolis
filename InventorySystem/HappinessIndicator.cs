using static EcoTropolis.Messages.Messages;

namespace EcoTropolis.InventorySystem;

public class HappinessIndicator {
    public double HappinessLevel { get; private set; }
    
    public HappinessIndicator(double hapinessLevel) {
        HappinessLevel = hapinessLevel; 
    }

    public void DisplayHappiness() {
        DisplayHappinessLevel(this);
    }
}