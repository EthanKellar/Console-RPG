using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Text;

namespace Console_RPG
{
    class Shop : LocationEvent
    {
        public string ownerName;
        public string shopName;
        public List<Item> items;
        public string dialogue;
        public string moredialogue;

        public Shop(string ownerName, string shopName, List<Item> items, string dialogue, string moredialogue) : base(false)
        {
            this.ownerName = ownerName;
            this.shopName = shopName;
            this.items = items;
            this.dialogue = dialogue;
            this.moredialogue = moredialogue;
        }
        public override void Resolve(List<Player> players, List<Ally> allies)
        {
            Console.WriteLine($"Welcome to {ownerName}'s shop...");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine($"This shop {shopName} is interesting...");

            System.Threading.Thread.Sleep(1000);
            while (true)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("buy | sell | leave");
                string userInput = Console.ReadLine();
                if (userInput == "buy" || userInput == "b")
                {
                    Item item = ChooseItem(this.items);
                    if (item.shopPrice > Player.ringCount)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (item.shopPrice < Player.ringCount)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (Player.ringCount < item.shopPrice)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("It's all yours!");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("...sike, you don't have the rings for it");
                    }
                    else if (Player.ringCount >= item.shopPrice)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Player.ringCount -= item.shopPrice;
                        Player.Inventory.Add(item);
                        Console.WriteLine($"You got a {item.Name}.");
                    }
                    else
                        Console.WriteLine("Too bad you wasted time.");
                }

                else if (userInput == "LEAVE")
                {
                    break;
                }
                
                else
                {
                    Console.WriteLine("...you gonna buy something, or are you just gonna stand there yapping gibberish?");
                    
                }
            }
            Console.WriteLine("Well now... BYE-");

        }
        public Item ChooseItem(List<Item> choices)
        {
            Console.WriteLine("Which item would you like to buy or sell?");
            // Iterate through each choice.
            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {choices[i].Name} (*{choices[i].shopPrice})");
            }
            // Let user pick choice.
            int index = Convert.ToInt32(Console.ReadLine());
            return choices[index - 1];
        }
    }

}

