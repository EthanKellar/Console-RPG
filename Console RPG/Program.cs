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


            Enemy eggbot = new Enemy("Eggbot", 50, 50, new Stats(30, 60, 40), 10, "Power");

            Enemy motobug = new Enemy("Motobug", 50, 50, new Stats(60, 30, 40), 10, "Speed");

            Enemy buzzBomber = new Enemy("Buzz Bomber", 50, 50, new Stats(30, 40, 60), 10, "Flight");

            Enemy chopper = new Enemy("Chopper", 50, 50, new Stats(60, 30, 40), 10, "Speed");


            Enemy boss = new Enemy("Egg Dragon", 250, 100, new Stats(80, 100, 95), 100, "All");


            //ITEMS
            ChiliDog chiliDog = new ChiliDog("A traditional Chili Dog", "The best of both worlds, Chili, and Hot Dog, what a combo!", 15, 5, 20);

            chaoCola chaoCola = new chaoCola("The World-Renown Chao Cola™", "A refreshing drink for a refreshing world!", 8, 5, 10);

            ringBoxBomb ringBoxBomb = new ringBoxBomb("A paiunful Ring Box Bomb!", "Manufactured and Shipped by our own Miles \"Tails\" Prower, this Ring bomb will gueve you quite a few bruises!", 20, 30, 20, 5);


            //LOCATIONS
            Location stationSquare = new Location("Station Square", "A bustling city with Shops and Rest places galore!");

            Location greenHill = new Location("Green Hill", "A beautiful landscape of Hills and Loops");

            Location chemicalPlant = new Location("Chemical Plant", "A dystopian city, where all of the water is this weird purple chemical");

            Location angelIsland = new Location("Angel Island", "A floating island where the Master Emerald resides.");

            Location dustyDesert = new Location("Dusty Desert", "A dry desert, filled with traps and hazards");

            Location tropicalJungle = new Location("Tropical Jungle", "A dense jungle, packed with suprises!");

            Location casinoNight= new Location("Casino Park", "The primetime destination for Gambling! (Gambling not suitable for those under age 21)");

            Location springYard= new Location("Spring Yard", "What was once an EggFacility, is now just a yard of scraps and springs. Warning: is quite bouncy!");

            Location mysticRuin = new Location("Mystic Ruin", "The ruins of an ancient temple. I wonder if it's connected to Angel island?");

            Location hiddenTemple= new Location("Hidden Temple", "The hidden temple that Knuckles was talking about!");

            Location robotropolis= new Location("Robotropolis", "The Capitol of the Eggman Empire.");

            Location eggmanland= new Location("Eggmanland", "A twisted theme park consisting of traps, and sulfuric cotton candy.");

            Location westopolis = new Location("Westopolis", "A lively city located in-between the coastline, and a desert.");

            Location emeraldHill = new Location("Emerald Hill", "This may look simila to Green Hill, but there's twice as many obstacles to overcome, though it's worth the reward!");

            Location emeraldCoast = new Location("Emerald Coast", "A beautiful coastline connected to Emerald hill, with a Lighthouse and beach hangout spot!");


            //MYSTIC RUIN AND ROBOTROPOLIS ARE SPECIAL EXCEPTIONs WHILE PRINTING COMMANDS< AS TO HIDE THE LOCATION OF HIDDEN TEMPLE
            //Basically, have Knuckles on angel island say that theres a temple north of mystic ruin, and after you've gone to mystic ruin and unlocked Super Sonic (Maybe)
            //then you'll get the hint that north of robotropolis is Eggmanland, which is where you fight the doc

            //Locations go like: North, East, South, West
            stationSquare.setNearbyLocations(mysticRuin, casinoNight, greenHill, dustyDesert);

            dustyDesert.setNearbyLocations(south: westopolis);

            greenHill.setNearbyLocations(west: westopolis, east: emeraldHill);

            mysticRuin.setNearbyLocations(hiddenTemple);

            casinoNight.setNearbyLocations(springYard, tropicalJungle, emeraldHill);

            springYard.setNearbyLocations(robotropolis, chemicalPlant);

            emeraldHill.setNearbyLocations(south: emeraldCoast);

            tropicalJungle.setNearbyLocations(east: angelIsland);



            stationSquare.Resolve();

            /*player1.UseItem(chiliDog, player1);
            player2.UseItem(ringBoxBomb, boss);
            ally.UseItem(chaoCola, ally);*/
        }
    }
}
