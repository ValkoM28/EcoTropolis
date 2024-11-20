using EcoTropolis.CommandLogic;
using EcoTropolis.InventorySystem;

namespace EcoTropolis.Locations;

public class PawnShop : Location
{
    private List<Item> itemsAvailable = new List<Item>();
    public Dictionary<Item, short> PriceList { get; private set; } = new Dictionary<Item, short>();

    public PawnShop() : base("Pawn Shop")
    {
        itemsAvailable.Add(new Item("sample item 1", "sample description", "sample usage", 1000));
        itemsAvailable.Add(new Item("sample item 2", "sample description", "sample usage", 300));
        itemsAvailable.Add(new Item("sample item 3", "sample description", "sample usage", 100));
        itemsAvailable.Add(new Item("sample item 4", "sample description", "sample usage", 5000));

    }


    public override void DisplayStartMessage()
    {
        int i = 1;
        foreach (var item in itemsAvailable)
        {
            Console.WriteLine(i++ + " " + item.Name + " " + item.Price);

        }
    }

    public override void ShowDescription()
    {
        throw new NotImplementedException();
    }
    public override void Play()
    {
        
    }

    public override bool ExecuteCommand(Command command)
    {
        throw new NotImplementedException();
    }

    public bool BuyItem(string numberString, Player player)
    {
        if (short.TryParse(numberString, out short numberShort) && numberShort <= itemsAvailable.Count)
        {
            Item toBuy = itemsAvailable[numberShort];

            if (player.Inventory.BuyItem(toBuy, toBuy.Price))
            {
                Console.WriteLine("Item bought successfully");
                return true;
            }
        }

        return false;
    }
}    