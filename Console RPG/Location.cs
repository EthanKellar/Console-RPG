using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Location
    {
        public string name;
        public string description;

        public Location north, east, south, west;

        public Location(string name, string description)
        {
            this.name = name;
            this.description = description;
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

        public void Resolve()
        {
            Console.WriteLine("You arrived in " + this.name + ".");
            Console.WriteLine(this.description);

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
            else if (direction == "west")
                nextLocation = this.west;
            else if (direction == "south")
                nextLocation = this.south;
            else if (direction == "east")
                nextLocation = this.east;
            else
            {
                Console.WriteLine("That's not a proper direction! (Hint, all lowercase)");
                this.Resolve();
            }
            nextLocation.Resolve();
        }
    }
}
