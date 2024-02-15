  using System;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {

            /*NOTES: 
             * Battle system needs to be done (Didn't learn in class)
            */
            //Besides hp and mana, all stats are from 0-100

            //Goes like this:                    HP | Mana    |     Spd |Str|Def |Other
            Player player1 = new Player("Sonic", 100, 80, new Stats(80, 45, 65), 0);
            Player player2 = new Player("Tails", 100, 150, new Stats(60, 40, 80), 0);

            Ally ally = new Ally("Knuckles", 100, 50, new Stats(60, 80, 95), "Shard Slam");

            Enemy eggbot = new Enemy("Eggbot", 50, 50, new Stats(40, 60, 30), 10, "Power");
            Enemy motobug = new Enemy("Motobug", 50, 50, new Stats(40, 60, 30), 10, "Speed");
            Enemy buzzBomber = new Enemy("Buzz Bomber", 50, 50, new Stats(40, 60, 30), 10, "Flight");

            Enemy boss = new Enemy("Egg Dragon", 250, 100, new Stats(80, 100, 95), 100, "All");


            ChiliDog chiliDog = new ChiliDog("A traditional Chili Dog", "The best of both worlds, Chili, and Hot Dog, what a combo!", 15, 5, 20);
            chaoCola chaoCola = new chaoCola("The World-Renown Chao Cola™", "A refreshing drink for a refreshing world!", 8, 5, 10);
            ringBoxBomb ringBoxBomb = new ringBoxBomb("A paiunful Ring Box Bomb!", "Manufactured and Shipped by our own Miles \"Tails\" Prower, this Ring bomb will gueve you quite a few bruises!", 20, 30, 20, 5);

            Location stationSquare = new Location("Station Square", "A bustling city with Shops and Rest places galore!");
            Location greenHill = new Location("Green Hill", "A beautiful landscape of Hills and Loops");
            Location dustyDesert = new Location("Dusty Desert", "A dry desert, filled with traps and hazards");

            Location chemicalPlant = new Location("Chemical Plant", "A dystopian city, where all of the water is this weird purple chemical");
            Location angelIsland = new Location("Angel Island", "A floating island where the Master Emerald resides.");
            Location westopolis = new Location("Westopolis", "A lively city located in-between the coastline, and a desert.");


            //Locations go like: North, East, West, South
            stationSquare.setNearbyLocations(greenHill, angelIsland, westopolis, chemicalPlant);

            stationSquare.Resolve();

            player1.UseItem(chiliDog, player1);
            player2.UseItem(ringBoxBomb, boss);
            ally.UseItem(chaoCola, ally);
        }
    }
}
