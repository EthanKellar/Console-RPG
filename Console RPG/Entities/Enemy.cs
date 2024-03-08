using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    class Enemy : Entity
    {



        //Green Hill Battle
        public static Enemy motobug = new Enemy("Motobug", 50, 50, new Stats(60, 30, 40), 10, "Speed");
        public static Enemy buzzBomber = new Enemy("Buzz Bomber", 50, 50, new Stats(40, 30, 60), 10, "Flight");
        public static Enemy chopper = new Enemy("Chopper", 50, 50, new Stats(30, 60, 40), 10, "Power");

        //Emerald Hill Battle
        public static Enemy motobug2 = new Enemy("Motobug", 50, 50, new Stats(60, 30, 40), 10, "Speed");
        public static Enemy buzzer = new Enemy("Buzzer", 50, 50, new Stats(30, 40, 60), 10, "Flight");
        public static Enemy coconuts = new Enemy("Coconuts", 50, 50, new Stats(30, 60, 40), 10, "Power");

        //Chemical Plant Battle
        public static Enemy caterkiller = new Enemy("Caterkiller", 50, 50, new Stats(60, 30, 40), 10, "Speed");
        public static Enemy grabber = new Enemy("Grabber", 50, 50, new Stats(30, 40, 60), 10, "Flight");
        public static Enemy spiny = new Enemy("Spiny", 50, 50, new Stats(30, 60, 40), 10, "Power");

        //Robotropolis boss battle
        public static Enemy metalSonic = new Enemy("Metal Sonic", 200, 100, new Stats(80, 80, 80), 100, "Speed");
        public static Enemy eggbot = new Enemy("Eggbot", 50, 50, new Stats(30, 60, 40), 10, "Power");

        //Spring Yard battle
        public static Enemy roller = new Enemy("Roller", 50, 50, new Stats(60, 30, 40), 10, "Speed");
        public static Enemy buzzBomber2 = new Enemy("Buzz Bomber", 50, 50, new Stats(30, 40, 60), 10, "Flight");
        public static Enemy yadrin = new Enemy("Yadrin", 50, 50, new Stats(30, 60, 40), 10, "Power");

        //final boss
        public static Enemy boss = new Enemy("The Egg", 12500, 1000, new Stats(8000, 4000, 500), 100, "All");
        public static Enemy eggbot2 = new Enemy("Eggbot", 50, 50, new Stats(30, 60, 40), 10, "Power");
        public static Enemy eggbot3 = new Enemy("Eggbot", 50, 50, new Stats(30, 60, 40), 10, "Power");


        public int ringsDroppedOnDefeat;
        public string coreType;
        public Enemy(string name, int hp, int mana, Stats stats, int ringsDroppedOnDefeat, string coreType) : base(name, hp, mana, stats)
        {
            this.ringsDroppedOnDefeat = ringsDroppedOnDefeat;
            this.coreType = coreType;
        }
        public override Entity ChooseTarget(List<Entity> targets)
        {
            Random random = new Random();
            return targets[random.Next(targets.Count)];

        }
        public override void Attack(Entity target)
        {
            //Calculate damage and subtract from target HP
            target.currentHP -= ((this.stats.strength * 10) / target.stats.defense);
            Console.WriteLine(this.Name + " attacked " + target.Name + "!");
            Console.WriteLine($"{this.Name} dealt {(this.stats.strength * 10) / target.stats.defense} damage!");
            Console.WriteLine($"{target.Name} is now at {target.currentHP}!");
        }

        public override void DoTurn(List<Player> players, List<Ally> allies, List<Enemy> enemies)
        {
            Entity target = ChooseTarget(players.Cast<Entity>().ToList());
            Attack(target);
        }
    }
}
