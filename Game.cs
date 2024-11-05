
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
    private Player _player;  
    private bool _continuePlaying;
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
    
    public SampleSpecificLocation LosAngeles { get; private set;  }
    public SampleSpecificLocation Barcelona { get; private set;  }
    public SampleSpecificLocation Tokyo { get; private set;  }

    public SaoPaulo SaoPaulo { get; private set;  }    
    public Manilla Manilla { get; private set;  }
    public Amsterdam Amsterdam { get; private set; }    
    
    public SampleSpecificLocation Location { get; private set;  }
     //boolean used to start and stop the game
     
    /*
     * The solemn purpose (at least for now) of the constructor of the Game class is to initialize all the locations of the game. 
     */
    public Game(string cityName) {
        _player = new Player(new Inventory(this)); 
        CreateRooms(cityName);
    }
    
    /*
     * This is where all locations are instantiated. 
     */
    private void CreateRooms(string mainCityName) {
        Manilla = new Manilla(this, _player);
        Amsterdam = new Amsterdam(this, _player);
        SaoPaulo = new SaoPaulo(this, _player);
        
        MainCity = new MainCity(mainCityName, this, _player);
        TravelMenu = new TravelMenu(this, _player);
        PawnShop = new PawnShop();
        
       
        
        //TODO: Create locations here
    }
    
    /*
     * Simple method to change the current location outside the Game class. 
     */
    public void ChangeCurrentLocation(Location location) {
        CurrentRoom = location; 
        CurrentRoom.Play();
    }


    public void Play() {
        /* Main game loop
         * Used variables: */
        
        DisplayMessage("welcome", MainCity.Name);  //Displaying the welcome message //TODO: this is not ideal, needs a rework
        DisplayMessage("help");
        
        ChangeCurrentLocation(TravelMenu); //Starting the game in the TravelMenu location
        /*
        _continuePlaying = true; //variable used for killing the game
        while (_continuePlaying){
             CurrentRoom.Play();
        }*/

        DisplayMessage("game_end");  //After the game was ended and the while loop is terminated, prints a message.
    }

    
    /*
     * Public method that just terminates the while loop in the Play() method.
     */
    public void EndGame() {
        _continuePlaying = false; 
    }
    
}

