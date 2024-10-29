using System.Runtime.CompilerServices;
using EcoTropolis.CommandLogic;
using EcoTropolis.InventorySystem;
using EcoTropolis.Locations;
using static EcoTropolis.Messages.Messages;

namespace EcoTropolis; 

public class Game {
    /* This it the main class of the game EcoTropolis.
     * This class contains the main game loop, that gets a text input, parses that as a command and then tries to execute the command.
     * Properties: */
    public Location? CurrentRoom;  // Stores the current location of the game
    
    /*
     * Placeholders for all the locations
     * TODO: Rework this as either a List or a Dictionary (or a HashMap)
     */
    public TravelMenu TravelMenu { get; private set; }  //Instance of TravelMenu class, used by the CommandExecutor, to enable travel
    //Attributes of the TravelMenu class: TODO:to be implemented and put here
    public MainCity MainCity { get; private set; }  //Instance of MainCity class, holds player's main city and its properties
    //Attributes of the MainCity class:  TODO:to be implemented and put here
    public PawnShop PawnShop { get; private set;  }  //Instance of PawnShop class, holds items available to buy and also serves for a player to sell their items
    //Attributes of the PawnShop class:  TODO:to be implemented and put here
    
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
        PawnShop = new PawnShop(); 
        
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
        Parser parserPawnShop = new("pawn_shop", this); //parser for handling commands in the pawn shop
        //every Parser takes string as a differentiating parameter and instance of the Game class
        //using another data type to differentiate between the parsers would be more adequate, but it does not matter much on such a small scale. 
        //TODO:Implement parsers for other locations
        
        Player player = new(new Inventory(this)); //Player class that is used in command executions for now, might be used in a different way or eliminated completely TODO: decide the faith of the Player class
        //takes Inventory as its only parameter
        
        CommandExecutor commandExecutor = new();  //Creates a new CommandExecutor object, with one public method Execute()
                                                  //This method takes Command and Player objects as arguments and returns true if the command is executed successfully
        Command command; //placeholder for a local variable command
        
        DisplayMessage("welcome", MainCity.Name);  //Displaying the welcome message //TODO: this is not ideal, needs a rework
        DisplayMessage("help");

        _continuePlaying = true; //variable used for killing the game

        /*
         * This is the main loop of the game, that is responsible for handling inputs from the player.
         * It is instantiated automatically with the method Play() and is broken when the variable _continuePlaying is set to false by EndGame() method.
         */
        while (_continuePlaying){
            Console.WriteLine("\n----------\n");  
            CurrentRoom.DisplayStartMessage();  //Displays the starting message/description of the current location
            
            Console.Write("> ");  //just for formatting

            string? input = Console.ReadLine(); //takes the input from the user
            
            /*
             * This switch statement checks the instance of the CurrentRoom field(variable) and uses associated parser to execute the command
             */
            switch (CurrentRoom.GetType()) {  
                case Type t when t == typeof(TravelMenu):
                    command = parserTravel.GetCommand(input);
                    break;
                case Type t when t == typeof(PawnShop):
                    command = parserPawnShop.GetCommand(input);
                    break; 
                default:
                    command = parserMain.GetCommand(input);
                    break; 
            }
            
            /*
             * commandExecutor.Execute() returns value true, when the command was valid and false, when it was not,
             * if the command is not valid, print the invalid command message and try again.
             */
            if (!commandExecutor.Execute(command, player)) {
                DisplayMessage("invalid_command");
                Console.ReadKey();
                continue; 
            }
            //TODO: I dont know, if we  need anything here, but we should check.
        }

        DisplayMessage("game_end");  //After the game was ended and the while loop is terminated, prints a message.
    }

    
    /*
     * Public method that just terminates the while loop in the Play() method.
     */
    public void EndGame() {
        _continuePlaying = false; 
    }
    
}

