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
            while (true)
            {
                //run this code on each of the players
                foreach (var player in players)
                {
                    if (player.currentHP > 0)
                    {
                        Console.WriteLine("It's " + player.Name + "'s turn!");
                        player.DoTurn(players, allies, enemies);
                    }
                    else
                    {
                        Console.WriteLine(player + "Is unable to continue battling!");
                    }
                }

                foreach (var enemy in enemies)
                {
                    if (enemy.currentHP > 0)
                    {
                        Console.WriteLine("It's " + enemy.Name + "'s turn!");
                        enemy.DoTurn(players, allies, enemies);
                    }
                    else
                    {
                        Console.WriteLine(enemy + "Is unable to continue battling!");
                    }
                }

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
                    break;
                }
            }
        }
    }
}
