using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class ringBoxBomb : Item
    {
        public int damage;
        public int ammo;


        public ringBoxBomb(string name, string description, int shopPrice, int maxAmount, int damage, int ammo) : base(name, description, shopPrice, maxAmount)
        {
            this.damage = damage;
            this.ammo = ammo;

        }

        public override void Use(Entity user, Entity target)
        {
            if (ammo == 0)
                return;

            target.currentHP -= this.damage;
            --ammo;

            Console.WriteLine(target.Name + " took a Ring Box to the face!");
            Console.WriteLine("Dealt " + this.damage + " Damage!");
        }
    }
}
