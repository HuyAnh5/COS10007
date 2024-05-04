using System;

namespace Swin_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _input;
            Console.WriteLine("Welcome to Swin Adventure!\nYou have arrived in the Hallway.");
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How would you describe yourself?");
            string description = Console.ReadLine();
            Console.WriteLine("Welcome " + name + ", the " + description + "! Let's get into the game, shall we?\n");

            Player player = new Player(name, description);
            Bag bag = new Bag(new string[] { "bag" }, "cloth", "A small cloth bag that can be used to carry items.");

            Item Gem = new Item(new string[] { "gem" }, "shiny", "A gem that could be used to trade items.");
            Item Sword = new Item(new string[] { "sword" }, "sharp", "A sword that can be wield to defeat enemies.");
            Item Shield = new Item(new string[] { "shield" }, "sturdy", "A shield that can protect you from enemies.");
            Item Poison = new Item(new string[] { "poison" }, "poisonous", "A dangerous potion that can be used to defeat enemies.");
            Item Mushroom = new Item(new string[] { "mushroom" }, "big", "A mushroom that might be safe to eat");
            Item BirdNest = new Item(new string[] { "nest" }, "wool", "Can be used to make fire.");

            Location PotionRoom = new Location("potion room", "You're at potion room, a place where you can find different potions.");
            Location Mountain = new Location("mountain", "You're at a steep mountain, where all dangers are pose.");
            Location Forest = new Location("forest", "You're at the forest, where all the animals live.");

            Path PotionRoomToMountain = new Path(new string[] { "up" }, "Back Door", "A dangerous path to take.", PotionRoom, Mountain);
            Path PotionRoomToForest = new Path(new string[] { "down" }, "Front Door", "A mysterious path to walk through.", PotionRoom, Forest);
            Path MountainToForest = new Path(new string[] { "north" }, "River", "To travel from the moutain to the forest you first need to cross a river.", Mountain, Forest);
            Path ForestToMountain = new Path(new string[] { "south" }, "Hill", "You have to walk up a hill to reach the mountain.", Forest, Mountain);
            Path MountainToPotionRoom = new Path(new string[] { "east" }, "Metal Gate", "A tall metal gate separates the mountain and the potion room.", Mountain, PotionRoom);
            Path ForestToPotionRoom = new Path(new string[] { "west" }, "Stone Barrier", "A stone barrier divides the 2 locations", Forest, PotionRoom);

            player.Inventory.Put(Sword);
            player.Inventory.Put(Shield);
            player.Inventory.Put(bag);
            bag.Inventory.Put(Gem);
            PotionRoom.Inventory.Put(Poison);
            player.Location = PotionRoom;
            player.Inventory.Put(Poison);

            PotionRoom.AddPath(PotionRoomToForest);
            PotionRoom.AddPath(PotionRoomToMountain);
            Mountain.AddPath(MountainToPotionRoom);
            Mountain.AddPath(MountainToForest);
            Forest.AddPath(ForestToPotionRoom);
            Forest.AddPath(ForestToMountain);

            Mountain.Inventory.Put(BirdNest);
            Forest.Inventory.Put(Mushroom);

            Command c = new CommandProcessor();
            Console.WriteLine(c.Execute(player, new string[] { "look" }));

            while (true)
            {
                Console.Write("Command -> ");
                _input = Console.ReadLine();

                if (_input.ToLower() != "quit")
                {
                    Console.WriteLine(c.Execute(player, _input.Split()));
                }
                else
                {
                    Console.WriteLine("Quitting the game...");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
