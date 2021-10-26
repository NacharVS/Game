using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace GameCharacterEditor
{
    class Hero
    {
        protected double strength = 20;
        protected double doxterity = 20;
        protected double intelegence = 20;
        protected double constitution = 20;
        protected double lvl = 1;
        protected string name = string.Empty;
        protected double hp = 100;
        protected double mp = 100;
        protected double attackSpeed = 0;
        protected double walkingSpeed = 0;
        protected double pAttack = 0;
        protected double pDefence = 0;
        protected double mAttack = 0;
        protected double mDefence = 0;
        protected double extra = 0;

        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        public double Level { get => lvl; set => lvl = value; }
        public double Strength { get => strength; set => strength = value; }
        public double Doxterity { get => doxterity; set => doxterity = value; }
        public double Extra { get => extra; set => extra = value; }
        public double Intelegence { get => intelegence; set => intelegence = value; }
        public double Constitution { get => constitution; set => constitution = value; }
        public double HP { get => hp; set => hp = value; }
        public double MP { get => mp; set => mp = value; }
        public double AttackSpeed { get => attackSpeed; set => attackSpeed = value; }
        public double WalkingSpeed { get => walkingSpeed; set => walkingSpeed = value; }

        public double PAttack { get => pAttack; set => pAttack = value; }
        public double PDefence { get => pDefence; set => pDefence = value; }
        public double MAttack { get => mAttack; set => mAttack = value; }
        public double MDefence { get => mDefence; set => mDefence = value; }
        public string Name { get => name; set => name = value; }



        public Hero(double strength, double doxterity, double intelegence, double constitution, string name, double lvl, double extra)
        {
            this.strength = strength;
            this.doxterity = doxterity;
            this.intelegence = intelegence;
            this.constitution = constitution;
            this.name = name;
            this.lvl = lvl;
            this.extra = extra;
            hp = strength * 5 + constitution * 10;
            mp = intelegence * 5;
            attackSpeed = doxterity * 5;
            walkingSpeed = doxterity * 2;
            pAttack = strength * 5;
            mAttack = intelegence * 10;
            mDefence = intelegence * 5;
            pDefence += constitution * 5 + doxterity * 3;
        }

        public static List<Hero> TakeList()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("Persons");
            var collection = db.GetCollection<Hero>("person");
            List<Hero> lst = collection.AsQueryable().ToList();
            return lst;
        }
    }
}
