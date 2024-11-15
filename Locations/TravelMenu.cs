using EcoTropolis.CommandLogic;
using static EcoTropolis.Messages.Messages;
namespace EcoTropolis.Locations;

public class TravelMenu : Location {
    
    public string Description { get; } = ""; 
    public Dictionary<string, Location> Exits { get; }
    private string[] _commandWords = [ "0", "1", "2", "3", "4", "5", "6", "help" ];
    private Game _game;
    private Player _player; 
    
    
    public TravelMenu(Game game, Player player) : base("Travel Menu")
    {
        _game = game;
        _player = player; 
    }
    public override void Play() {
        Parser parser = new(_game, this);
        CommandExecutor commandExecutor = new CommandExecutor(); 
        
        bool playing = true;
        
        DisplayStartMessage();
        Command command;

        while (playing) { //game happens
            string? input = Console.ReadLine();
            command = parser.GetCommand(input, _commandWords);

            playing = false; 
            
            if (!commandExecutor.Execute(command, _player))
            {
                playing = true; 
                DisplayMessage("invalid_command");
                Console.ReadKey();
            }
            
        }
    }
    public override void DisplayStartMessage() {
        

        string welcome = """
                         Welcome to the travel menu:  
                         Pick the location of your next journey
                         1 - Los Angeles
                         2 - Barcelona
                         3 - Tokyo
                         4 - Sao Paulo
                         5 - Amsterdam
                         6 - Manilla
                         
                         """;
        
        Console.WriteLine(welcome);
    }
    

    public override void ShowDescription() {
        throw new NotImplementedException();
    }
}