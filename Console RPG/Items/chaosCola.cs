using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class chaoCola : Item
    {
        public int healAmount;


        public chaoCola(string name, string description, int shopPrice, int maxAmount, int healAmount) : base(name, description, shopPrice, maxAmount)
        {

            this.healAmount = healAmount;

        }

        public override void Use(Entity user, Entity target)
        {
            user.currentHP += this.healAmount;
            Console.WriteLine(user.Name + " Couldn't hold on much longer, so he drank a Chaos Cola!");
            Console.WriteLine("Gained " + this.healAmount + " HP");
        }
    }
}
