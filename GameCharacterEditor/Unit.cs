using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace GameCharacterEditor
{
    class Unit
    {
        protected int lvl = 1;
        protected double hp;
        protected double mp = 100;
        protected string name = "Unit";
        protected double strength;
        protected double dexterity; // ловкость
        protected double intelegence;
        protected double constitution; //телосложение
        private double extra = 0;
        private double attackSpeed;
        protected double walkingSpeed;
        protected double pDefence;
        protected double mDefence;
        protected double pAttack;
        protected double mAttack;
        protected double experience = 0;
        Inventar inventar = new Inventar();

        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        [BsonElement]
        public int Lvl { get => lvl; set => lvl = value; }
        [BsonElement]
        public double Hp { get => hp; set => hp = value; }
        [BsonElement]
        public double Mp { get => mp; set => mp = value; }
        [BsonElement]
        public string Name { get => name; set => name = value; }
        [BsonElement]
        public double Extra { get => extra; set => extra = value; }
        [BsonElement]
        public double Strength { get => strength; set => strength = value; }
        [BsonElement]
        public double Dexterity { get => dexterity; set => dexterity = value; }
        [BsonElement]
        public double Intelegence { get => intelegence; set => intelegence = value; }
        [BsonElement]
        public double AttackSpeed { get => attackSpeed; set => attackSpeed = value; }
        [BsonElement]
        public Inventar Inventar { get => inventar; private set => inventar = value; }
        [BsonElement]
        public double Constitution { get => constitution; set => constitution = value; }
        [BsonElement]
        public double WalkingSpeed { get => walkingSpeed; set => walkingSpeed = value; }
        [BsonElement]
        public double PDefence { get => pDefence; set => pDefence = value; }
        [BsonElement]
        public double MDefence { get => mDefence; set => mDefence = value; }
        [BsonElement]
        public double PAttack { get => pAttack; set => pAttack = value; }
        [BsonElement]
        public double MAttack { get => mAttack; set => mAttack = value; }
        [BsonElement]
        public double Experience { get => experience; set => experience = value; }
        [BsonElement]
        public double Str { get; set; }
        [BsonElement]
        public double Intel { get; set; }
        [BsonElement]
        public double Dex { get; set; }
        [BsonElement]
        public double Cons { get; set; }

        public double MaxStr { get; set; }
        public double MaxDex { get; set; }
        public double MaxIntel { get; set; }
        public double MaxCons { get; set; }

        public Unit(double strength, double dexterity, double constitution, double intelegence, string name, int Lvl)
        {
            this.strength = strength > extra ? strength : extra;
            this.dexterity = dexterity > extra ? dexterity : extra;
            this.intelegence = intelegence > extra ? intelegence : extra;
            this.constitution = constitution > extra ? constitution : extra;
            this.name = name;
            this.Lvl = Lvl;
            hp += strength * 5 + constitution * 10;
            attackSpeed += dexterity * 5;
            walkingSpeed += dexterity * 2;
            pDefence += dexterity * 3 + constitution * 5;
            mAttack += intelegence * 10;
            mp += intelegence * 5;
            mDefence += intelegence * 5;
            pAttack = strength * 5;
        }

        public void PhysAttack()
        {
            if (hp - pAttack <= 0)
            {
                hp = 0;
                throw new Exception("Юнит умер");
            }
            else
                hp -= pAttack;
        }

        public void MagicAttack()
        {
            if (hp - mAttack <= 0)
            {
                hp = 0;
                throw new Exception("Юнит умер");
            }
            else
                hp -= mAttack;
        }

        public void PhysDefence()
        {
            if (hp <= 0)
                throw new Exception("Юнит мертвый");
            else
                hp += pDefence;
        }

        public void MagicDefence()
        {
            if (hp <= 0)
                throw new Exception("Юнит мертвый");
            else
                hp += mDefence;
        }

        public static async void Add(Unit basa)
        {
            try
            {
                MongoClient client = new MongoClient(); // чтобы подключится к серверу надо передать в качестве аргумента {uri}
                var db = client.GetDatabase("Units");
                var collection = db.GetCollection<Unit>("unit_collection");
                await collection.InsertOneAsync(basa);
            }
            catch (Exception ex)
            {
            }
        }

        public static List<Unit> TakeList()
        {
            try
            {
                MongoClient client = new MongoClient();
                var db = client.GetDatabase("Units");
                var collection = db.GetCollection<Unit>("unit_collection");
                List<Unit> lst = collection.AsQueryable().ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось подключиться к БД и получить коллекцию" + ex.Message);
            }
        }
    }

    class Warrior : Unit
    {
        public Warrior() : base(30, 20, 25, 10, "Warrior 1.0", 1)
        {
            MaxStr = 250;
            MaxDex = 70;
            MaxCons = 100;
            MaxIntel = 70;
            name = "Warrior 1.0";
        }
        public Warrior(double strength, double dexterity, double constitution, double intelegence, string name, int Lvl) : base(strength, dexterity, constitution, intelegence, name, Lvl)
        {
            MaxStr = 250;
            MaxDex = 70;
            MaxCons = 100;
            MaxIntel = 70;
        }
    }

    class Sorcerer : Unit
    {
        public Sorcerer() : base(20, 30, 20, 15, "Sorcerer 1.0", 1)
        {
            MaxIntel = 250;
            MaxStr = 100;
            MaxCons = 100;
            MaxDex = 100;
            name = "Sorcerer 1.0";
        }
        public Sorcerer(double strength, double dexterity, double constitution, double intelegence, string name, int Lvl) : base(strength, dexterity, constitution, intelegence, name, Lvl)
        {
            MaxIntel = 250;
            MaxStr = 100;
            MaxCons = 100;
            MaxDex = 100;
        }
    }

    class Rogue : Unit
    {
        public Rogue() : base(15, 20, 20, 30, "Rogue 1.0", 1)
        {
            MaxDex = 250;
            MaxStr = 60;
            MaxIntel = 100;
            MaxCons = 60;
            name = "Rogue 1.0";
        }
        public Rogue(double strength, double dexterity, double constitution, double intelegence, string name, int Lvl) : base(strength, dexterity, constitution, intelegence, name, Lvl)
        {
            MaxDex = 250;
            MaxStr = 60;
            MaxIntel = 100;
            MaxCons = 60;
        }
    }
}