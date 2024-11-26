using System.Xml;
using static EcoTropolis.Messages.Messages;
using EcoTropolis.CommandLogic;
using EcoTropolis.InventorySystem;

namespace EcoTropolis.Locations;

public class LosAngeles : Location {
    private Game _game; 
    private Player _player;
    private string[] _commandWords = ["1", "2", "3", "help"];
    
    private List<DecisionPoint> _decisionPoints = new List<DecisionPoint>();
    
    public LosAngeles(Game game, Player player) : base("Los Angeles") {
        _player = player;
        _game = game;
        CreateDecisionPoints();
    }

    private void CreateDecisionPoints() {
        DecisionPoint decisionPoint1 = new DecisionPoint("City Planning Meeting",
            "You are attending a city planning meeting focused on sustainable development in Los Angeles."); 
        decisionPoint1.AddOption("1", "Approve a new urban housing project", 0);
        decisionPoint1.AddOption("2", "Delay the project for environmental studies", 0);
        decisionPoint1.AddOption("3", "Cancel the project entirely", 0);
        _decisionPoints.Add(decisionPoint1);
        
       DecisionPoint decisionPoint2 = new DecisionPoint("Infrastructure Discussion",
            "You are discussing earthquake resilience measures for public infrastructure."); 
        decisionPoint2.AddOption("1", "Invest in retrofitting older buildings", 0);
        decisionPoint2.AddOption("2", "Prioritize emergency response systems", 0);
        decisionPoint2.AddOption("3", "Cut costs and do minimal upgrades", 0);
        _decisionPoints.Add(decisionPoint2);
        
        DecisionPoint decisionPoint3 = new DecisionPoint("Traffic Congestion Debate",
            "You are addressing traffic congestion issues in the city."); 
        decisionPoint3.AddOption("1", "Expand public transportation", 0);
        decisionPoint3.AddOption("2", "Build more highways", 0);
        decisionPoint3.AddOption("3", "Introduce congestion charges", 0);
        _decisionPoints.Add(decisionPoint3);
        
        DecisionPoint decisionPoint4 = new DecisionPoint("Community Development Forum",
            "You are leading a forum on improving green spaces and reducing pollution."); 
        decisionPoint4.AddOption("1", "Build a new park in a low-income area", 0);
        decisionPoint4.AddOption("2", "Implement stricter air quality regulations", 0);
        decisionPoint4.AddOption("3", "Focus on attracting more businesses instead", 0);
        _decisionPoints.Add(decisionPoint4);
    }
    
    
    public override void Play() {
        DisplayStartMessage();
        Console.ReadLine(); 
        
        Parser parser = new(_game, this);
        
        int i = 0; 
        DecisionPoint currentDecisionPoint;

        while (i < _decisionPoints.Count) {
            if (i == _decisionPoints.Count) {
                break;  
            }
            currentDecisionPoint = _decisionPoints[i];
            
            currentDecisionPoint.DisplayOptions();
            Console.Write("> ");
            
            string? input = Console.ReadLine();
            Command command = parser.GetCommand(input, _commandWords);
            
            if (!ExecuteCommand(command)) {
                DisplayMessage("invalid_command");
                Console.ReadKey();
                continue;
            }
            i++;
          
            
        }
        _game.ChangeCurrentLocation(_game.TravelMenu);
        // set this location as not playable again
    }

    public override bool ExecuteCommand(Command command) {
        if (command == null) {
            return false;
        }
        
        switch (command.Name.ToLower()) {
            case "1":
                break; 
            case "2":
                break;
            case "3":
                break; 
            case "help": 
                break;
            default:
                return false; 
        }
        return true;
    }
     public override void DisplayStartMessage() {
        Console.WriteLine("""
                          Welcome to Los Angeles, a sprawling metropolis renowned for its innovation and diversity. 
                          However, the city faces significant challenges, from urban sprawl and traffic congestion 
                          to the looming threat of earthquakes. As part of an urban sustainability initiative, 
                          your task is to navigate complex decisions and guide Los Angeles towards a more resilient and sustainable future.
                          
                          Press Enter to continue...
                          """);
    }
    
    
    

    public override void ShowDescription()
    {
        throw new NotImplementedException();
    }

    public void CalculateItem()
    {
        //if (score < 3)
        Item Windmill = new Item("Windmill", "Traditional Dutch Windmill", "This Windmill will bring your city a strong, ecological and resilient industry as well as an improvement in the economy.", 1000, true);
        //else if (score > 4)
        
        //else if (score > 6)
    }

    
    
    


}