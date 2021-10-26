using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
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
        private int v1;
        private int v2;
        private int v3;

        public Unit(int v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public double strenght { get => v1; set => Strenght = value; }
        [BsonElement]
        public double agility { get => v2; set => Agility = value; }
        [BsonElement]
        public double intelligence { get => v3; set => Intelligence = value; }

        public void Add(Unit unit)
        {
            MongoClient client = new MongoClient();
            var abase = client.GetDatabase("111");
            var b = abase.GetCollection<Unit>("Shakirov_DB");
            b.InsertOne(unit);
        }
    }
}
