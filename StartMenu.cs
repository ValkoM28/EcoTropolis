using WorldOfZuul.Maps;

namespace WorldOfZuul;

public class StartMenu {
    public string StartMessage = "Test Message";
    
    
    public StartMenu() {
        MapWorld worldMap = new();
        worldMap.DisplayMap();
        
        Console.WriteLine(StartMessage);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        
        Console.WriteLine("\n");
            
        Console.WriteLine("Please name your city and press enter:");

        // Read the user's input from the console
        string cityName = Console.ReadLine();
        
        
        Game game = new(cityName);
        game.Play();
    }
    


}