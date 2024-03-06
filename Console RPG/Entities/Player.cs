using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    class Player : Entity
    {

        public static List<Item> Inventory = new List<Item>();

        public static Player player1 = new Player("Sonic", 100, 80, new Stats(80, 45, 65), 0);
        
        public static Player player2 = new Player("Tails", 100, 150, new Stats(60, 40, 80), 0);

        public static int ringCount = 0;

        public Player(string name, int hp, int mana, Stats stats, int ringCount) : base(name, hp, mana, stats)
        {
            Player.ringCount = ringCount;
        }

        public override Entity ChooseTarget(List<Entity> choices)
        {

            Console.WriteLine("Type the number of the entity you would like to target");
            //Iterate through each choice
            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {choices[i].Name}");
            }

            //Let user pick choice
             int index = Convert.ToInt32(Console.ReadLine());
            return choices[index - 1];
        }

        public Item ChooseItem(List<Item> choices)
        {

            Console.WriteLine("Type the number of the item you would like to use");
            //Iterate through each choice
            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {choices[i].Name}");
            }

            //Let user pick choice
            int index = Convert.ToInt32(Console.ReadLine());
            return choices[index - 1];
        }
        public override void Attack(Entity target)
        {
            target.currentHP -= ((this.stats.strength * 10) / target.stats.defense);
            Console.WriteLine(this.Name + " attacked " + target.Name + "!");
            Console.WriteLine($"{this.Name} dealt {(this.stats.strength * 10) / target.stats.defense} damage!");
            Console.WriteLine($"{target.Name} is now at {target.currentHP}!");
        }

        public void UseItem(Item item, Entity target)
        {
            item.Use(this, target);
        }
        public override void DoTurn(List<Player> players, List<Ally> allies, List<Enemy> enemies)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("atk | item");
            string choice = Console.ReadLine();
            if (choice == "atk" || choice == "a")
            {
                Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
                Attack(target);
            }
            else if (choice == "item" || choice == "i")
            {
                Item item = ChooseItem(Inventory);
                Entity target = ChooseTarget(players.Cast<Entity>().ToList());

                item.Use(this, target);
                Inventory.Remove(item);
            }
            else
            {
                Console.WriteLine("That's not an action!");
            }
        }
    }
}
