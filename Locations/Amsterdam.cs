using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using EcoTropolis.CommandLogic;
using EcoTropolis.InventorySystem;
using static EcoTropolis.Messages.Messages;

namespace EcoTropolis.Locations;

public class Amsterdam : Location 
{
    private string[] _commandWords = ["look", "help", "metro", "meeting"];
    private Game _game;

    private Player _player; 
    //public Dictionary<string, Location> Exits { get; }
    
    public Amsterdam(Game game, Player player) : base("Amsterdam") {
        _game = game;
        _player = player;
    }

    public override void Play() 
    {
    DisplayStartMessage();
    bool playing = true;

        while (playing) {
            string? input = Console.ReadLine();
            if (input == "metro") {
                Amsterdamcenter();
                AmsterdamCommands = false;
                while(AmsterdamCommands == false) {//absolutely horrendous temporary code that we will rework
                 
                    Console.WriteLine("");
                    AmsterdamInputs.Input2 = Console.ReadLine();
                    Console.WriteLine("");
                        switch(AmsterdamInputs.Input2)
                        {
                            case "look":
                                ShowDescription();
                                Console.WriteLine("Type \"look\" to look your surroundings\n" +
                                                  "Type \"meeting\" to start the meeting\n");
                                break;
                            case "meeting":
                                AmsterdamMeeting();
                                _game.ChangeCurrentLocation(_game.TravelMenu);
                            break;
                            default:
                                Console.WriteLine("Invalid command, please try again:");
                            break;
                        }
                }
            }
            else {
                Console.WriteLine("Invalid command, please try again:");
                Console.WriteLine("");
            }
        } 
            _game.ChangeCurrentLocation(_game.TravelMenu);
        }

    public override bool ExecuteCommand(Command command)
    {
        throw new NotImplementedException();
    }
    
    public bool AmsterdamCommands;

    public override void DisplayStartMessage() {
    Console.WriteLine("The next location your major assigned you to go is The Netherlands, the land of\n" +
                    "canals, tulips, windmills, and bicycles. Your major is amazed by its landscapes\n" +
                    "and cultural icons and wants you to learn the good things this city could bring\n" +
                    "to your city. You arrive at Amsterdam Airport Schiphol and take a train to the\n" +
                    "city center.\n" +
                    "\n" +
                    "Type \"metro\" to go to the city center:");

    }

    public static void Amsterdamcenter() 
    {
        Console.WriteLine( "\n" +
                        "Upon arriving in Central Amsterdam, you see the city's beauty intertwined with\n" +
                        "a pressing challenge: people struggle to find affordable housing. As the\n" +
                        "population grows, housing options shrink, leading to steep rents and overcrowded\n" +
                        "apartments. You have just a few months to observe the city's solutions and\n" +
                        "gather ideas to bring home to your city. In a meeting with Amsterdam's urban\n" +
                        "planners, they highlight two pressing decisions that could make or break their \n" +
                        "city's future.\n" +
                            "\n" +
                            "Type \"look\" to look your surroundings\n" +
                            "Type \"meeting\" to start the meeting");
    }

