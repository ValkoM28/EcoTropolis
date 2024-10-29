using static EcoTropolis.Messages.Messages;

namespace EcoTropolis.InventorySystem;
/*
 * Not at all started, not for Iteration 1
 */
public class HappinessIndicator {
    public double HappinessLevel { get; private set; }
    
    public HappinessIndicator(double hapinessLevel) {
        HappinessLevel = hapinessLevel; 
    }

    public void DisplayHappiness() {
        DisplayHappinessLevel(this);
    }
}