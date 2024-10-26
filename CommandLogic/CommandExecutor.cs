namespace WorldOfZuul.CommandLogic;
using static Messages.Messages; 

public class CommandExecutor {
     //TODO: check if it is a naming convention
    
    public bool Execute(Command command, Player player) {
        if (command == null) {
            return false; 
        }
        
        switch (command.CommandType) {
            case "Travel Menu":
                return ExecuteTravel(command.Name, player);
            default:
                return ExecuteMain(command.Name, player);
        }
    }

    private bool ExecuteMain(string commandName, Player player) {
        switch (commandName) {
            case "travel":
                throw new NotImplementedException();
            case "build":
                throw new NotImplementedException();
            case "help":
                DisplayMessage("help");
                return true;
            case "menu":
                throw new NotImplementedException();
            case "quit":
                throw new NotImplementedException();
            case "look":
                throw new NotImplementedException();
            case "inventory":
                player.ShowInventory();
                return true; 
            default:
                return false;
        }
    }


    private bool ExecuteTravel(string commandName, Player player) {
        switch (commandName) {
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
                throw new NotImplementedException();
            default:
                return false;
        }
    }
}
        