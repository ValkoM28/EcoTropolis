using System.Xml;
using EcoTropolis.CommandLogic;

namespace EcoTropolis.Locations;

public class Manilla : Location {
    private Game _game; 
    private Player _player;
    private string[] _commandWords = []; 
    
    public Manilla(Game game, Player player) : base("Manilla") {
        _player = player;
        _game = game;
    }

    
    public override void Play() {
        DisplayStartMessage();
        bool playing = true;
        Parser parser = new(_commandWords, _game, this);

        CommandExecutor commandExecutor = new CommandExecutor(); 
        while (playing) {
            
        }

    }
    
    
    public override void DisplayStartMessage() {
        Console.WriteLine("You are now in Manilla. \n" +
                          "Type \"Look\" to see the details of the city.\n" +
                          "Type \"Help\" to see additional commands ");
    }

    public override void ShowDescription()
    {
        throw new NotImplementedException();
    }


}