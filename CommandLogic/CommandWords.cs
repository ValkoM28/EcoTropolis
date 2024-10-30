namespace EcoTropolis.CommandLogic; 

public class CommandWords {
    private string[] validCommandsCity { get; } = ["travel", "build", "help", "menu", "quit", "look", "inventory"];
    private string[] validCommandsTravel { get; } = [ "0", "1", "2", "3", "4", "5", "6", "help" ];
    private string[] validCommandsShop { get; } = ["buy", "sell", "back", "look", "help"];
    
    public string[] ValidCommands; 
    //public List<string> ValidCommandsRole { get; } = new List<string> { };
    // "inspect" - inspect a building in the main city - 2nd iteration probably
    public CommandWords(string whichList) {
        switch (whichList) {
            case "main":
                ValidCommands = validCommandsCity;
                break;
            case "travel":
                ValidCommands = validCommandsTravel;
                break;
            case "pawn_shop":
                ValidCommands = validCommandsShop;
                break; 
            default:
                ValidCommands = null;
                break; //TODO: do not keep it like this
        }
    }

    public bool IsValidCommand(string command) {
        return ValidCommands.Contains(command);
    }
}

