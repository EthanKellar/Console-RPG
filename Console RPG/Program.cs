  using System;
  using System.Collections.Generic;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ethan Kellar Presents:");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("In association with everyone who helped,");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Sonic Chronicles");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("But Better");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine();


            
            //MYSTIC RUIN AND ROBOTROPOLIS ARE SPECIAL EXCEPTIONs WHILE PRINTING COMMANDS< AS TO HIDE THE LOCATION OF HIDDEN TEMPLE
            //Basically, have Knuckles on angel island say that theres a temple north of mystic ruin, and after you've gone to mystic ruin and unlocked Super Sonic (Maybe)
            //then you'll get the hint that north of robotropolis is Eggmanland, which is where you fight the doc

            //Locations go like: North, East, South, West
            Location.stationSquare.setNearbyLocations(Location.mysticRuin, Location.casinoNight, Location.greenHill, Location.dustyDesert);
            Location.dustyDesert.setNearbyLocations(south: Location.westopolis);
            Location.greenHill.setNearbyLocations(west: Location.westopolis, east: Location.emeraldHill);
            Location.mysticRuin.setNearbyLocations();
            Location.casinoNight.setNearbyLocations(Location.springYard, Location.tropicalJungle, Location.emeraldHill);
            Location.springYard.setNearbyLocations(Location.robotropolis, Location.chemicalPlant);
            Location.emeraldHill.setNearbyLocations(south: Location.emeraldCoast);
            Location.tropicalJungle.setNearbyLocations(east: Location.angelIsland);


            Location.stationSquare.Resolve(new List<Player>() { Player.player1, Player.player2 }, new List<Ally>() { });

            /*player1.UseItem(chiliDog, player1);
            player2.UseItem(ringBoxBomb, boss);
            ally.UseItem(chaoCola, ally);*/
        }
    }
}
