using System.ComponentModel;

namespace WorldOfZuul;

public class MainCity : Room {
    public string WelcomeMessage { get; set; }
    
    public MainCity(string name, string description) : base(name, description) {
        
    }

    public override void ToMainMenu() {
        throw new System.NotImplementedException();
        
    } 
    public override void ShowDescription() {
        throw new NotImplementedException();
    }
}