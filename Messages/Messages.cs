using WorldOfZuul.InventorySystem;


namespace WorldOfZuul.Messages;

public static class Messages {

    public static void DisplayMessage(string messageType) {
        switch (messageType) {
            case "help":
                PrintHelpMessage();
                break; 
            case "welcome": 
                PrintWelcomeMessage();
                break; 
            case "travel": 
                PrintTravelMessage();
                break;
            case "start": 
                PrintStartMessage();
                break;
            case "invalid_command": 
                PrintInvalidCommandMessage();
                break;
            case "invalid_city_name": 
                PrintInvalidNameMessage();
                break;
        }
    }

    public static void DisplayDescription(string roomName) {
        switch (roomName) {
            case "main_city":
                PrintMainCityDesc();
                break;
            
        }
    }

    
    public static void DisplayHappinessLevel(HappinessIndicator happinessIndicator)
    {
        throw new NotImplementedException(); 
    }

    private static void PrintHelpMessage() {
        Console.WriteLine("You are lost. You are alone. You wander");
        Console.WriteLine("around the university.");
        Console.WriteLine();
        Console.WriteLine("Navigate by typing 'north', 'south', 'east', or 'west'.");
        Console.WriteLine("Type 'look' for more details.");
        Console.WriteLine("Type 'back' to go to the previous room.");
        Console.WriteLine("Type 'help' to print this message again.");
        Console.WriteLine("Type 'quit' to exit the game.");
    }

    private static void PrintWelcomeMessage() {
        Console.WriteLine("Welcome message - please implement!!!!!!!!!!!!!!!!");
    }

    private static void PrintTravelMessage() {
        Console.WriteLine("Travel message - please implement!!!!!!!!!!!!!!!!");
    }

    private static void PrintStartMessage() {
        Console.WriteLine("Start message - please implement!!!!!!!!!!!!!!!!");
    }

    private static void PrintInvalidCommandMessage() {
        Console.WriteLine("Invalid command message - please implement!!!!!!!!!!!!!!!!");
    }

    private static void PrintInvalidNameMessage()
    {
        Console.WriteLine("Invalid city name message - please implement!!!!!!!!!!!!!!!!"); 
    }

    private static void PrintMainCityDesc() {
        Console.WriteLine("Main City Message - please implement!!!!!!!!!!!!!!!!");
    }



}