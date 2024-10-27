namespace WorldOfZuul.CommandLogic;
using static Messages.Messages; 

public class CommandExecutor {
     //TODO: check if it is a naming convention
     
    public bool Execute(Command command, Player player) {
        if (command == null) {
            return false; 
        }
        
        switch (command.CommandType) {
            case "travel":
                return ExecuteTravel(command.Name, player, command.GameInstance);
            default:
                return ExecuteMain(command.Name, player, command.GameInstance);
        }
    }

    private bool ExecuteMain(string commandName, Player player, Game gameInstance) {
        switch (commandName.ToLower()) {
            case "travel":
                DisplayMessage("travel");
                gameInstance.ChangeCurrentLocation(gameInstance.TravelMenu); 
                break; 
            case "build":
                throw new NotImplementedException();
            case "help":
                DisplayMessage("help");
                break;
            case "menu":
                gameInstance.ChangeCurrentLocation(gameInstance.MainCity);
                break; 
            case "quit":
                gameInstance.EndGame();
                break; 
            case "look":
                gameInstance.CurrentRoom.ShowDescription();
                break;
            case "inventory":
                player.ShowInventory();
                break; 
            default:
                return false;
        }
        return true; 
    }


    private bool ExecuteTravel(string commandName, Player player, Game gameInstance) {
        switch (commandName.ToLower()) {
            case "0":
                throw new NotImplementedException();
            case "1":
                throw new NotImplementedException();
            case "2":
                throw new NotImplementedException();
            case "3":
                throw new NotImplementedException();
            case "4":
                throw new NotImplementedException();
            case "5":
                throw new NotImplementedException();
            case "6":
                throw new NotImplementedException();
            case "7":
                throw new NotImplementedException();
            case "back":
                gameInstance.ChangeCurrentLocation(gameInstance.MainCity);
                break;
            case "help": 
                DisplayMessage("help_travel");
                break; 
            default:
                return false;
        }
        return true;
    }
}
        