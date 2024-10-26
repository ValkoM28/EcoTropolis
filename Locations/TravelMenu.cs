namespace WorldOfZuul.Locations;

public class TravelMenu {

    public string Name { get; } = "Travel Menu";
    public string Description { get; } = ""; 
    public Dictionary<string, Location> Exits { get; }
    
    public TravelMenu() {
        
    }



    public void ToMainMenu() {
        throw new NotImplementedException();
    }

    public void ShowDescription() {
        throw new NotImplementedException();
    }
}