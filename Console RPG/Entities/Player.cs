using System;
using System.Collections.Generic;

namespace Console_RPG
{
    class Player : Entity
    {
        public int ringCount;

        public Player(string name, int hp, int mana, Stats stats, int ringCount) : base(name, hp, mana, stats)
        {
            this.ringCount = ringCount;
        }

        public override Entity ChooseTarget(List<Entity> targets)
        {
            //Goes through all targets (prints out name), and player picks it
            return targets[0];
        }
        public override void Attack(Entity target)
        {
            target.currentHP -= ((this.stats.strength * 10) / target.stats.defense);
            Console.WriteLine(this.Name + " attacked " + target.Name + "!");
        }

        public void UseItem(Item item, Entity target)
        {
            item.Use(this, target);
        }

    }
}
