using System;
using System.Collections.Generic;

namespace Console_RPG
{
    class Enemy : Entity
    {
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
            Console.WriteLine(this.Name + " attacked " + target.Name + "!");
        }
    }
}
