using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Console_RPG
{
    class Battle : LocationEvent
    {
        
        public List<Enemy> enemies;

        public Battle(List<Enemy> enemies) : base(false)
        {
            
            this.enemies = enemies;
        }

        public override void Resolve(List<Player> players, List<Ally> allies)
        {
            if (this.isResolved)
            {
                return;
            }
            Console.Write($"You ran into ");
            foreach(var enemy in enemies)
            {
                Console.Write($"{enemy.Name}, ");
            }
            Console.WriteLine();
            while (true)
            {
                //run this code on each of the players
                List<Entity> speedy = new List<Entity>();
                speedy.AddRange(players);
                speedy.AddRange(allies);
                speedy.AddRange(enemies);
                speedy = speedy.OrderBy(player => player.stats.speed).Reverse().ToList();
                foreach (var entity in speedy)
                {
                    if (entity.currentHP > 0)
                    {
                        Console.WriteLine("It's " + entity.Name + "'s turn!");
                        entity.DoTurn(players, allies, enemies);
                    }
                    else
                    {
                        Console.WriteLine(entity.Name + " is unable to continue battling!");
                    }
                }
/*
                foreach (var enemy in enemies)
                {
                    if (enemy.currentHP > 0)
                    {
                        Console.WriteLine("It's " + enemy.Name + "'s turn!");
                        enemy.DoTurn(players, allies, enemies);
                    }
                    else
                    {
                        Console.WriteLine(enemy.Name + " is unable to continue battling!");
                    }
                }*/

                //If all players die...
                if (players.TrueForAll(players => players.currentHP <= 0))
                {
                    Console.WriteLine("Eggman: You were too slow to stop me, Sonic");
                    Console.WriteLine("Uh oh, That's no good...");
                    break;
                }

                //If all enemies die
                if (enemies.TrueForAll(enemies => enemies.currentHP <= 0))
                {
                    Console.WriteLine("All Right!");
                    this.isResolved = true;
                    break;
                }
            }
        }
    }
}

