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
        Parser parser = new( this);

         
        
        bool playing = true;
        
        DisplayStartMessage();
        Command command;

        while (playing) { //game happens
            string? input = Console.ReadLine();
            command = parser.GetCommand(input, _commandWords);
            
            
            
        } _game.ChangeCurrentLocation(_game.TravelMenu);


    }

    public override bool ExecuteCommand(Command command)
    {
        throw new NotImplementedException();
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