using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    class Enemy : Entity
    {


        public static Enemy eggbot = new Enemy("Eggbot", 50, 50, new Stats(30, 60, 40), 10, "Power");

        //Green Hill Battle
        public static Enemy motobug = new Enemy("Motobug", 50, 50, new Stats(60, 30, 40), 10, "Speed");
        public static Enemy buzzBomber = new Enemy("Buzz Bomber", 50, 50, new Stats(30, 40, 60), 10, "Flight");
        public static Enemy chopper = new Enemy("Chopper", 50, 50, new Stats(60, 30, 40), 10, "Speed");

        //Emerald Hill Battle
        public static Enemy motobug2 = new Enemy("Motobug", 50, 50, new Stats(60, 30, 40), 10, "Speed");
        public static Enemy buzzBomber2 = new Enemy("Buzz Bomber", 50, 50, new Stats(30, 40, 60), 10, "Flight");
        public static Enemy chopper2 = new Enemy("Chopper", 50, 50, new Stats(60, 30, 40), 10, "Speed");




        public static Enemy boss = new Enemy("Egg Dragon", 250, 100, new Stats(80, 100, 95), 100, "All");
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
        }

        public override void DoTurn(List<Player> players, List<Ally> allies, List<Enemy> enemies)
        {
            Entity target = ChooseTarget(players.Cast<Entity>().ToList());
            Attack(target);
        }
    }
}
