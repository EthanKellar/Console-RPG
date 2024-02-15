using System;
using System.Collections.Generic;

namespace Console_RPG
{
    class Ally : Entity
    {
        public string Ability;
        public Ally(string name, int hp, int mana, Stats stats, string Ability) : base(name, hp, mana, stats)
        {
            this.Ability = Ability;
        }
        public override void Attack(Entity target)
        {
            throw new NotImplementedException();
        }
        public override Entity ChooseTarget(List<Entity> targets)
        {
            Random random = new Random();
            return targets[random.Next(targets.Count)];
        }
        public void UseItem(Item item, Entity target)
        {
            item.Use(this, target);
        }
    }
}
