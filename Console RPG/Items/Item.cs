using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    abstract class Item
    {
        public static ChiliDog chiliDog = new ChiliDog("A traditional Chili Dog", "The best of both worlds, Chili, and Hot Dog, what a combo!", 15, 5, 300);
        public static chaoCola chaoCola = new chaoCola("The World-Renown Chao Cola™", "A refreshing drink for a refreshing world!", 8, 5, 200);
        public static ringBoxBomb ringBoxBomb = new ringBoxBomb("A paiunful Ring Box Bomb!", "Manufactured and Shipped by our own Miles \"Tails\" Prower, this Ring bomb will gueve you quite a few bruises!", 20, 30, 20, 5);

        public string Name;
        public string description;
        public int shopPrice;
        public int maxAmount;

        public Item(string Name, string description, int shopPrice, int maxAmount)
        {
            this.Name = Name;
            this.description = description;
            this.shopPrice = shopPrice;
            this.maxAmount = maxAmount;
        }

        public abstract void Use(Entity user, Entity target);

    }
}
