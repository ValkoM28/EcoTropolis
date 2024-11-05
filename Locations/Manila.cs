using System.Xml;
using static EcoTropolis.Messages.Messages;
using EcoTropolis.CommandLogic;

namespace EcoTropolis.Locations;

public class Manila : Location {
    private Game _game; 
    private Player _player;
    private string[] _commandWords = [];

    public string ProgressIndicator = "0"; 
    
    public Manila(Game game, Player player) : base("Manilla") {
        _player = player;
        _game = game;
    }

    
    public override void Play() {
        DisplayStartMessage();
        Console.ReadLine(); 
        
        bool playing = true;
        
        Parser parser = new(_commandWords, _game, this);
        CommandExecutor commandExecutor = new CommandExecutor();
        
        while (playing) {
            Console.Write("> ");
            string? input = Console.ReadLine();
            Command command = parser.GetCommand(input);
            
            if (!commandExecutor.Execute(command, _player)) {
                DisplayMessage("invalid_command");
                Console.ReadKey();
                continue;
            }
        }

    }
    
    public override void DisplayStartMessage() {
        Console.WriteLine("""
                          You find yourself in the bustling city of Manila, known for its rich history and vibrant culture. 
                          However, the city is currently facing the aftermath of a devastating natural disaster. 
                          As part of a pilot urban management project, your mission is to navigate through the city, 
                          make critical decisions, and help rebuild and strengthen Manila’s resilience.
                          
                          Press Enter to continue...  
                          """ );
    }
    
    private void diplayMessage(string messageID) {
        switch (messageID) {
            case "0":
                Console.WriteLine("");
                break; 
                
        }
    }
    
    

    public override void ShowDescription()
    {
        throw new NotImplementedException();
    }
    
    
    


}