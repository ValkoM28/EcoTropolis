using EcoTropolis.InventorySystem;


namespace EcoTropolis.Messages;

public static class Messages
{

    public static void DisplayMessage(string messageType, string? cityName = null)
    {
        switch (messageType)
        {
            case "help":
                PrintHelpMessageMain();
                break;
            case "help_travel": 
                PrintHelpMessageTravel();
                break;
            case "welcome":
                PrintWelcomeMessage(cityName);
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
            case "game_end":
                PrintEndMessage();
                break;
        }
    }

    public static void DisplayDescription(string roomName)
    {
        switch (roomName)
        {
            case "main_city":
                PrintMainCityDesc();
                break;
            case "travel_menu":
                PrintTravelMessage();
                break;

        }
    }

    

    private static void PrintHelpMessageMain()
    {
        Console.WriteLine("Main menu help message - please implement!!!!!!!!!!!!!!!!");
    }

    public static void PrintHelpMessageTravel()
    {
        Console.WriteLine("Travel menu help message - please implement!!!!!!!!!!!!!!!!");
    }

    private static void PrintWelcomeMessage(string cityName)
    {
        Console.WriteLine($"Welcome to {cityName} mr. newly elected mayor \n" +
                          "Thanks to our new programme called EcoTropolis you can help our city by helping others ;)\n" +
                          "In case you need any help, type \"Help\"" );
    }

    private static void PrintTravelMessage() // travel message
    {
        Console.WriteLine("Travel message - please implement!!!!!!!!!!!!!!!!");
    }

    private static void PrintStartMessage() // start message
    {
        Console.WriteLine("Welcome to Ecotropolis – the city-building adventure where your decisions shape the future!\n\n" +
                        "As a visionary leader, you'll travel to different cities, taking on roles like mayor, corporate CEO, or urban planner.\n" +
                        "Each city faces unique environmental and urban challenges that only you can solve.\n" +
                        "Complete quests to earn rewards that you can use to design and build your own perfect, sustainable city.\n" +
                        "Can you balance progress with preservation and create a thriving, green metropolis?\n" +
                        "The fate of Ecotropolis is in your hands!\n");
              
    }

    private static void PrintInvalidCommandMessage() // invalid command message
    {
        Console.WriteLine("Invalid command message - please implement!!!!!!!!!!!!!!!!");
    }

    private static void PrintInvalidNameMessage() // invalid city name message
    {
        Console.WriteLine("Invalid city name message - please implement!!!!!!!!!!!!!!!!");
    }

    private static void PrintMainCityDesc() //main city message
    {
        Console.WriteLine("Main City Message - please implement!!!!!!!!!!!!!!!!");
    }

    public static void PrintEndMessage() //end of game message
    {
        Console.WriteLine("End of game Message - please implement!!!!!!!!!!!!!!!!");
    }



}