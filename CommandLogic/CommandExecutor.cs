using System.Runtime.CompilerServices;
using EcoTropolis.Locations;

namespace EcoTropolis.CommandLogic;
using static EcoTropolis.Messages.Messages; 

public class CommandExecutor {
     //TODO: check if it is a naming convention
     
    public bool Execute(Command command, Player player) {
        if (command == null) {
            return false; 
        }

 
        switch (command.CommandLocation.GetType()) {
            case Type t when t == typeof(TravelMenu):
                return ExecuteTravel(command.Name, player, command.GameInstance);
            case Type t when t == typeof(PawnShop):
                return ExecuteShop(command, player, command.GameInstance); 
            
            
            case Type t when t == typeof(SampleSpecificLocation):
                return ExecuteShop(command, player, command.GameInstance); 
            case Type t when t == typeof(SampleSpecificLocation):
                return ExecuteShop(command, player, command.GameInstance); 
            case Type t when t == typeof(SampleSpecificLocation):
                return ExecuteShop(command, player, command.GameInstance); 
            case Type t when t == typeof(SampleSpecificLocation):
                return ExecuteShop(command, player, command.GameInstance); 
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


    public bool ExecuteTravel(string commandName, Player player, Game gameInstance) {
        switch (commandName.ToLower()) {
            case "1":
                gameInstance.ChangeCurrentLocation(gameInstance.LosAngeles);
                break; 
            case "2":
                gameInstance.ChangeCurrentLocation(gameInstance.Barcelona);
                break;
            case "3":
                gameInstance.ChangeCurrentLocation(gameInstance.Tokyo);
                break; 
            case "4":
                gameInstance.ChangeCurrentLocation(gameInstance.SaoPaulo);
                break; 
            case "5":
                gameInstance.ChangeCurrentLocation(gameInstance.Amsterdam);
                break;
            case "6":
                gameInstance.ChangeCurrentLocation(gameInstance.Manilla);
                break; 
            default:
                return false; 
        }
        return true;
    }
    private bool ExecuteShop(Command command, Player player, Game gameInstance) {
        switch (command.Name.ToLower()) {
            case "buy":
                gameInstance.PawnShop.BuyItem(command.SecondWord, player);
                Console.WriteLine("here");
                break; 
            case "sell":
                throw new NotImplementedException();
            case "back":
                gameInstance.ChangeCurrentLocation(gameInstance.TravelMenu);
                break;
            case "look":
                throw new NotImplementedException();
            case "help":
                throw new NotImplementedException();
            default:
                return false; 
        }
        return true;

    }

    /*
     * This is an example of command executor for one specific location.
     */
    private bool ExecuteManilla(Command command, Player player, Game gameInstance) {
        switch (command.Name.ToLower()) {
            case "buy":
                gameInstance.PawnShop.BuyItem(command.SecondWord, player);
                Console.WriteLine("here");
                break;
            case "sell":
                throw new NotImplementedException();
            case "back":
                gameInstance.ChangeCurrentLocation(gameInstance.TravelMenu);
                break;
            case "look":
                throw new NotImplementedException();
            case "help":
                throw new NotImplementedException();
            default:
                return false;
        }

        return true;
    } 


        private bool ExecuteAmsterdam(Command command, Player player, Game gameInstance) {
        switch (command.Name.ToLower()) {
            case "buy":
                gameInstance.PawnShop.BuyItem(command.SecondWord, player);
                Console.WriteLine("here");
                break;
            case "sell":
                throw new NotImplementedException();
            case "back":
                gameInstance.ChangeCurrentLocation(gameInstance.TravelMenu);
                break;
            case "look":
                throw new NotImplementedException();
            case "help":
                throw new NotImplementedException();
            case "metro":
            return true;

    private bool ExecuteSaoPaulo(Command command, Player player, Game gameInstance) {
        switch (command.Name.ToLower()) {
            case "look":
                throw new NotImplementedException();
            case "start":
                SaoPauloMessages.PrintStartMessage();
                break;
            case "help":
                throw new NotImplementedException();

            default:
                return false;
        }

        return true;

    } 


}
        