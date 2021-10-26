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
        protected double Strenght = 20;
        protected double Agility = 35;
        protected double Intelligence = 25;
        [BsonElement]
        public double strenght { get => Strenght; set => Strenght = value; }
        [BsonElement]
        public double agility { get => Agility; set => Agility = value; }
        [BsonElement]
        public double intelligence { get => Intelligence; set => Intelligence = value; }
        public static void Add(Object unit)
        {
            MongoClient client = new MongoClient();
            var abase = client.GetDatabase("111");
            var b = abase.GetCollection<Object>("Shakirov_DB");
            b.InsertOne(unit);
        }
    }
}
