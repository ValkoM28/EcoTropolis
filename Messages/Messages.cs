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

    public static class SaoPauloMessages
    {
        public static void PrintStartMessage()
        {
            Console.WriteLine("Welcome, Mayor of São Paulo!\n\n" +
                          "As the newly appointed leader of this sprawling metropolis, you’re taking the wheel in a city that never sleeps — and sometimes barely moves.\n" +
                          "São Paulo’s traffic is infamous, a daily maze of gridlocks, crowded buses, honking horns, and frustrated commuters. From the bustling avenues of Paulista to\n" +
                          "the quiet outskirts, your citizens need solutions. Can you reduce congestion, improve public transit, and make the city greener?\n\n" +
                          "Every decision you make will impact millions, and your success will be measured by the flow of traffic and the satisfaction of the people. Will you master the challenges of São Paulo’s streets and create a city that moves for everyone?\n\n" +
                          "The road ahead is yours, Mayor.");
        }

        public static void PrintSuccessMessage()
        {
            Console.WriteLine("Congratulations! You have successfully implemented sustainable solutions in São Paulo.");
        }

        public static void PrintFailureMessage()
        {
            Console.WriteLine("Unfortunately, your efforts in São Paulo did not yield the desired results. Try again to find better solutions.");
        }
    }


    private static void PrintInvalidCommandMessage() // invalid command message
    {
        Console.WriteLine("Invalid command message, please try again");
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