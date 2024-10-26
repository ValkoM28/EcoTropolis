using WorldOfZuul.CommandLogic;
using WorldOfZuul.InventorySystem;
using WorldOfZuul.Locations;

using static WorldOfZuul.Messages.Messages;

namespace WorldOfZuul; 

public class Game {
    private Location? _currentRoom;
    
    private MainCity _mainCity;
    private TravelMenu _travelMenu; 
    //private Room? previousRoom; TODO: use this if we implement back command

    public Game(string cityName) {
        CreateRooms(cityName);
    }

    private void CreateRooms(string mainCityName) {
        _mainCity = new MainCity(mainCityName);
        _travelMenu = new TravelMenu(); 
        
        
        _currentRoom = _mainCity;
        
        
        //TODO: Create locations here
    }

    public void ChangeCurrentLocation(Location location) {
        _currentRoom = location; 
    }

    public void Play() {
        Parser parserMain = new("main");
        Parser parserTravel = new("travel");

        Player player = new(new Inventory(), _mainCity); 

        CommandExecutor commandExecutor = new(); 

        PrintWelcome();

        bool continuePlaying = true;

        while (continuePlaying)
        {
            Console.WriteLine(_currentRoom?.Name); //rework
            
            Console.Write("> ");

            string? input = Console.ReadLine();
            Command command;
            switch (_currentRoom?.Name) {
                case "Travel Menu":
                    command = parserTravel.GetCommand(input);
                    break;
                default:
                    command = parserMain.GetCommand(input);
                    break; 
            }

            if (!commandExecutor.Execute(command, player)) {
                DisplayMessage("invalid_command");
                continue; 
            }

            Console.WriteLine("command not null :)");

        }

        Console.WriteLine("Thank you for playing World of Zuul!");
    }
    /*
    private void Move(string direction) {
        if (currentRoom?.Exits.ContainsKey(direction) == true)
        {
            //previousRoom = currentRoom;  
            currentRoom = currentRoom?.Exits[direction];
        }
        else
        {
            Console.WriteLine($"You can't go {direction}!");
        }
    }
    */
    
    public bool Travel() {
        DisplayMessage("travel");
        return true; 
    }

    private static void PrintWelcome() {
        DisplayMessage("welcome");
        PrintHelp();
    }

    private static void PrintHelp() {
        DisplayMessage("help");
    }
}

