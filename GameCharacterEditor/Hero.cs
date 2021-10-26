using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace GameCharacterEditor
{
    class Hero
    {
        protected double strenght = 20;
        protected double intelligence = 80;
        protected double attack_speed = 260;
        protected double extra = 40;
        protected double armor = 7;
        protected double agility = 15;


        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId id { get; set; }
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
        public double Agility { get => agility; set => agility = value; }
        [BsonElement]
        public double Kol { get => extra; set => extra = value; }


    }
    public class Person
    {
        [BsonElement]
        string sila;
        [BsonElement]
        string lov;
        [BsonElement]
        string inteleg;
        [BsonElement]
        string Aspeed;
        [BsonElement]
        string Bronya;
        [BsonElement]
        string extra;
        private TextBox strenght;
        private TextBox agility;
        private TextBox intelligence;
        private TextBox attack_speed;
        private TextBox armor;
        private TextBox kol;

        public Person(string strenght, string agility, string intelligence, string attack_speed, string armor, string kol)
        {
            sila = strenght;
            lov = agility;
            inteleg = intelligence;
            Aspeed = attack_speed;
            Bronya = armor;
            extra = kol;
        }

        public Person(TextBox strenght, TextBox agility, TextBox intelligence, TextBox attack_speed, TextBox armor, TextBox kol)
        {
            this.strenght = strenght;
            this.agility = agility;
            this.intelligence = intelligence;
            this.attack_speed = attack_speed;
            this.armor = armor;
            this.kol = kol;
        }

        public static async void Add(Person person)
        {
            MongoClient client = new MongoClient();
            var SBase = client.GetDatabase("HeroBase");
            var a = SBase.GetCollection<Person>("DotaBase");
            await a.InsertOneAsync(person);
        }
    }
}
