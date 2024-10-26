using WorldOfZuul.Maps;

using static WorldOfZuul.Messages.Messages;

namespace WorldOfZuul;

public class StartMenu
{
    public string CityName { get; private set; } = null;  
    
    public StartMenu() {
        MapWorld worldMap = new();
        worldMap.DisplayMap();

        DisplayMessage("start"); 
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        
        Console.WriteLine("\n");
            
        Console.WriteLine("Please name your city and press enter:");

        // Read the user's input from the console
        CityName = Console.ReadLine(); 
        
        while (string.IsNullOrEmpty(CityName)) {
            DisplayMessage("invalid_city_name");
            CityName = Console.ReadLine(); 
        }
        
    }
    


}