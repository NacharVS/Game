using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Hero 
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        protected double hp_Hero = 100;
        protected double strenght = 20;
        protected double intelligence = 20;
        protected double attack_speed = 300;
        protected double extra = 15;
        protected double armor = 10;
        protected double phusical_Attack = 20;
        protected double magic_Attack = 20;
        protected double magic_Defence = 20;
        protected double phisical_Defence = 20;
        protected double woolding_Speed = 20;
        protected double experience;

        [BsonElement]
        public double Hp_Hero { get => hp_Hero; set => hp_Hero = value; }
        [BsonElement]
        public double Extra { get => extra; set => extra = value; }
        [BsonElement]
        public double Strenght { get => strenght; set => strenght = value; }
        [BsonElement]
        public double Intelligence { get => intelligence; set => intelligence = value; }
        [BsonElement]
        public double Attack_speed { get => attack_speed; set => attack_speed = value; }
        [BsonElement]
        public double Armor { get => armor; set => armor = value; }
        [BsonElement]
        public double Experience { get => experience; set => experience = value; }
        [BsonElement]
        public double Magic_Attack { get => magic_Attack; set => magic_Attack = value; }
        [BsonElement]
        public double Magic_Defence { get => magic_Defence; set => magic_Defence = value; }
        [BsonElement]
        public double Phisical_Defence { get => phisical_Defence; set => phisical_Defence = value; }
        [BsonElement]
        public double Wooling_Speed { get => woolding_Speed; set => woolding_Speed = value; }



        public static void Add(Hero hero)
        {
            MongoClient client = new MongoClient();
            var SBase = client.GetDatabase("HeroBase");
            var a = SBase.GetCollection<Hero>("DotaBase");
            a.InsertOne(hero);
        }

    }
}
