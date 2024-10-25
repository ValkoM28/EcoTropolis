namespace WorldOfZuul;

public class Travel : Room
{
    public static string name { get; private set; } = "Travel Menu";
    private static string description = "";
    
    public Travel() : base(name, description) {
        
    }

    public override void ToMainMenu() {
        throw new NotImplementedException();
    }

    public override void ShowDescription() {
        throw new NotImplementedException();
    }
}