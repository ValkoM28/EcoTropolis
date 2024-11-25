using EcoTropolis.CommandLogic;
using static EcoTropolis.Messages.Messages;
namespace EcoTropolis.Locations;

public class TravelMenu : Location {
    
    public string Description { get; } = "Travel menu description dummy text"; 
    private string[] _commandWords = [ "0", "1", "2", "3", "4", "5", "6", "help" ];
    private Game _game;
    private Player _player; 
    
    
    public TravelMenu(Game game, Player player) : base("Travel Menu") {
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
            
            if (ExecuteCommand(command)) {
                DisplayMessage("invalid_command");
                Console.ReadKey();
                continue;
            }
            playing = false;
        }
    }

    public override bool ExecuteCommand(Command command) {
        //TODO: delete a location after it was finished 
        
        if (command == null) {
            return false;
        }
        switch (command.Name.ToLower()) {
            case "1":
                _game.ChangeCurrentLocation(_game.LosAngeles);
                break; 
            case "2":
                _game.ChangeCurrentLocation(_game.Barcelona);
                break;
            case "3":
                _game.ChangeCurrentLocation(_game.Tokyo);
                break; 
            case "4":
                _game.ChangeCurrentLocation(_game.SaoPaulo);
                break; 
            case "5":
                _game.ChangeCurrentLocation(_game.Amsterdam);
                break;
            case "6":
                _game.ChangeCurrentLocation(_game.Manila);
                break; 
            case "help":
                DisplayStartMessage();
                break;
            default:
                return false; 
        }
        return true;
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