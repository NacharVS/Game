using System;
using System.Collections.Generic;
using System.Text;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace GameCharacterEditor
{
    class Unit
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId id { get; set; }

        //protected double hp_Unit = 100;
        //protected double mp_Unit = 100;
        protected double strenght = 20;
        protected double dexterity = 20;
        protected double intelegence = 20;
        protected string clas;
        //protected double extra = 20;
        //protected double attackSpeed;
        //protected double phusical_Attack = 20;
        //protected double magic_Attack = 20;
        //protected double magic_Defence = 20;
        //protected double phisical_Defence = 20;
        //protected double woolding_Speed = 20;
        protected double experience;

        [BsonElement]
        public double Strenght { get => strenght; set => strenght = value; }

        [BsonElement]
        public double Dexterity { get => dexterity; set => dexterity = value; }

        [BsonElement]
        public double Intelegence { get => intelegence; set => intelegence = value; }

        [BsonElement]
        public string Classs { get => clas; set => clas = value; }

        [BsonElement]
        public double Experience { get => experience; set => experience = value; }

        //[BsonElement]
        //public double HP_Unit { get => hp_Unit; set => hp_Unit = value; }

        //[BsonElement]
        //public double MP_Unit { get => mp_Unit; set => mp_Unit = value; }

        //[BsonElement]
        //public double Extra { get => extra; set => extra = value; }

        //[BsonElement]
        //public double AttackSpeed { get => attackSpeed; set => attackSpeed = value; }

        //[BsonElement]
        //public double Phusical_Attack { get => phusical_Attack; set => phusical_Attack = value; }

        //[BsonElement]
        //public double Magic_Attack { get => magic_Attack; set => magic_Attack = value; }

        //[BsonElement]
        //public double Magic_Defence { get => magic_Defence; set => magic_Defence = value; }

        //[BsonElement]
        //public double Phisical_Defence { get => phisical_Defence; set => phisical_Defence = value; }

        //[BsonElement]
        //public double Wooling_Speed { get => woolding_Speed; set => woolding_Speed = value; }

        public static double MaxStrenght { get; set; }
        public static double MaxdDexterity { get; set; }
        public static double MaxIntelegence { get; set; }
        public static double MaxConstitution { get; set; }

        public Unit(double str, double inte, double agl)
        {
            strenght = str;
            dexterity = agl;
            intelegence = inte;
        }

        public static void Add(Unit unit)
        {
            MongoClient client = new MongoClient();
            var hrbase = client.GetDatabase("Herobase");
            var a = hrbase.GetCollection<Unit>("Game_Rybakov");
            a.InsertOne(unit);
        }
    }

    class Unit_Warrior
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId id { get; set; }

        protected double strenght = 20;
        protected double dexterity = 20;
        protected double intelegence = 20;
        protected string clas;
        public static string image = "E:\\Game5\\GameCharacterEditor\\Pictures\\Warrior.png";
        private static string W_image = image;
        public string IMG => image;

        protected double experience;

        [BsonElement]
        public double Strenght { get => strenght; set => strenght = value; }

        [BsonElement]
        public double Dexterity { get => dexterity; set => dexterity = value; }

        [BsonElement]
        public double Intelegence { get => intelegence; set => intelegence = value; }

        [BsonElement]
        public string Classs { get => clas; set => clas = value; }

        [BsonElement]
        public double Experience { get => experience; set => experience = value; }

        [BsonElement]
        public string Image { get => IMG; set => W_image = value; }

        public static double MaxStrenght { get; set; }
        public static double MaxdDexterity { get; set; }
        public static double MaxIntelegence { get; set; }
        public static double MaxConstitution { get; set; }

        public Unit_Warrior(double str, double inte, double agl)
        {
            strenght = str;
            dexterity = agl;
            intelegence = inte;
        }

        public static void Add(Unit_Warrior unit)
        {
            MongoClient client = new MongoClient();
            var hrbase = client.GetDatabase("Herobase");
            var a = hrbase.GetCollection<Unit_Warrior>("Game_Rybakov");
            a.InsertOne(unit);
        }
    }

    class Unit_Bandit
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId id { get; set; }

        protected double strenght = 20;
        protected double dexterity = 20;
        protected double intelegence = 20;
        protected string clas;
        public static string image = "E:\\Game5\\GameCharacterEditor\\Pictures\\Bandit.png";
        private static string W_image = image;
        public string IMG => image;

        protected double experience;

        [BsonElement]
        public double Strenght { get => strenght; set => strenght = value; }

        [BsonElement]
        public double Dexterity { get => dexterity; set => dexterity = value; }

        [BsonElement]
        public double Intelegence { get => intelegence; set => intelegence = value; }

        [BsonElement]
        public string Classs { get => clas; set => clas = value; }

        [BsonElement]
        public double Experience { get => experience; set => experience = value; }

        [BsonElement]
        public string Image { get => IMG; set => W_image = value; }

        public static double MaxStrenght { get; set; }
        public static double MaxdDexterity { get; set; }
        public static double MaxIntelegence { get; set; }
        public static double MaxConstitution { get; set; }

        public Unit_Bandit(double str, double inte, double agl)
        {
            strenght = str;
            dexterity = agl;
            intelegence = inte;
        }

        public static void Add(Unit_Bandit unit)
        {
            MongoClient client = new MongoClient();
            var hrbase = client.GetDatabase("Herobase");
            var a = hrbase.GetCollection<Unit_Bandit>("Game_Rybakov");
            a.InsertOne(unit);
        }
    }

    class Unit_Healer
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId id { get; set; }

        protected double strenght = 20;
        protected double dexterity = 20;
        protected double intelegence = 20;
        protected string clas;
        public static string image = "E:\\Game5\\GameCharacterEditor\\Pictures\\Healer.png";
        private static string W_image = image;
        public string IMG => image;

        protected double experience;

        [BsonElement]
        public double Strenght { get => strenght; set => strenght = value; }

        [BsonElement]
        public double Dexterity { get => dexterity; set => dexterity = value; }

        [BsonElement]
        public double Intelegence { get => intelegence; set => intelegence = value; }

        [BsonElement]
        public string Classs { get => clas; set => clas = value; }

        [BsonElement]
        public double Experience { get => experience; set => experience = value; }

        [BsonElement]
        public string Image { get => IMG; set => W_image = value; }

        public static double MaxStrenght { get; set; }
        public static double MaxdDexterity { get; set; }
        public static double MaxIntelegence { get; set; }
        public static double MaxConstitution { get; set; }

        public Unit_Healer(double str, double inte, double agl)
        {
            strenght = str;
            dexterity = agl;
            intelegence = inte;
        }

        public static void Add(Unit_Healer unit)
        {
            MongoClient client = new MongoClient();
            var hrbase = client.GetDatabase("Herobase");
            var a = hrbase.GetCollection<Unit_Healer>("Game_Rybakov");
            a.InsertOne(unit);
        }
    }

    class Unit_Mage
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId id { get; set; }

        protected double strenght = 20;
        protected double dexterity = 20;
        protected double intelegence = 20;
        protected string clas;
        public static string image = "E:\\Game5\\GameCharacterEditor\\Pictures\\Mage.png";
        private static string W_image = image;
        public string IMG => image;

        protected double experience;

        [BsonElement]
        public double Strenght { get => strenght; set => strenght = value; }

        [BsonElement]
        public double Dexterity { get => dexterity; set => dexterity = value; }

        [BsonElement]
        public double Intelegence { get => intelegence; set => intelegence = value; }

        [BsonElement]
        public string Classs { get => clas; set => clas = value; }

        [BsonElement]
        public double Experience { get => experience; set => experience = value; }

        [BsonElement]
        public string Image { get => IMG; set => W_image = value; }

        public static double MaxStrenght { get; set; }
        public static double MaxdDexterity { get; set; }
        public static double MaxIntelegence { get; set; }
        public static double MaxConstitution { get; set; }

        public Unit_Mage(double str, double inte, double agl)
        {
            strenght = str;
            dexterity = agl;
            intelegence = inte;
        }

        public static void Add(Unit_Mage unit)
        {
            MongoClient client = new MongoClient();
            var hrbase = client.GetDatabase("Herobase");
            var a = hrbase.GetCollection<Unit_Mage>("Game_Rybakov");
            a.InsertOne(unit);
        }
    }

    class Unit_Robber
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId id { get; set; }

        protected double strenght = 20;
        protected double dexterity = 20;
        protected double intelegence = 20;
        protected string clas;
        public static string image = "E:\\Game5\\GameCharacterEditor\\Pictures\\Robber.png";
        private static string W_image = image;
        public string IMG => image;

        protected double experience;

        [BsonElement]
        public double Strenght { get => strenght; set => strenght = value; }

        [BsonElement]
        public double Dexterity { get => dexterity; set => dexterity = value; }

        [BsonElement]
        public double Intelegence { get => intelegence; set => intelegence = value; }

        [BsonElement]
        public string Classs { get => clas; set => clas = value; }

        [BsonElement]
        public double Experience { get => experience; set => experience = value; }

        [BsonElement]
        public string Image { get => IMG; set => W_image = value; }

        public static double MaxStrenght { get; set; }
        public static double MaxdDexterity { get; set; }
        public static double MaxIntelegence { get; set; }
        public static double MaxConstitution { get; set; }

        public Unit_Robber(double str, double inte, double agl)
        {
            strenght = str;
            dexterity = agl;
            intelegence = inte;
        }

        public static void Add(Unit_Robber unit)
        {
            MongoClient client = new MongoClient();
            var hrbase = client.GetDatabase("Herobase");
            var a = hrbase.GetCollection<Unit_Robber>("Game_Rybakov");
            a.InsertOne(unit);
        }
    }
}