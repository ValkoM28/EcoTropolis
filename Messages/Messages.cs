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


    public static void DisplayHappinessLevel(HappinessIndicator happinessIndicator)
    {
        throw new NotImplementedException();
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

    private static void PrintTravelMessage()
    {
        Console.WriteLine("Travel message - please implement!!!!!!!!!!!!!!!!");
    }

    private static void PrintStartMessage()
    {
        Console.WriteLine("Start message - please implement!!!!!!!!!!!!!!!!");
    }

    private static void PrintInvalidCommandMessage()
    {
        Console.WriteLine("Invalid command message - please implement!!!!!!!!!!!!!!!!");
    }

    private static void PrintInvalidNameMessage()
    {
        Console.WriteLine("Invalid city name message - please implement!!!!!!!!!!!!!!!!");
    }

    private static void PrintMainCityDesc()
    {
        Console.WriteLine("Main City Message - please implement!!!!!!!!!!!!!!!!");
    }

    public static void PrintEndMessage()
    {
        Console.WriteLine("End of game Message - please implement!!!!!!!!!!!!!!!!");
    }



}