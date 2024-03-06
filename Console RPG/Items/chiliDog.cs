using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class ChiliDog : Item
    {
        public int healAmount;


        public ChiliDog(string name, string description, int shopPrice, int maxAmount, int healAmount) : base(name, description, shopPrice, maxAmount)
        {
            this.healAmount = healAmount;

        }

        public override void Use(Entity user, Entity target)
        {
            user.currentHP += this.healAmount;
            Console.WriteLine(target.Name + " ate a Chili Dog. It was way past cool!");
            Console.WriteLine("Gained " + this.healAmount + " HP");
        }
    }
}
