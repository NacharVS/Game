using System;
using System.Collections.Generic;
using GameCore;
using GameCore.Items;
using GameCore.Class;
using HeroFabric;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System.IO;
using MongoDB.Bson;

namespace ConsoleGameTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //PotionHP potionHP = new PotionHP("stuff",100, 50);
            //Console.WriteLine(potionHP.Name);

            //List<GameItem> gameItems = new List<GameItem>()
            //{
            //    new PotionHP("Middle Health Potion", 50, 25),
            //    new PotionMana("Middle Mana Potion", 50, 25),
            //    new PotionHP("Potion of Spirit", 100, "Heal your Hero 50HP", "Hmm... It`s smell like a swamp frog.", 50),
            //    new PotionHP("Root Beer", 70, "Heal your Hero 30HP", "Sit down traveler, rest in our tavern.", 35),
            //    new PotionMana("Wild Flask", 75, "Your Hero get 45Mana", "UNSTOPPABLE WILD NATURAL POWER!", 45),
            //    new PotionMana("Lucky Golden Jug", 250, "???", "Damn, it looks so expensive...", 5)
            //};

            //foreach(var item in gameItems)
            //{
            //    Console.WriteLine($"{item.Name} {item.Price}$ {item.DescriptionMain} {item.DescriptionAdditional}");
            //}

            ////--------------------------------------------------------------------------------------------------------

            //Warrior warrior = new Warrior("Arion");

            ////Console.WriteLine($"{warrior.Name} {warrior.HP} HP {warrior.Mana} Mana {warrior.ExtraPoints} Extra");

            //Mage mage = new Mage("Ryu Moonlight");

            //Rogue rogue = new Rogue("Secret Lione");

            //for(int i = 1; i != 10; i++)
            //{
            //    warrior.GetXP(1000);
            //    Console.WriteLine($"{warrior.Name} {warrior.Level} {warrior.XP} {warrior.HP}HP {warrior.Mana}Mana");  
            //}

            //for (int i = 1; i != 2; i++)
            //{
            //    mage.GetXP(1000);
            //    Console.WriteLine($"{mage.Name} {mage.Level} {mage.XP} {mage.HP}HP {mage.Mana}Mana");
            //}
            ////--------------------------------------------------------------------------------------------------------

            //HeroMakerDefult hmd = new HeroMakerDefult();

            //Console.ReadKey();

            UploadFileAsync().GetAwaiter().GetResult();

            DownloadFileAsync().GetAwaiter().GetResult();

            Console.ReadKey();
        }

        private static async Task UploadFileAsync()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("test");

            IGridFSBucket gridFS = new GridFSBucket(database);
            using (Stream fs = new FileStream(@"C:\Users\211915\Desktop\danil.jpg", FileMode.Open))
            {
                ObjectId id = await gridFS.UploadFromStreamAsync("danil.jpg", fs);
                Console.WriteLine("id файла: {0}", id.ToString());
            }
        }

        private static async Task DownloadFileAsync()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("test");
            IGridFSBucket gridFS = new GridFSBucket(database);

            using (Stream fs = new FileStream(@"C:\Users\211915\Desktop\danil_new.jpg", FileMode.OpenOrCreate))
            {
                await gridFS.DownloadToStreamByNameAsync("danil.jpg", fs);
            }
        }
    }
}
