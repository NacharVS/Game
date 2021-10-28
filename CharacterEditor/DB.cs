using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    class DB
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        protected double Strenght;
        protected double Agility;
        protected double Intelligence;
        protected string LvL;
        protected string HP;
        protected string Mana;
        protected string Class;
        private int v1;
        private int v2;
        private int v3;
        private string v4;
        private string v5;
        private string v6;
        private string v7;
        public DB(int v1, int v2, int v3, string v4, string v5, string v6, string v7)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
        }

        public double _strenght { get => v1; set => Strenght = value; }
        [BsonElement]
        public double _agility { get => v2; set => Agility = value; }
        [BsonElement]
        public double _intelligence { get => v3; set => Intelligence = value; }
        [BsonElement]
        public string _LvL { get => v4; set => LvL = value; }
        public string _HP { get => v5; set => HP = value; }
        public string _Mana { get => v6; set => Mana = value; }
        public string _Class { get => v7; set => Class = value; }



        public void Add(DB db1)
        {
            MongoClient client = new MongoClient();
            var abase = client.GetDatabase("GGG");
            var b = abase.GetCollection<DB>("Gizetdinov_DB");
            b.InsertOne(db1);
        }
    }
}