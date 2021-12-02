using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.DrawingCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geroi
{
    class Unit
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        protected double Strenght;
        protected double Agility;
        protected double Intelligence;
        protected string Name;
        protected string Class;
        private static string path = "C:/Users/211925/Desktop/Warrior.jpg";
        public string Path => path;
        private int v1;
        private int v2;
        private int v3;
        private string v4;
        private string v5;

        public Unit(int v1, int v2, int v3, string v4, string v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        public string _class { get => v5; set => Class = value; }
        [BsonElement]
        public string _name { get => v4; set => Name = value; }
        [BsonElement]
        public double _strenght { get => v1; set => Strenght = value; }
        [BsonElement]
        public double _agility { get => v2; set => Agility = value; }
        [BsonElement]
        public double _intelligence { get => v3; set => Intelligence = value; }
        [BsonElement]
        public string _image { get => path; set => path = value; }




        public void Add(Unit unit)
        {
            MongoClient client = new MongoClient();
            var abase = client.GetDatabase("111");
            var b = abase.GetCollection<Unit>("Shakirov_DB");
            b.InsertOne(unit);
        }
        public static void FindFrom(Unit unit)
        {
            MongoClient client = new MongoClient();
            var abase = client.GetDatabase("111");
            var b = abase.GetCollection<Unit>("Shakirov_DB");
            var listPerson = b.Find(Geroi => unit._name == "ovosh").ToList();
            foreach (Unit unit1 in listPerson)
            {
                Console.WriteLine($"{unit._name}");
            }
        }
    }
}
