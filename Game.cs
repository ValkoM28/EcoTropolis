using System.Runtime.CompilerServices;
using WorldOfZuul.CommandLogic;
using WorldOfZuul.InventorySystem;
using WorldOfZuul.Locations;

using static WorldOfZuul.Messages.Messages;

namespace WorldOfZuul; 

public class Game {
    /* This it the main class of the game EcoTropolis.
     * This class contains the main game loop, that gets a text input, parses that as a command and then tries to execute the command.
     * Properties: */
    public Location? CurrentRoom;  // Stores the current location of the game
    public TravelMenu TravelMenu { get; private set; }  //Instance of TravelMenu class, used by the CommandExecutor, to enable travel
    //Attributes of the TravelMenu class: TODO:to be implemented and put here
    public MainCity MainCity { get; private set; }  //Instance of MainCity class, holds players main city and its properties
    //Attributes of the MainCity class:  TODO:to be implemented and put here
    
    private bool _continuePlaying; //boolean used to start and stop the game
     
    /*
     * The solemn purpose (at least for now) of the constructor of the Game class is to initialize all the locations of the game. 
     */
    public Game(string cityName) {
        CreateRooms(cityName);
    }
    
    /*
     * This is where all locations are instantiated. 
     */
    private void CreateRooms(string mainCityName) {
        MainCity = new MainCity(mainCityName);
        TravelMenu = new TravelMenu();
        CurrentRoom = MainCity;
        
        
        //TODO: Create locations here
    }
    
    /*
     * Simple method to change the current location outside the Game class. 
     */
    public void ChangeCurrentLocation(Location location) {
        CurrentRoom = location; 
    }


    public void Play() {
        /* Main game loop
         * Used variables: */
        Parser parserMain = new("main", this);  //parser for handling commands in the main menu
        Parser parserTravel = new("travel", this); //parser for handling commands in the travel menu
        //every Parser takes string as a differentiating parameter and instance of the Game class
        //using another data type to differentiate between the parsers would be more adequate, but it does not matter much on such a small scale. 
        //TODO:Implement parsers for other locations
        
        Player player = new(new Inventory()); //Player class that is used in command executions for now, might be used in a different way or eliminated completely TODO: decide the faith of the Player class
        //takes Inventory as its only parameter
        
        CommandExecutor commandExecutor = new();  
        Command command; 
        
        DisplayMessage("welcome", MainCity.Name);
        DisplayMessage("help");

        _continuePlaying = true;

        while (_continuePlaying)
        {
            Console.WriteLine("\n----------\n");
            CurrentRoom.DisplayStartMessage(); 
            
            Console.Write("> ");

            string? input = Console.ReadLine();
            
            switch (CurrentRoom.GetType()) {
                case Type t when t == typeof(TravelMenu):
                    //Console.WriteLine(t);
                    //Console.WriteLine(typeof(TravelMenu));
                    command = parserTravel.GetCommand(input);
                    break;
                default:
                    command = parserMain.GetCommand(input);
                    break; 
            }

            if (!commandExecutor.Execute(command, player)) {
                DisplayMessage("invalid_command");
                Console.ReadKey();
                continue; 
            }
            
        }

        DisplayMessage("game_end");
    }

    public void EndGame() {
        _continuePlaying = false; 
    }
    
}

