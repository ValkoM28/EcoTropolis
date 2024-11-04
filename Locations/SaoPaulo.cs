using System.Xml;
using EcoTropolis.CommandLogic;
using EcoTropolis.Maps;

namespace EcoTropolis.Locations;

public class SaoPaulo : Location {
    private Game _game; 
    private Player _player;
    private string[] _commandWords = []; 
    
    public SaoPaulo(Game game, Player player) : base("SaoPaulo") {
        _player = player;
        _game = game;
    }

    
    public override void Play() {

        MapSouthAmerica worldMap = new();
        Console.Clear();
        worldMap.DisplayMap();
        DisplayStartMessage();
        bool playing = true;
        Parser parser = new(_commandWords, _game, this);

        CommandExecutor commandExecutor = new CommandExecutor(); 
        while (playing) {
            
        }

    }
    
    
    public override void DisplayStartMessage() {
        Console.WriteLine("\nYou are now in SaoPaulo. \n" +
                          "Type \"Look\" to see the details of this city.\n" +
                          "Type \"Help\" to see additional commands ");
    }

    public override void ShowDescription()
    {
        throw new NotImplementedException();
    }


}