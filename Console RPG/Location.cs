using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Location
    {
        public static Location stationSquare = new Location("Station Square", "A bustling city with Shops and Rest places galore!");
        public static Location greenHill = new Location("Green Hill", "A beautiful landscape of Hills and Loops", new Battle(new List<Enemy>() { Enemy.motobug, Enemy.chopper, Enemy.buzzBomber }));
        public static Location chemicalPlant = new Location("Chemical Plant", "A dystopian city, where all of the water is this weird purple chemical");
        public static Location angelIsland = new Location("Angel Island", "A floating island where the Master Emerald resides.");
        public static Location dustyDesert = new Location("Dusty Desert", "A dry desert, filled with traps and hazards");
        public static Location tropicalJungle = new Location("Tropical Jungle", "A dense jungle, packed with suprises!");
        public static Location casinoNight = new Location("Casino Park", "The primetime destination for Gambling! (Gambling not suitable for those under age 21)");
        public static Location springYard = new Location("Spring Yard", "What was once an EggFacility, is now just a yard of scraps and springs. Warning: is quite bouncy!");
        public static Location mysticRuin = new Location("Mystic Ruin", "The ruins of an ancient temple. I wonder if it's connected to Angel island?");
        public static Location hiddenTemple = new Location("Hidden Temple", "The hidden temple that Knuckles was talking about!");
        public static Location robotropolis = new Location("Robotropolis", "The Capitol of the Eggman Empire.", new Battle(new List<Enemy>() { Enemy.metalSonic }));
        public static Location eggmanland = new Location("Eggmanland", "A twisted theme park consisting of traps, and sulfuric cotton candy.");
        public static Location westopolis = new Location("Westopolis", "A lively city located in-between the coastline, and a desert.", new Battle(new List<Enemy>() { Enemy.boss }));
        public static Location emeraldHill = new Location("Emerald Hill", "This may look simila to Green Hill, but there's twice as many obstacles to overcome, though it's worth the reward!", new Battle(new List<Enemy>() { Enemy.motobug2, Enemy.coconuts, Enemy.buzzer }));
        public static Location emeraldCoast = new Location("Emerald Coast", "A beautiful coastline connected to Emerald hill, with a Lighthouse and beach hangout spot!", new Shop("Big The Cat & Froggy the Frog", "Big's Fishing Hut", new List<Item> { Item.chiliDog, Item.chaoCola }, "Welcome, friends.", "Froggy sure seems excited to see you"));

        public string name;
        public string description;
        public LocationEvent poi;

        public Location north, east, south, west;

        public Location(string name, string description, LocationEvent poi = null)
        {
            this.name = name;
            this.description = description;
            this.poi = poi;
        }

        public void setNearbyLocations(Location north = null, Location east = null, Location south = null, Location west = null)
        {


            if (!(north is null))
            {
                this.north = north;
                north.south = this;
            }
            
            if(!(east is null))
            {
                east.west = this;
                this.east = east;

            }

            if(!(south is null))
            {
                south.north = this;
                this.south = south;

            }

            if(!(west is null))
            {
                west.east = this;
                this.west = west;

            }
        }

        public void Resolve(List<Player> players, List<Ally> allies)
        {
            //only resolves battle if there is a battle to resolve (Null checking)
            poi?.Resolve(players, allies);

            Console.WriteLine("You arrived in " + this.name + ".");
            Console.WriteLine(this.description);



            if (this == angelIsland)
            {
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Knuckles: Hey, what are you doing here?");
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Sonic: Hey knux, we're just dropping by, trying to get some help to stop Egghead again");
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Knuckles: Yeah, go north at mystic ruins, should take you to Hidden Temple where you can power up with the chaos emeralds.");
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Tails: Really? I've ran multiple analysis of mystic ruin, and it's surrounding areas, never have I found a \"Hidden Temple\"");
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Knuckles: That's because it's ancient echidnan magic, can't be picked up by technology. That's why Eggman hasn't found it yet");
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Sonic: Thanks Knux, We'll leave you alone now");
                System.Threading.Thread.Sleep(5000);
                Location.tropicalJungle.east = null;
                Location.mysticRuin.north = hiddenTemple;
                tropicalJungle.Resolve(players, allies);
                return;
            }
            if (this == hiddenTemple)
            {
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Tails: Wow, this must be the Hidden Temple that knuckles was talking about!");
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Tails: According to my scans, there's ancient echidnan technology all over this place, meant to safeguard the chaos emeralds from evil!");
                System.Threading.Thread.Sleep(10000);
                Console.WriteLine("As Sonic & Tails investigate the temple further, seven pillars arise from the ground, all with a different colored glow");
                System.Threading.Thread.Sleep(6000);
                Console.WriteLine("A platform arises in the middle, it glows with golden light, calling Sonic to step onto the platform");
                System.Threading.Thread.Sleep(4000);
                Console.WriteLine("As Sonic steps onto the glowing platform, the Chaos Emeralds begin to glow, and float off of the pillars, beginning to surround Sonic");
                System.Threading.Thread.Sleep(10000);
                Console.WriteLine("The Chaos Emeralds begin to spin around Sonic, and his quills begin to rise");
                System.Threading.Thread.Sleep(5000);
                Player.player1.maxHP = 10000;
                Player.player1.currentHP = Player.player1.maxHP;
                Player.player1.stats.speed = 299792458;
                Player.player1.stats.strength = 1000;
                Player.player1.stats.defense = 500;
                Player.player1.Name = "Super Sonic";
                Console.WriteLine("Sonic turns into an almost blinding golden glow, as Tails looks up in awe");
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Tails: Sonic, you've gone super!");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Super Sonic: All-right! This is just what I needed to beat Eggman! Let's go, Tails!");
                System.Threading.Thread.Sleep(5000);

                //DO SAME THING WITH HIDDEN TEMPLE THAT YOU DID WITH ANGEL ISLAND!

            }


            if (!(north is null))
                Console.WriteLine("NORTH: " + this.north.name);
            if (!(west is null))
                Console.WriteLine("WEST: " + this.west.name);
            if (!(south is null))
                Console.WriteLine("SOUTH: " + this.south.name);
            if (!(east is null))
                Console.WriteLine("EAST: " + this.east.name);

            string direction = Console.ReadLine();
            Location nextLocation = null;

            if (direction == "north")
                nextLocation = this.north;
            else if (direction == "n")
                nextLocation = this.north;
            else if (direction == "west")
                nextLocation = this.west;
            else if (direction == "w")
                nextLocation = this.west;
            else if (direction == "south")
                nextLocation = this.south;
            else if (direction == "s")
                nextLocation = this.south;
            else if (direction == "east")
                nextLocation = this.east;
            else if (direction == "e")
                nextLocation = this.east;
            else
            {
                Console.WriteLine("That's not a proper direction! (Hint, all lowercase)");
                this.Resolve(players, allies);
            }

            if (nextLocation == null)
            {
                Console.WriteLine("Huh, there's nothing here. Better go back");
                this.Resolve(players, allies);
            }
            nextLocation.Resolve(players, allies);
        }
    }
}
