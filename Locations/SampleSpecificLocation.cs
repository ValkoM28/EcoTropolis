﻿using EcoTropolis.CommandLogic;
using EcoTropolis.InventorySystem;
using static EcoTropolis.Messages.Messages;

namespace EcoTropolis.Locations;

public class SampleSpecificLocation : Location {
    private string[] _commandWords = [];
    private Game _game;

    private Player _player; 
    //public Dictionary<string, Location> Exits { get; }
    
    public SampleSpecificLocation(string name, Game game, Player player) : base(name) {
        _game = game;
        _player = player;
    }

    public override void Play() {
        Parser parser = new(_commandWords, _game, this);

        CommandExecutor commandExecutor = new CommandExecutor(); 
        
        bool playing = true;
        
        DisplayStartMessage();
        Command command;

        while (playing) { //game happens
            string? input = Console.ReadLine();
            command = parser.GetCommand(input);
            
        /*
         * commandExecutor.Execute() returns value true, when the command was valid and false, when it was not,
         * if the command is not valid, print the invalid command message and try again.
         */
            if (!commandExecutor.Execute(command, _player)) {
                DisplayMessage("invalid_command");
                Console.ReadKey();
                continue;
            }
            
            
            
        } _game.ChangeCurrentLocation(_game.TravelMenu);


    }

public override void DisplayStartMessage() {

}

public void DisplayEndMessage()
{

}




public override void ShowDescription() {
throw new NotImplementedException();
}

}