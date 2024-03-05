using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Console_RPG
{
    abstract class Equipment : Item
    {
        public float weight;
        public float rarity;
        public bool isEquip;

        protected Equipment(string Name, string description, int shopPrice, int sellPrice, float weight, float rarity) : base(Name, description, shopPrice, sellPrice)
        {
            this.weight = weight;
            this.rarity = rarity;
            this.isEquip = false; 
        }
    }
    class Armor : Equipment
    {
        public int defense;
        public Stats modifier;

        public Armor(string Name, string description, int shopPrice, int sellPrice, float weight, float rarity, int defense, Stats modifier) : base(Name, description, shopPrice, sellPrice, weight, rarity)
        {
            this.defense = defense; 
            this.modifier = modifier;   
        }

        public override void Use(Entity user, Entity target)
        {
            //flips equip true/false value
            this.isEquip = !this.isEquip;

            if (this.isEquip)
            {
                //increase target def if equipped 
                target.stats.defense += this.defense;
            }
            else
            {
                //decrease target def instead
                target.stats.defense -= this.defense;
            }
        }

    }
    class Weapon : Equipment
    {
        public int strength;
        public Stats modifier;

        public Weapon(string Name, string description, int shopPrice, int sellPrice, float weight, float rarity, int strength, Stats modifier) : base(Name, description, shopPrice, sellPrice, weight, rarity)
        {
            this.strength = strength;
            this.modifier = modifier;
        }

        public override void Use(Entity user, Entity target)
        {
            //flips equip true/false value
            this.isEquip = !this.isEquip;

            if (this.isEquip)
            {
                //increase target def if equipped 
                target.stats.strength += this.strength;
            }
            else
            {
                //decrease target def instead
                target.stats.strength -= this.strength;
            }
        }

    }

}
