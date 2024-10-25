namespace WorldOfZuul.Messages;

public static class Messages {

    public static void DisplayMessage(string messageType) {
        switch (messageType) {
            case "help":
                printHelpMessage();
                break; 
            case "welcome": 
                printWelcomeMessage();
                break; 
            case "travel": 
                printTravelMessage();
                break;
        }
    }

    private static void printHelpMessage() {
        Console.WriteLine("You are lost. You are alone. You wander");
        Console.WriteLine("around the university.");
        Console.WriteLine();
        Console.WriteLine("Navigate by typing 'north', 'south', 'east', or 'west'.");
        Console.WriteLine("Type 'look' for more details.");
        Console.WriteLine("Type 'back' to go to the previous room.");
        Console.WriteLine("Type 'help' to print this message again.");
        Console.WriteLine("Type 'quit' to exit the game.");
    }

    private static void printWelcomeMessage() {
        Console.WriteLine("Welcome message - please implement!!!!!!!!!!!!!!!!");
    }

    private static void printTravelMessage() {
        Console.WriteLine("Travel message - please implement!!!!!!!!!!!!!!!!");
    }



}