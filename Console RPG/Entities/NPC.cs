using System;
using System.Collections.Generic;

namespace Console_RPG
{
    class NPC : Entity
    {
        public string Type;
        public NPC(string name, int hp, int mana, Stats stats, string type) : base(name, hp, mana, stats)
        {
            this.Type = type;
        }
        public override void Attack(Entity target)
        {
            throw new NotImplementedException();
        }
        public override Entity ChooseTarget(List<Entity> targets)
        {
            throw new NotImplementedException();
        }
        public override void DoTurn(List<Player> players, List<Ally> allies, List<Enemy> enemies)
        {
            throw new NotImplementedException();
        }
    }
}
