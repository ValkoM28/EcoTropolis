using System.ComponentModel;

namespace WorldOfZuul;

public class Location : Room
{
    public string ShortDescription { get; private set; }
    public string LongDescription { get; private set;}
    public Dictionary<string, Room> Exits { get; private set; } = new();

    public Location(string shortDesc, string longDesc)
    {
        
        ShortDescription = shortDesc;
        LongDescription = longDesc;
        throw new NotImplementedException();
    }
}