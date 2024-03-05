using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    class Ally : Entity
    {

        Ally ally = new Ally("Knuckles", 100, 50, new Stats(60, 80, 95), "Shard Slam");

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
        public override void DoTurn(List<Player> players, List<Ally> allies, List<Enemy> enemies)
        {
            Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
            Attack(target);
        }
    }
}
