using EcoTropolis.Maps;
using static EcoTropolis.Messages.Messages;

namespace EcoTropolis;

public class StartMenu
{
    public string CityName { get; private set; } = null;  
    
    public StartMenu() {
        MapWorld worldMap = new();
        worldMap.DisplayMap();

        DisplayMessage("start"); 
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        
        Console.WriteLine("\n----------\n");
            
        Console.WriteLine("Please name your city and press enter:");
        Console.Write("> ");
        // Read the user's input from the console
        CityName = Console.ReadLine(); 
        
        Console.WriteLine("\n----------\n");
        
        while (string.IsNullOrEmpty(CityName)) {
            DisplayMessage("invalid_city_name");
            CityName = Console.ReadLine(); 
        }
        
    }
    


}