    public void AmsterdamMeeting()
    {
        string meeting ="""

                        Decision Point 1: Balancing Growth with Heritage

                        Option A: Skyward Expansion.
                        Amsterdam is considering new high-rise, eco-friendly buildings to fit more homes into
                        limited space. This approach would allow more housing without sprawling outward, but it
                        risks changing Amsterdam's historic skyline. If successful, your city could adopt a
                        similar model, preserving space while maximizing housing options.

                        Option B: Historical Revitalization.
                        Alternatively, Amsterdam could convert its old, vacant buildings into affordable apartments.
                        While this solution could fit Amsterdam's character, it may limit housing capacity. Your city
                        could use this approach to protect cultural areas while meeting housing demands.

                        Option C: Floating Neighborhoods.
                        Amsterdam could create floating homes and neighbourhoods along its canals, a concept that
                        aligns with its strong maritime heritage. These eco-friendly, water-based residences could
                        expand housing without crowding the city center or altering the skyline. For your city, adopting
                        floating neighbourhoods could help manage growth sustainably while adding a unique, attractive
                        element to the cityscape.

                        What option would you like to choose?

                        """;
        Console.WriteLine(meeting);
        bool yetanothersintaxchecker = false;
        while(yetanothersintaxchecker == false)
        {
            Decision1 = Console.ReadLine().ToLower();
            switch (Decision1)
                {
                    case "a":
                        Meetingpoints +=3;
                        yetanothersintaxchecker = true;
                    break;
                    case "b":
                        Meetingpoints +=1;
                        yetanothersintaxchecker = true;
                    break;
                    case "c":
                        Meetingpoints +=2;
                        yetanothersintaxchecker = true;
                    break;
                    default:
                        Console.WriteLine("That is not a valid option, please try again:");
                        Console.WriteLine("");
                    break;
                }        
        }

        string meeting2 ="""

                        Decision Point 2: Innovative Housing Models

                        Option A: Government Partnerships for Affordable Housing.
                        Amsterdam is exploring partnerships where developers receive government incentives to build
                        affordable housing. This would demand substantial funding but could attract new housing projects
                        quickly. Your city, with a growing population, might consider similar incentives to ensure housing
                        is available for all income levels.

                        Option B: Co-living Spaces.
                        Amsterdam is testing co-living spaces that allow residents to share amenities and reduce costs. 
                        This model fosters a sense of community but may not appeal to all citizens. If it proves successful, 
                        your city could adapt this approach to strengthen community ties and offer affordable options in dense areas.

                        Option C: Repurposing Vacant Commercial Spaces.
                        With the rise of remote work, many commercial spaces in Amsterdam are left vacant. The city could incentivize
                        the repurposing of office buildings and unused commercial spaces into affordable housing units. This adaptive
                        reuse would create housing quickly, and it could serve as a model for your city, especially if commercial
                        spaces become underutilized in the future.

                        What option would you like to choose?

                        """;
        Console.WriteLine(meeting2);
        yetanothersintaxchecker = false;
        while(yetanothersintaxchecker == false)
        {
            Decision2 = Console.ReadLine().ToLower();
            switch (Decision2)
                {
                    case "a":
                        Meetingpoints +=3;
                        yetanothersintaxchecker = true;
                    break;
                    case "b":
                        Meetingpoints +=1;
                        yetanothersintaxchecker = true;
                    break;
                    case "c":
                        Meetingpoints +=2;
                        yetanothersintaxchecker = true;
                    break;
                    default:
                        Console.WriteLine("That is not a valid option, please try again:");
                        Console.WriteLine("");
                    break;
                }        
        }
        Console.WriteLine("The meeting has finished, now you wait for the results to be noticeable");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.WriteLine();
        if (Decision1 == "a" && Decision2 == "a")
        {
            Console.WriteLine("A couple of months later, you start seeing the outcomes of your choices, skyward expansions were an absolute success! Amsterdam now is building upwards and while the city is becoming modern and eco-friendly, a lot of new homes are being built, solving the lack of offers in the housing market. On the other hand, the collaboration between public and private organizations building homes made a perfect balance between sustainability and affordability, and quality and diversity.");
            Item Windmill = new Item("Windmill", "Traditional Dutch Windmill", "This Windmill will bring your city a strong, ecological and resilient industry as well as an improvement in the economy.", 1000, true);
            Console.WriteLine("");
            Console.WriteLine($"Congratulations, you have obtained the {Windmill.Name}!");
        }
        else if (Decision1 == "a" && Decision2 == "b")
        {
            Console.WriteLine("A couple of months later, you start seeing the outcomes of your choices, skyward expansions were an absolute success! Amsterdam now is building upwards and while the city is becoming modern and eco-friendly, a lot of new homes are being built, solving the lack of offers in the housing market, the only problem was that co-living spaces were not the best solution for most of the people, for students, it was a decent solution, but families and older people had a hard time sharing spaces with other people.");
            Item Bicycle = new Item("Bicycle", "An orange Dutch Bicycle", "This bicycle will make the citizens in your city use their bikes instead of the car, this combined with a great bike lane network could make your city very bike-friendly and less polluted.", 500, true);
            Console.WriteLine("");
            Console.WriteLine($"Congratulations, you have obtained the {Bicycle.Name}!");
        }
        else if (Decision1 == "a" && Decision2 == "c")
        {
            Console.WriteLine("A couple of months later, you start seeing the outcomes of your choices, skyward expansions were an absolute success! Amsterdam now is building upwards and while the city is becoming modern and eco-friendly, a lot of new homes are being built, solving the lack of offers in the housing market. However the repurposing of vacant commercial spaces was not the best idea, while it created more space for housing, all the people moving in will need shops, banks, restaurants and places to spend their free time, but since the houses are where these services should be the ones left are overcrowded and expensive.");
            Item Windmill = new Item("Windmill", "Traditional Dutch Windmill", "This Windmill will bring your city a strong, ecological and resilient industry as well as an improvement in the economy.", 1000, true);
            Console.WriteLine("");
            Console.WriteLine($"Congratulations, you have obtained the {Windmill.Name}!");
        }
        else if (Decision1 == "b" && Decision2 == "a")
        {
            Console.WriteLine("A couple of months later, you start seeing the outcomes of your choices, while converting the old historical buildings into houses was a bad idea, a lot of buildings with historical value were damaged and not properly converted into living spaces, the government partnerships for affordable housing was a successful initiative, collaboration between public and  private organizations building homes made a perfect balance between affordability, quality and diversity.");
            Item Bicycle = new Item("Bicycle", "An orange Dutch Bicycle", "This bicycle will make the citizens in your city use their bikes instead of the car, this combined with a great bike lane network could make your city very bike-friendly and less polluted.", 500, true);
            Console.WriteLine("");
            Console.WriteLine($"Congratulations, you have obtained the {Bicycle.Name}!");
        
        }
        else if (Decision1 == "b" && Decision2 == "b")
        {
            Console.WriteLine("A couple of months later, you start seeing the outcomes of your choices, converting the old historical buildings into houses was a bad idea, a lot of buildings with historical value were damaged and not properly converted into living spaces. furthermore, co-living spaces were not the best solution for most of the people, for students, it was a decent solution, but families and older people had a hard time sharing basic living spaces with other people.");
            Item OrangeTulip = new Item("Orange Tulip", "A tulip planted, grown and collected in the Netherlands, it is a beautiful orange tulip in gratitude for your help", "it has no effect in your city", 100, true);
            Console.WriteLine("");
            Console.WriteLine($"Congratulations, you have obtained the {OrangeTulip.Name}!");
        }
        else if (Decision1 == "b" && Decision2 == "c")
        {
            Console.WriteLine("A couple of months later, you start seeing the outcomes of your choices, converting the old historical buildings into houses was a bad idea, a lot of buildings with historical value were damaged and not properly converted into living spaces, this, combined with the repurposing of vacant commercial spaces was not the best desition, while it created more space for housing, all the people moving in will need shops, banks, restaurants and places to spend their free time, but since the houses are where these services should be the ones left are overcrowded and expensive.");
            Item OrangeTulip = new Item("Orange Tulip", "A tulip planted, grown and collected in the Netherlands, it is a beautiful orange tulip in gratitude for your help", "it has no effect in your city", 100, true);
            Console.WriteLine("");
            Console.WriteLine($"Congratulations, you have obtained the {OrangeTulip.Name}!");
        }
        else if (Decision1 == "c" && Decision2 == "a")
        {
            Console.WriteLine("A couple of months later, you start seeing the outcomes of your choices, floating neighbourhoods were a good initiative, it created a lot of offers, housing more people, but it polluted more than expected and the houses lacked some basic features. On the other hand, the collaboration between public and private organizations building homes made a perfect balance between affordability, quality and diversity.");
            Item Windmill = new Item("Windmill", "Traditional Dutch Windmill", "This Windmill will bring your city a strong, ecological and resilient industry as well as an improvement in the economy.", 1000, true);
            Console.WriteLine("");
            Console.WriteLine($"Congratulations, you have obtained the {Windmill.Name}!");
        }
        else if (Decision1 == "c" && Decision2 == "b")
        {
            Console.WriteLine("A couple of months later, you start seeing the outcomes of your choices, floating neighbourhoods looked like a good initiative, it created a lot of offers, housing more people, but it polluted more than expected and the houses lacked some basic features. Moreover, co-living spaces were not the best solution for most of the people, for students, it was a decent solution, but families and older people had a hard time sharing basic living spaces with other people.");
            Item OrangeTulip = new Item("Orange Tulip", "A tulip planted, grown and collected in the Netherlands, it is a beautiful orange tulip in gratitude for your help", "it has no effect in your city", 100, true);
            Console.WriteLine("");
            Console.WriteLine($"Congratulations, you have obtained the {OrangeTulip.Name}!");
        }
        else if (Decision1 == "c" && Decision2 == "c")
        {
            Console.WriteLine("A couple of months later, you start seeing the outcomes of your choices, floating neighbourhoods were a good initiative, it created a lot of offers, housing more people, but it polluted more than expected and the houses lacked some basic services, nevertheless, the repurposing of vacant commercial spaces was not the best idea, while it created more space for housing, all the people moving in will need shops, banks, restaurants and places to spend their free time, but since the houses are where these services should be the ones left are overcrowded and expensive.");
            Item Bicycle = new Item("Bicycle", "An orange Dutch Bicycle", "This bicycle will make the citizens in your city use their bikes instead of the car, this combined with a great bike lane network could make your city very bike-friendly and less polluted.", 500, true);
            Console.WriteLine("");
            Console.WriteLine($"Congratulations, you have obtained the {Bicycle.Name}!");
        }
        else
        {
            Console.WriteLine("You are not supposed to be here, consider this message an easter egg");
        }
    }
    public static class AmsterdamInputs
    {
        public static string? Input2 { get; set; }
    }

    public string? Decision1 { get; set; }
    public string? Decision2 { get; set; }
    public override void ShowDescription() {
        Console.WriteLine("You are in Amsterdam the city of canals and bicycles");
    }
    public int Meetingpoints { get; set; }
}