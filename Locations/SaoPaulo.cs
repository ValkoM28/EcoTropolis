using System.Xml;
using EcoTropolis.CommandLogic;
using EcoTropolis.Maps;

namespace EcoTropolis.Locations;

public class SaoPaulo : Location {
    // Private fields to store the game instance, player instance, and command words
    private Game _game; 
    private Player _player;
    private string[] _commandWords = {}; // Initialize the array properly
    
    // Constructor to initialize the SaoPaulo location with the game and player instances
    public SaoPaulo(Game game, Player player) : base("SaoPaulo") {
        _player = player;
        _game = game;
    }

    // Override the Play method to define the behavior when the player is in SaoPaulo
    public override void Play() {
        // Create an instance of the world map for South America
        MapSouthAmerica worldMap = new();
        // Clear the console
        Console.Clear();
        // Display the map
        worldMap.DisplayMap();
        // Display the start message for SaoPaulo
        DisplayStartMessage();
        // Set a flag to keep the game loop running
        bool playing = true;
        // Create a parser instance with the command words, game, and current location
        Parser parser = new(_commandWords, _game, this);

        // Create an instance of CommandExecutor to handle commands
        CommandExecutor commandExecutor = new CommandExecutor(); 
        // Game loop
        while (playing) {
            // Game loop logic here
        }
    }
    
    // Override the DisplayStartMessage method to show a message when the player enters SaoPaulo
    public override void DisplayStartMessage() {
        Console.WriteLine("\nYou are now in SaoPaulo. \n" +
                          "Type \"Look\" to see the details of this city.\n" +
                          "Type \"Help\" to see additional commands ");
    }

    // Override the ShowDescription method to provide a description of SaoPaulo
    public override void ShowDescription() {
        throw new NotImplementedException();
    }
}