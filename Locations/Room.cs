namespace WorldOfZuul
{
    public abstract class Room
    {
        public string Name { get; private set; }
        public string Description { get; private set;}
        public Dictionary<string, Room> Exits { get; private set; } = new();

        public Room(string name, string description) {
            Name = name;
            Description = description;
        }

        public abstract void ToMainMenu(); 

        // TODO: consider adding a back function as well
        public abstract void ShowDescription();
        
        
        
        public void SetExits(Room? north, Room? east, Room? south, Room? west) {
            //TODO: Movement within the location
            //SetExit("north", north);
            //SetExit("east", east);
            //SetExit("south", south);
            //SetExit("west", west);
        }

        public void SetExit(string direction, Room? neighbor) {
            //if (neighbor != null)
                //Exits[direction] = neighbor;
        }
    }
    
}
