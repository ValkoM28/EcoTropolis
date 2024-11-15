using EcoTropolis.CommandLogic;
using EcoTropolis.InventorySystem;
using static EcoTropolis.Messages.Messages;

namespace EcoTropolis.Locations;

public class LosAngeles : Location {
    private string[] _commandWords = ["look", "help", "metro", "meeting"];
    private Game _game;

    private Player _player; 
    //public Dictionary<string, Location> Exits { get; }
    
    public LosAngeles(Game game, Player player) : base("LosAngeles") {
        _game = game;
        _player = player;
    }

    public override void Play() {
        DisplayStartMessage();
        Parser parser = new(_commandWords, _game, this);

        CommandExecutor commandExecutor = new CommandExecutor(); 
        
        bool playing = true;
        
        
        Command command;

        while (playing) { //game happens
            string? input = Console.ReadLine(); // TODO:implement commands to execute for LA
            command = parser.GetCommand(input);
            Console.WriteLine(commandExecutor.Execute(command, _player));
            DisplayStartMessage();
            DisplayEndMessage();
            
        /*
         * commandExecutor.Execute() returns value true, when the command was valid and false, when it was not,
         * if the command is not valid, print the invalid command message and try again.
         */
            
            if (!commandExecutor.Execute(command, _player)) 
            {
                DisplayMessage("invalid_command");
                Console.ReadKey();
                continue;
            }
            
            
            
        } _game.ChangeCurrentLocation(_game.TravelMenu);


    }

    public override void DisplayStartMessage() {
        Console.WriteLine("test start");
    }

    public void DisplayEndMessage(){
        Console.WriteLine("test end");
    }




    public override void ShowDescription() {
        Console.WriteLine("descrip.");
    }

}