using EcoTropolis.CommandLogic;
using EcoTropolis.InventorySystem;
using static EcoTropolis.Messages.Messages;

namespace EcoTropolis.Locations;

public class Amsterdam : Location {
    private string[] _commandWords = [look, help, metro, meeting];
    private Game _game;

    private Player _player; 
    //public Dictionary<string, Location> Exits { get; }
    
    public Amsterdam(string name, Game game, Player player) : base(name) {
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
Console.WriteLine("The next location your major assigned you to go is The Netherlands,\n" +
                  "the land of canals, tulips, windmills, and bicycles. Your major is\n" +
                   "amazed by its landscapes and cultural icons and wants you to learn\n" +
                   "the good things this city could bring to your city. You arrive at\n" +
                   "Amsterdam Airport Schiphol and take a train to the city center.\n" +
                   "\n" +
                   "Type \"metro\" to go to the city center");

}

public void DisplayEndMessage()
{

}




public override void ShowDescription() {
throw new NotImplementedException();
}

}