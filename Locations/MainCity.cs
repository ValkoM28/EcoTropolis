using EcoTropolis.CommandLogic;
using static EcoTropolis.Messages.Messages;

namespace EcoTropolis.Locations;

public class MainCity : Location {
    public Dictionary<string, Location> Exits { get; }
    private Game _game;
    private Player _player; 
    
    public MainCity(string name, Game game, Player player) : base(name) {
        _game = game;
        _player = player; 
    }

    
    public override void DisplayStartMessage() {
        Console.WriteLine("You are now in your own city. \n" +
                          "Type \"Look\" to see the details of the city.\n" +
                          "Type \"Help\" to see additional commands ");
    }

    public override void Play()
    {
        
    }

    public override bool ExecuteCommand(Command command)
    {
        throw new NotImplementedException();
    }

    public override void ShowDescription() {
        DisplayMessage("main_city");
    }

    public void ListBuildings() {
        throw new NotImplementedException(); 
    } 
    
    


}