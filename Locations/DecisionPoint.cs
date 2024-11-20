namespace EcoTropolis.Locations;

public class DecisionPoint
{
    private string _name;
    private string _description { get; }
    private Dictionary<Option, int> _options { get; } = new Dictionary<Option, int>(); 
    
    public DecisionPoint(string name, string description) {
        _name = name;
        _description = description;
    }
    
    
    public void AddOption(string name, string description, int value) {
        _options.Add(new Option(name, description), value);
    }
    
    public void DisplayOptions() {
        Console.WriteLine(_name);
        Console.WriteLine(_description);
        //lists the options
        int i = 0; 
        foreach (var option in _options) {
            Console.WriteLine(++i + ". " + option.Key.Name + "\n" + option.Key.Description);
        }

    }
    
    private int GetOptionValue(int optionNumber) {
        return _options.ElementAt(optionNumber).Value;
    }

    public int Decide(int optionNumber) {
        List<Option> options = _options.Keys.ToList();
        Option placeholder = options[optionNumber - 1];
        return _options[placeholder];
    }

    
    private class Option {
        public string Name { get; }
        public string Description { get; }
        
        public Option(string name, string description) { 
            Name = name;
            Description = description;
        }
    }
}