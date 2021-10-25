using System;
using System.Collections.Generic;
using GameCore;
using GameCore.Items;
using GameCore.Class;
using HeroFabric;

namespace ConsoleGameTester
{
    class Program
    {
        static void Main(string[] args)
        {
            PotionHP potionHP = new PotionHP("stuff",100, 50);
            Console.WriteLine(potionHP.Name);

            List<GameItem> gameItems = new List<GameItem>()
            {
                new PotionHP("Middle Health Potion", 50, 25),
                new PotionMana("Middle Mana Potion", 50, 25),
                new PotionHP("Potion of Spirit", 100, "Heal your Hero 50HP", "Hmm... It`s smell like a swamp frog.", 50),
                new PotionHP("Root Beer", 70, "Heal your Hero 30HP", "Sit down traveler, rest in our tavern.", 35),
                new PotionMana("Wild Flask", 75, "Your Hero get 45Mana", "UNSTOPPABLE WILD NATURAL POWER!", 45),
                new PotionMana("Lucky Golden Jug", 250, "???", "Damn, it looks so expensive...", 5)
            };

            foreach(var item in gameItems)
            {
                Console.WriteLine($"{item.Name} {item.Price}$ {item.DescriptionMain} {item.DescriptionAdditional}");
            }

            //--------------------------------------------------------------------------------------------------------

            Warrior warrior = new Warrior("Arion");

            //Console.WriteLine($"{warrior.Name} {warrior.HP} HP {warrior.Mana} Mana {warrior.ExtraPoints} Extra");

            Mage mage = new Mage("Ryu Moonlight");

            Rogue rogue = new Rogue("Secret Lione");

            for(int i = 1; i != 32; i++)
            {
                warrior.LevelUp();
                Console.WriteLine();
                Console.WriteLine($"{warrior.Name} {warrior.LVL} lvl {warrior.HP} HP {warrior.Mana} Mana {warrior.ExtraPoints} Extra");

                mage.LevelUp();
                Console.WriteLine();
                Console.WriteLine($"{mage.Name} {mage.LVL} lvl {mage.HP} HP {mage.Mana} Mana {mage.ExtraPoints} Extra");

                rogue.LevelUp();
                Console.WriteLine();
                Console.WriteLine($"{rogue.Name} {rogue.LVL} lvl {rogue.HP} HP {rogue.Mana} Mana {rogue.ExtraPoints} Extra");

                
            }

            //--------------------------------------------------------------------------------------------------------

            HeroMakerDefult hmd = new HeroMakerDefult();

            Console.ReadKey();
        }
    }
}
